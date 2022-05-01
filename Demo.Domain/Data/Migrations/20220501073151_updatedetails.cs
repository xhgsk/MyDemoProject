using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Domain.Data.Migrations
{
    public partial class updatedetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("09e9fa09-f654-498b-94f8-1fd15ca45c0a"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("132fdc13-b730-4ecf-9bae-6c2ee4a734c1"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("70d87a42-7dd2-4f8d-a1bb-7ca2bcc25486"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("802da3ae-761d-4b0f-b8c4-764619ad53c6"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("99b03d37-15f5-4588-babe-4ec3dd148365"));

            migrationBuilder.DropColumn(
                name: "Detials",
                table: "Goals");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Goals",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 17, 31, 50, 862, DateTimeKind.Local).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("64de18e0-d1a7-47c2-b477-430d6e68d3bb"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 17, 31, 50, 860, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cee1af96-d756-4a8e-b545-1973518e130a"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 17, 31, 50, 862, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "ClientId", "DateCreated", "Details", "Title" },
                values: new object[,]
                {
                    { new Guid("33b507e6-2908-4e67-a60f-64cdad7fa9a5"), new Guid("64de18e0-d1a7-47c2-b477-430d6e68d3bb"), new DateTime(2022, 5, 1, 17, 31, 50, 863, DateTimeKind.Local).AddTicks(21), "Win any global game", "Win a Game" },
                    { new Guid("afacf8cb-f89e-448f-b617-766fd5bc9111"), new Guid("cee1af96-d756-4a8e-b545-1973518e130a"), new DateTime(2022, 5, 1, 17, 31, 50, 863, DateTimeKind.Local).AddTicks(320), "Earn 1 million dollar", "Get Rich" },
                    { new Guid("289ddcf3-b764-4857-b23e-299d000b2153"), new Guid("cee1af96-d756-4a8e-b545-1973518e130a"), new DateTime(2022, 5, 1, 17, 31, 50, 863, DateTimeKind.Local).AddTicks(339), "Buy a good bike", "Get a Bike" },
                    { new Guid("f1b88e92-fd6d-4d48-9f5d-395c3e814517"), new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"), new DateTime(2022, 5, 1, 17, 31, 50, 863, DateTimeKind.Local).AddTicks(343), "Travel to 100 countrys", "See the World" },
                    { new Guid("f0a8d031-0aaf-4076-afdb-69ee611bdccd"), new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"), new DateTime(2022, 5, 1, 17, 31, 50, 863, DateTimeKind.Local).AddTicks(348), "Find a dream country after see the world", "Find a Country" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("289ddcf3-b764-4857-b23e-299d000b2153"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("33b507e6-2908-4e67-a60f-64cdad7fa9a5"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("afacf8cb-f89e-448f-b617-766fd5bc9111"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("f0a8d031-0aaf-4076-afdb-69ee611bdccd"));

            migrationBuilder.DeleteData(
                table: "Goals",
                keyColumn: "Id",
                keyValue: new Guid("f1b88e92-fd6d-4d48-9f5d-395c3e814517"));

            migrationBuilder.DropColumn(
                name: "Details",
                table: "Goals");

            migrationBuilder.AddColumn<string>(
                name: "Detials",
                table: "Goals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 12, 54, 21, 727, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("64de18e0-d1a7-47c2-b477-430d6e68d3bb"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 12, 54, 21, 725, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("cee1af96-d756-4a8e-b545-1973518e130a"),
                column: "DateCreated",
                value: new DateTime(2022, 5, 1, 12, 54, 21, 727, DateTimeKind.Local).AddTicks(1934));

            migrationBuilder.InsertData(
                table: "Goals",
                columns: new[] { "Id", "ClientId", "DateCreated", "Detials", "Title" },
                values: new object[,]
                {
                    { new Guid("70d87a42-7dd2-4f8d-a1bb-7ca2bcc25486"), new Guid("64de18e0-d1a7-47c2-b477-430d6e68d3bb"), new DateTime(2022, 5, 1, 12, 54, 21, 728, DateTimeKind.Local).AddTicks(2465), "Win any global game", "Win a Game" },
                    { new Guid("132fdc13-b730-4ecf-9bae-6c2ee4a734c1"), new Guid("cee1af96-d756-4a8e-b545-1973518e130a"), new DateTime(2022, 5, 1, 12, 54, 21, 728, DateTimeKind.Local).AddTicks(2759), "Earn 1 million dollar", "Get Rich" },
                    { new Guid("99b03d37-15f5-4588-babe-4ec3dd148365"), new Guid("cee1af96-d756-4a8e-b545-1973518e130a"), new DateTime(2022, 5, 1, 12, 54, 21, 728, DateTimeKind.Local).AddTicks(2777), "Buy a good bike", "Get a Bike" },
                    { new Guid("09e9fa09-f654-498b-94f8-1fd15ca45c0a"), new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"), new DateTime(2022, 5, 1, 12, 54, 21, 728, DateTimeKind.Local).AddTicks(2782), "Travel to 100 countrys", "See the World" },
                    { new Guid("802da3ae-761d-4b0f-b8c4-764619ad53c6"), new Guid("28e423e3-73af-4ca2-978d-188cdcff2a87"), new DateTime(2022, 5, 1, 12, 54, 21, 728, DateTimeKind.Local).AddTicks(2786), "Find a dream country after see the world", "Find a Country" }
                });
        }
    }
}
