using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleCatalogAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddCarExtraSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarExtras",
                columns: new[] { "CarId", "ExtraId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 4, 1 },
                    { 4, 2 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 4 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 3 },
                    { 7, 1 },
                    { 8, 1 },
                    { 8, 2 },
                    { 10, 1 },
                    { 11, 1 },
                    { 11, 2 },
                    { 11, 3 },
                    { 12, 1 },
                    { 13, 1 },
                    { 13, 2 },
                    { 13, 3 },
                    { 13, 4 },
                    { 14, 1 },
                    { 14, 2 },
                    { 14, 3 },
                    { 14, 4 },
                    { 15, 1 },
                    { 16, 1 },
                    { 16, 2 },
                    { 17, 1 },
                    { 17, 2 },
                    { 18, 1 },
                    { 18, 2 },
                    { 18, 3 },
                    { 19, 1 },
                    { 19, 2 },
                    { 20, 1 },
                    { 20, 2 },
                    { 20, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "blue", 43.3567854786498000m, 4, true, 13.5464571315863020m, "Chevrolet", "Expedition", 613.0, 3, 5, 206.9196881359262000m, 2016 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "gold", 39.0423830191253200m, 2, 19.30829682785680m, "Rolls Royce", "2", 882.0, 5, 0, 8, 269.9560460132542000m, 1988 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "purple", 40.6547947213448400m, 4, 4.4798307864773540m, "Volvo", "Grand Caravan", 654.0, 7, 0, 0, 242.2264621849372000m, 1998 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "violet", 45.5248560339300400m, 4, true, 14.5433773008645310m, "Mazda", "Accord", 555.0, 4, 1, 1, 125.507183691096000m, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "salmon", 15.1792431150171200m, 14.9949548337398460m, "Mercedes Benz", "ATS", 421.0, 4, 0, 245.651179524976000m, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "orange", 14.9789215171161200m, 13.4868610776610220m, "Audi", "CX-9", 999.0, 6, 0, 0, 215.2455277816430000m, 2010 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "cyan", 37.4674995053566400m, 5.9011292572495150m, "Polestar", "Taurus", 326.0, 2, 2, 3, 113.97347285213204000m, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "black", 31.8524085022105600m, 14.9223836862954470m, "Chevrolet", "Cruze", 211.0, 3, 3, 172.1929696577998000m, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "magenta", 25.9343734359880800m, 9.478224158278670m, "Jaguar", "Fortwo", 624.0, 6, 1, 8, 191.5102939163978000m, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Day", "Doors", "Hour", "Make", "Model", "Power", "Week", "Year" },
                values: new object[] { 48.3659580303438400m, 2, 18.2998871979076930m, "Bugatti", "Ranchero", 570.0, 221.2424441942688000m, 1989 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "plum", 25.6092511324434800m, 5.0965754566411970m, "Jeep", "A4", 834.0, 4, 2, 1, 149.0088706036658000m, 1996 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "silver", 31.0350200198142000m, 2, 5.4697959349158310m, "Volkswagen", "ATS", 85.0, 4, 1, 9, 265.4005528457922000m, 1990 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "lime", 15.0798155472773200m, 2, false, 3.3747103452788060m, "Honda", "Grand Cherokee", 616.0, 2, 2, 1, 275.6244517853248000m, 2009 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "magenta", 28.6928217934719200m, 2, 18.9057262901767140m, "Maserati", "Model S", 359.0, 7, 2, 4, 214.7107222148124000m, 1986 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "purple", 31.1486945487898800m, true, 19.2419890197637560m, "Nissan", "Grand Caravan", 117.0, 4, 1, 3, 291.3199643554496000m, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "cyan", 41.3779863736070000m, 13.9246563779750570m, "Dodge", "Jetta", 937.0, 4, 1, 4, 294.8710105520848000m, 2006 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "azure", 49.1816621805397200m, true, 14.466361051275050m, "Smart", "A4", 671.0, 7, 0, 2, 242.8501836205544000m, 2001 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "silver", 27.0150984972475600m, true, 3.0723676353806520m, "Fiat", "Focus", 935.0, 6, 3, 163.655081094104000m, 1993 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "violet", 24.9102244660538800m, 3.7069090551739840m, "Ferrari", "A4", 209.0, 2, 10, 187.4436411096988000m, 1995 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "lavender", 24.1503939251612800m, 16.0863899414939940m, "Honda", "Altima", 219.0, 4, 7, 173.7463637493528000m, 2015 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 11, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 13, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 14, 4 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 17, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 18, 3 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 19, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "CarExtras",
                keyColumns: new[] { "CarId", "ExtraId" },
                keyValues: new object[] { 20, 3 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "turquoise", 29.5052546629170400m, 2, false, 9.6248968412186330m, "Maserati", "Alpine", 311.0, 7, 3, 160.5087902019458000m, 1992 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "yellow", 12.25600506574068800m, 4, 14.4159399123348760m, "Polestar", "Spyder", 930.0, 2, 1, 2, 242.3316605092364000m, 2014 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "yellow", 44.6071792675311600m, 2, 8.2894530966930410m, "Land Rover", "Challenger", 567.0, 4, 1, 7, 142.5162439032604000m, 2002 });

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
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "magenta", 25.9875487953083600m, 16.1023100084902340m, "Maserati", "Altima", 487.0, 8, 2, 286.7167392104758000m, 1980 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "lavender", 20.8736406958490800m, 13.4100801951380010m, "Porsche", "Charger", 298.0, 4, 1, 6, 295.6009920653302000m, 2021 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "azure", 41.3239384217474400m, 17.659709944401760m, "Audi", "Mercielago", 167.0, 6, 0, 10, 132.1275544443862000m, 2015 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "mint green", 24.7627382865467600m, 13.391698664998530m, "Fiat", "Golf", 230.0, 8, 5, 189.1690334985898000m, 1996 });

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
                columns: new[] { "Day", "Doors", "Hour", "Make", "Model", "Power", "Week", "Year" },
                values: new object[] { 33.3119739695690400m, 4, 4.3738929563169540m, "Land Rover", "Model S", 994.0, 241.2613809589510000m, 1983 });

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
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "olive", 27.6547659812329200m, 4, 8.4862978047796680m, "Jaguar", "Altima", 366.0, 2, 0, 2, 270.3025007192372000m, 1982 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Color", "Day", "Doors", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "grey", 47.5443507351043200m, 4, true, 19.6800718246914210m, "Bentley", "Colorado", 946.0, 5, 1, 7, 140.5178485525564000m, 1983 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Color", "Day", "Doors", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "red", 25.8720657515004800m, 4, 9.2701406847083680m, "Mini", "CX-9", 763.0, 6, 0, 8, 166.1540212047992000m, 1981 });

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
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "olive", 41.2761426692985600m, 19.4338521111378730m, "Kia", "Wrangler", 393.0, 3, 2, 5, 162.9967423123986000m, 2018 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "maroon", 10.374286833739012800m, false, 4.6383661424051510m, "Bugatti", "XC90", 665.0, 8, 1, 7, 118.56728221944848000m, 1997 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Color", "Day", "Electric", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "lime", 32.9676089748277600m, false, 7.4905554344938840m, "Dodge", "XC90", 419.0, 4, 9, 192.7560209136164000m, 1985 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Transmission", "Type", "Week", "Year" },
                values: new object[] { "plum", 33.0686011877770400m, 14.3357275902936980m, "Chevrolet", "Malibu", 693.0, 0, 7, 155.6975270602324000m, 2019 });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Color", "Day", "Hour", "Make", "Model", "Power", "Seats", "Type", "Week", "Year" },
                values: new object[] { "lime", 26.422702014286400m, 1.49115392879476420m, "Volvo", "Grand Caravan", 423.0, 8, 4, 241.9632236278982000m, 1993 });
        }
    }
}
