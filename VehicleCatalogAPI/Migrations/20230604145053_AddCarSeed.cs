using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleCatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCarSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[,]
                {
                    { 1, "salmon", 42.7006802324006000m, 2, true, 8.8118069377026430m, "Bentley", "Grand Caravan", 474.0, 8, 2, 4, 250.089404194716000m, 2018 },
                    { 2, "plum", 13.69985788441360800m, 2, false, 6.1611025245503650m, "Aston Martin", "2", 709.0, 4, 1, 10, 232.9022431416184000m, 1993 },
                    { 3, "teal", 23.5287886505068400m, 4, false, 1.071867549655902830m, "Chevrolet", "Silverado", 513.0, 5, 1, 7, 139.7357092117654000m, 2018 },
                    { 4, "indigo", 36.2485069018643600m, 4, true, 8.4796764905465440m, "Mazda", "Taurus", 479.0, 7, 0, 2, 111.04557590078564000m, 1989 },
                    { 5, "lime", 45.9186868026987600m, 4, true, 17.2014382396592790m, "Dodge", "2", 599.0, 6, 0, 10, 139.6689453526222000m, 1984 },
                    { 6, "indigo", 48.4086622636228400m, 4, true, 8.636457373703890m, "Nissan", "Corvette", 846.0, 4, 0, 4, 104.85047556680816000m, 2005 },
                    { 7, "mint green", 27.553905014343200m, 4, false, 2.9839265456086390m, "Smart", "Fiesta", 772.0, 8, 2, 5, 152.8577630220628000m, 1992 },
                    { 8, "indigo", 44.7425216379386400m, 2, false, 4.8979112041070290m, "Honda", "Impala", 192.0, 2, 2, 3, 102.42944566558588000m, 2014 },
                    { 9, "purple", 21.2207036138469200m, 2, false, 18.0109220002782490m, "Toyota", "Grand Caravan", 682.0, 6, 1, 10, 277.2547378448376000m, 2018 },
                    { 10, "olive", 38.11946919920400m, 4, false, 5.1360828441934560m, "Jeep", "Impala", 741.0, 5, 0, 7, 212.969178266562000m, 2016 },
                    { 11, "gold", 36.803892653748800m, 4, true, 14.148778880264470m, "Mercedes Benz", "Aventador", 956.0, 8, 1, 4, 272.7073662661894000m, 1996 },
                    { 12, "ivory", 48.0146453228074000m, 2, true, 7.5963948185422610m, "Mercedes Benz", "Countach", 787.0, 6, 2, 1, 209.2282394003192000m, 2001 },
                    { 13, "grey", 45.7996069646996400m, 2, true, 5.8720816938027140m, "Cadillac", "Explorer", 300.0, 7, 1, 4, 154.6057824703814000m, 2001 },
                    { 14, "fuchsia", 21.0805627018864400m, 2, true, 6.5196734302030180m, "Toyota", "911", 138.0, 6, 0, 1, 175.9205635289690000m, 2012 },
                    { 15, "turquoise", 43.0005759531191200m, 2, true, 14.1909534121338390m, "Cadillac", "Aventador", 217.0, 8, 1, 2, 242.986977131892000m, 2003 },
                    { 16, "indigo", 19.234250071116800m, 4, true, 16.3413806243659170m, "Fiat", "CTS", 639.0, 6, 2, 2, 235.2351896922206000m, 2020 },
                    { 17, "cyan", 38.6742747522510000m, 4, true, 2.22448380816379680m, "Dodge", "Model S", 316.0, 4, 0, 8, 276.7346257374704000m, 1988 },
                    { 18, "gold", 12.82975639855881200m, 2, false, 3.5414989740980430m, "Volkswagen", "Wrangler", 445.0, 6, 2, 6, 259.4602682844632000m, 1995 },
                    { 19, "mint green", 42.2887255466635200m, 2, true, 13.6860741534920340m, "Bugatti", "Spyder", 604.0, 8, 2, 3, 170.1358709170426000m, 1991 },
                    { 20, "black", 14.3100753607995200m, 2, true, 2.9269693018908940m, "Ferrari", "Mustang", 877.0, 4, 0, 1, 160.385554940870000m, 1994 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
