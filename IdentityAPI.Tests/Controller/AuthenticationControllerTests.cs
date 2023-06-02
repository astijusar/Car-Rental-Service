using AutoMapper;
using FluentAssertions;
using IdentityAPI.Controllers;
using IdentityAPI.Models;
using IdentityAPI.Models.DTO;
using IdentityAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityAPI.Tests.Controller
{
    public class AuthenticationControllerTests
    {
        private readonly AuthenticationController _controller;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<UserManager<User>> _userManagerMock;
        private readonly Mock<IAuthenticationManager> _authManagerMock;

        public AuthenticationControllerTests()
        {
            _mapperMock = new Mock<IMapper>();
            _userManagerMock = new Mock<UserManager<User>>(Mock.Of<IUserStore<User>>(), null, null, null, null, null, null, null, null);
            _authManagerMock = new Mock<IAuthenticationManager>();

            _controller = new AuthenticationController(_mapperMock.Object, _userManagerMock.Object, _authManagerMock.Object);
        }

        [Fact]
        public async Task Authenticate_WithValidUser_ReturnsToken()
        {
            // Arrange
            var userForAuthenticationDto = new UserForAuthenticationDto { };
            var token = "fakeToken";
            _authManagerMock.Setup(x => x.ValidateUser(userForAuthenticationDto)).ReturnsAsync(true);
            _authManagerMock.Setup(x => x.CreateToken()).ReturnsAsync(token);

            // Act
            var result = await _controller.Authenticate(userForAuthenticationDto);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = (OkObjectResult)result;
            okResult.Value.Should().BeEquivalentTo(new { Token = token });
        }

        [Fact]
        public async Task Authenticate_WithInvalidUser_ReturnsUnauthorized()
        {
            // Arrange
            var userForAuthenticationDto = new UserForAuthenticationDto { };
            _authManagerMock.Setup(x => x.ValidateUser(userForAuthenticationDto)).ReturnsAsync(false);

            // Act
            var result = await _controller.Authenticate(userForAuthenticationDto);

            // Assert
            result.Should().BeOfType<UnauthorizedResult>();
        }

        [Fact]
        public async Task RegisterUser_WithValidUser_ReturnsCreatedStatusCode()
        {
            // Arrange
            var userForRegistrationDto = new UserForRegistrationDto { };
            var user = new User { };
            var result = IdentityResult.Success;
            _mapperMock.Setup(x => x.Map<User>(userForRegistrationDto)).Returns(user);
            _userManagerMock.Setup(x => x.CreateAsync(user, userForRegistrationDto.Password)).ReturnsAsync(result);

            // Act
            var response = await _controller.RegisterUser(userForRegistrationDto);

            // Assert
            response.Should().BeOfType<StatusCodeResult>()
                .Which.StatusCode.Should().Be(StatusCodes.Status201Created);
        }

        [Fact]
        public async Task RegisterUser_WithInvalidUser_ReturnsBadRequestWithErrors()
        {
            // Arrange
            var userForRegistrationDto = new UserForRegistrationDto { };
            var user = new User { };
            var erros = new List<IdentityError> { new IdentityError { Code = "code", Description = "description" } };
            var result = IdentityResult.Failed(erros.ToArray());
            _mapperMock.Setup(x => x.Map<User>(userForRegistrationDto)).Returns(user);
            _userManagerMock.Setup(x => x.CreateAsync(user, userForRegistrationDto.Password)).ReturnsAsync(result);

            // Act
            var response = await _controller.RegisterUser(userForRegistrationDto);

            // Assert
            response.Should().BeOfType<BadRequestObjectResult>()
                .Which.Value.Should().BeOfType<SerializableError>()
                .Which.Should().ContainKey("code")
                .WhoseValue.Should().BeEquivalentTo(new[] { "description" });
        }
    }
}
