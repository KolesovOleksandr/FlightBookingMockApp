using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _2023_Kolesov_O_O_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class InitDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "Germany" },
                    { 4, "France" },
                    { 5, "UK" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Black" },
                    { 2, "Aron", "Smith" },
                    { 3, "Taras", "Clarc" },
                    { 4, "Brian", "Lester" },
                    { 5, "Krieg", "Allice" }
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "PlaneId", "PlaneName" },
                values: new object[,]
                {
                    { 1, "Airbus" },
                    { 2, "Boeing" },
                    { 3, "McDonnel" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "CountryId" },
                values: new object[,]
                {
                    { 1, "Vinnytsia", 1 },
                    { 2, "Kyiv", 1 },
                    { 3, "Krakiv", 2 },
                    { 4, "Warshawa", 2 },
                    { 5, "Berlin", 3 },
                    { 6, "Hamburg", 3 },
                    { 7, "Paris", 4 },
                    { 8, "Bordo", 4 },
                    { 9, "London", 5 },
                    { 10, "Liverpool", 5 }
                });

            migrationBuilder.InsertData(
                table: "Documents",
                columns: new[] { "DocumentId", "DocumentName", "DocumentNumber", "PassengerId" },
                values: new object[,]
                {
                    { 1, "Passport", 213123L, 1 },
                    { 2, "Foreign Passport", 214324L, 2 },
                    { 3, "Passport", 215234L, 3 },
                    { 4, "Foreign Passport", 215564L, 4 },
                    { 5, "Passport", 216237L, 5 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "FlightId", "DeparturePointId", "DestinationPointId", "FlightNumber", "PlaneId" },
                values: new object[,]
                {
                    { 1, 1, 2, "qwerty-12345", 1 },
                    { 2, 2, 3, "qwerty-12424", 2 },
                    { 3, 3, 4, "qwerty-12347", 3 },
                    { 4, 4, 5, "qwerty-12341", 1 },
                    { 5, 5, 1, "qwerty-12340", 2 }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AquirementTime", "DocumentId", "FlightId", "ReturnmentTime", "SeatNumber", "TicketNumber", "TicketPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 3, 14, 52, 46, 691, DateTimeKind.Local).AddTicks(4674), 1, 1, new DateTime(2022, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), 10, "12345-asd", 100.0 },
                    { 2, new DateTime(2023, 6, 3, 14, 52, 46, 691, DateTimeKind.Local).AddTicks(4734), 2, 2, new DateTime(2022, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), 11, "12345-kjsd", 101.0 },
                    { 3, new DateTime(2023, 6, 3, 14, 52, 46, 691, DateTimeKind.Local).AddTicks(4737), 3, 3, new DateTime(2022, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), 12, "12345-uio", 102.0 },
                    { 4, new DateTime(2023, 6, 3, 14, 52, 46, 691, DateTimeKind.Local).AddTicks(4739), 4, 4, new DateTime(2022, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), 13, "123456-rewq", 101.0 },
                    { 5, new DateTime(2023, 6, 3, 14, 52, 46, 691, DateTimeKind.Local).AddTicks(4741), 5, 5, new DateTime(2022, 12, 31, 23, 59, 59, 0, DateTimeKind.Unspecified), 7, "12345-qwerty", 101.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Documents",
                keyColumn: "DocumentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Flights",
                keyColumn: "FlightId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "PlaneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);
        }
    }
}
