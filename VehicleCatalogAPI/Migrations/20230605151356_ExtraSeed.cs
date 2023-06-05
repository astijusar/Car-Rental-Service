using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleCatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class ExtraSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "turquoise", 29.5052546629170400m, false, 9.6248968412186330m, "Maserati", "Alpine", 311.0, 7, 1, 3, 160.5087902019458000m, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "yellow", 12.25600506574068800m, 4, true, 14.4159399123348760m, "Polestar", "Spyder", 930.0, 2, 2, 242.3316605092364000m, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Week", "Year" },
                values: new object[] { "yellow", 44.6071792675311600m, 2, true, 8.2894530966930410m, "Land Rover", "Challenger", 567.0, 4, 142.5162439032604000m, 2002 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "red", 44.0496196870638800m, 2, false, 12.6787090948182440m, "Kia", "Mustang", 948.0, 6, 2, 0, 279.3140893143196000m, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "magenta", 25.9875487953083600m, 16.1023100084902340m, "Maserati", "Altima", 487.0, 8, 2, 2, 286.7167392104758000m, 1980 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "lavender", 20.8736406958490800m, 13.4100801951380010m, "Porsche", "Charger", 298.0, 1, 6, 295.6009920653302000m, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "azure", 41.3239384217474400m, 2, 17.659709944401760m, "Audi", "Mercielago", 167.0, 6, 0, 10, 132.1275544443862000m, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "mint green", 24.7627382865467600m, 4, 13.391698664998530m, "Fiat", "Golf", 230.0, 8, 1, 5, 189.1690334985898000m, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "sky blue", 21.7396140019134800m, 10.1958484072855010m, "Aston Martin", "Grand Cherokee", 601.0, 5, 0, 1, 283.0047159400250000m, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "pink", 33.3119739695690400m, true, 4.3738929563169540m, "Land Rover", "Model S", 994.0, 4, 1, 4, 241.2613809589510000m, 1983 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "tan", 25.3871580494541600m, 3.0088858207575120m, "Nissan", "Civic", 680.0, 2, 0, 3, 195.4034605153986000m, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "olive", 27.6547659812329200m, 4, false, 8.4862978047796680m, "Jaguar", "Altima", 366.0, 2, 0, 2, 270.3025007192372000m, 1982 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { 47.5443507351043200m, 4, 19.6800718246914210m, "Bentley", "Colorado", 946.0, 5, 7, 140.5178485525564000m, 1983 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Type", "Week", "Year" },
                values: new object[] { "red", 25.8720657515004800m, 4, false, 9.2701406847083680m, "Mini", "CX-9", 763.0, 8, 166.1540212047992000m, 1981 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "mint green", 46.1682693932820800m, false, 7.9611369935961950m, "BMW", "Mercielago", 169.0, 3, 0, 7, 154.8281492856594000m, 2013 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "olive", 41.2761426692985600m, 2, false, 19.4338521111378730m, "Kia", "Wrangler", 393.0, 3, 5, 162.9967423123986000m, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "maroon", 10.374286833739012800m, 2, false, 4.6383661424051510m, "Bugatti", "XC90", 665.0, 8, 1, 7, 118.56728221944848000m, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "lime", 32.9676089748277600m, 7.4905554344938840m, "Dodge", "XC90", 419.0, 4, 9, 192.7560209136164000m, 1985 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "plum", 33.0686011877770400m, 4, false, 14.3357275902936980m, "Chevrolet", "Malibu", 693.0, 0, 7, 155.6975270602324000m, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "lime", 26.422702014286400m, false, 1.49115392879476420m, "Volvo", "Grand Caravan", 423.0, 8, 4, 241.9632236278982000m, 1993 });

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "GPS" },
                    { 2, "AC" },
                    { 3, "Heated seats" },
                    { 4, "Autopilot" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "salmon", 42.7006802324006000m, true, 8.8118069377026430m, "Bentley", "Grand Caravan", 474.0, 8, 2, 4, 250.089404194716000m, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "plum", 13.69985788441360800m, 2, false, 6.1611025245503650m, "Aston Martin", "2", 709.0, 4, 10, 232.9022431416184000m, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Week", "Year" },
                values: new object[] { "teal", 23.5287886505068400m, 4, false, 1.071867549655902830m, "Chevrolet", "Silverado", 513.0, 5, 139.7357092117654000m, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "indigo", 36.2485069018643600m, 4, true, 8.4796764905465440m, "Mazda", "Taurus", 479.0, 7, 0, 2, 111.04557590078564000m, 1989 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "lime", 45.9186868026987600m, 17.2014382396592790m, "Dodge", "2", 599.0, 6, 0, 10, 139.6689453526222000m, 1984 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "indigo", 48.4086622636228400m, 8.636457373703890m, "Nissan", "Corvette", 846.0, 0, 4, 104.85047556680816000m, 2005 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "mint green", 27.553905014343200m, 4, 2.9839265456086390m, "Smart", "Fiesta", 772.0, 8, 2, 5, 152.8577630220628000m, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "indigo", 44.7425216379386400m, 2, 4.8979112041070290m, "Honda", "Impala", 192.0, 2, 2, 3, 102.42944566558588000m, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "purple", 21.2207036138469200m, 18.0109220002782490m, "Toyota", "Grand Caravan", 682.0, 6, 1, 10, 277.2547378448376000m, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "olive", 38.11946919920400m, false, 5.1360828441934560m, "Jeep", "Impala", 741.0, 5, 0, 7, 212.969178266562000m, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "gold", 36.803892653748800m, 14.148778880264470m, "Mercedes Benz", "Aventador", 956.0, 8, 1, 4, 272.7073662661894000m, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "ivory", 48.0146453228074000m, 2, true, 7.5963948185422610m, "Mercedes Benz", "Countach", 787.0, 6, 2, 1, 209.2282394003192000m, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { 45.7996069646996400m, 2, 5.8720816938027140m, "Cadillac", "Explorer", 300.0, 7, 4, 154.6057824703814000m, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Type", "Week", "Year" },
                values: new object[] { "fuchsia", 21.0805627018864400m, 2, true, 6.5196734302030180m, "Toyota", "911", 138.0, 1, 175.9205635289690000m, 2012 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "turquoise", 43.0005759531191200m, true, 14.1909534121338390m, "Cadillac", "Aventador", 217.0, 8, 1, 2, 242.986977131892000m, 2003 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "indigo", 19.234250071116800m, 4, true, 16.3413806243659170m, "Fiat", "CTS", 639.0, 6, 2, 235.2351896922206000m, 2020 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "cyan", 38.6742747522510000m, 4, true, 2.22448380816379680m, "Dodge", "Model S", 316.0, 4, 0, 8, 276.7346257374704000m, 1988 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "gold", 12.82975639855881200m, 3.5414989740980430m, "Volkswagen", "Wrangler", 445.0, 6, 6, 259.4602682844632000m, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "mint green", 42.2887255466635200m, 2, true, 13.6860741534920340m, "Bugatti", "Spyder", 604.0, 2, 3, 170.1358709170426000m, 1991 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "black", 14.3100753607995200m, true, 2.9269693018908940m, "Ferrari", "Mustang", 877.0, 4, 1, 160.385554940870000m, 1994 });
        }
    }
}
