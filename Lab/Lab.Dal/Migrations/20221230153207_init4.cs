using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Dal.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "011233a2-4a48-4265-9814-499994e92d7a", "AQAAAAEAACcQAAAAENyyuhPuRCUxvQFBStBwnfdmbKgutX6FqJHLGZKBfw2qFvynZo2aXICAW7hwpFfYCQ==", "54a41f71-4291-4f47-8ab9-5d2af2db3569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367011a0-3e77-4988-b540-0e26665eaf0e", "AQAAAAEAACcQAAAAEI1DbjkMtLC6B6vfWMptidNBo9szcJEqZUYqRfKkbrJl9qVE78PB8tBNM3TZD+8GxA==", "fc484c24-7267-4f4e-a1fa-59f649ab383b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6bb36de-1071-400f-896f-554494419c28", null, "6875a0b8-c682-4d6c-8944-3bcc65b7fb03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "121adae1-c6c4-49f2-a1ae-79983fe87735", null, "0564b55f-2f56-444a-81dc-a46fc4c52bd4" });
        }
    }
}
