using AutoMapper;
using Azure;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json;
using VehicleCatalogAPI.Controllers;
using VehicleCatalogAPI.Models;
using VehicleCatalogAPI.Models.DTOs;
using VehicleCatalogAPI.Repository.Interfaces;
using VehicleCatalogAPI.RequestFeatures;

namespace VehicleCatalogAPI.Tests
{
    public class CatalogControllerTests
    {
        private readonly Mock<IRepositoryManager> _repositoryManagerMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ILogger<CatalogController>> _loggerMock;

        public CatalogControllerTests()
        {
            _repositoryManagerMock = new Mock<IRepositoryManager>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<CatalogController>>();
        }

        [Fact]
        public async void GetCars_WithValidPaginationParameters_ShouldReturnOkAndDataAndPaginationMetadata()
        {
            var requestParameters = new CarRequestParameters
            {
                PageNumber = 1,
                PageSize = 1
            };

            var cars = new List<Car>
            {
                new Car { Id = 1, Model = "Car 1" }
            };

            var totalCount = cars.Count();

            _mapperMock.Setup(mapper => mapper.Map<CarDto[]>(It.IsAny<Car[]>()))
                .Returns((Car[] cars) => cars.Select(car => new CarDto { Model = car.Model }).ToArray());

            _repositoryManagerMock.Setup(repo => repo.Car.GetCarsAsync(requestParameters, false))
                .ReturnsAsync((cars, totalCount));

            var controller = new CatalogController(_loggerMock.Object, _repositoryManagerMock.Object, _mapperMock.Object);

            // Act
            var result = await controller.GetCars(requestParameters);

            // Assert if the result is of type OkObjectResult
            result.Should().BeOfType<OkObjectResult>();

            var okResult = result.As<OkObjectResult>();
            var response = okResult.Value;

            // Assert if the response is not null and if it has the properties data and pagination
            response.Should().NotBeNull();
            response!.GetType().GetProperty("data").Should().NotBeNull();
            response!.GetType().GetProperty("pagination").Should().NotBeNull();
            
            var data = response.GetType().GetProperty("data")!.GetValue(response, null);
            var pagination = response.GetType().GetProperty("pagination")!.GetValue(response, null);

            // Assert if the data is of type CarDto[] and if the pagination is of type MetaData
            data.Should().BeOfType<CarDto[]>();
            pagination.Should().BeOfType<MetaData>();
        }

        [Fact]
        public async void GetCar_WithExistingId_ShouldReturnOkAndCarDto()
        {
            var carId = 1;

            var car = new Car { Id = 1, Make = "Car" };

            _repositoryManagerMock.Setup(repo => repo.Car.GetCarAsync(carId, false))
                .ReturnsAsync(car);

            _mapperMock.Setup(mapper => mapper.Map<CarDto>(car))
                .Returns(new CarDto { Make = car.Make });

            var controller = new CatalogController(_loggerMock.Object, _repositoryManagerMock.Object, _mapperMock.Object);

            // Act
            var result = await controller.GetCar(carId);

            // Assert if the result is of type OkObjectResult
            result.Should().BeOfType<OkObjectResult>();

            var okResult = result.As<OkObjectResult>();
            var response = okResult.Value;

            // Assert if the response is not null and if it is of type CarDto
            response.Should().NotBeNull();
            response.Should().BeOfType<CarDto>();

            var carDto = response as CarDto;

            carDto.Should().NotBeNull();
        }

        [Fact]
        public async void GetCar_WithNonExistingId_ShouldReturnNotFound()
        {
            var carId = 1;

            _repositoryManagerMock.Setup(repo => repo.Car.GetCarAsync(carId, false))
                .ReturnsAsync((Car)null);

            var controller = new CatalogController(_loggerMock.Object, _repositoryManagerMock.Object, _mapperMock.Object);

            // Act
            var result = await controller.GetCar(carId);

            // Assert if the result is of type NotFoundObjectResult
            result.Should().BeOfType<NotFoundObjectResult>();
        }
    }
}