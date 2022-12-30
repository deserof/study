using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab.Dal.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a682e38-2ba9-4d5c-a0bb-cc43be1d23ac", "employee@gmail.com", "employee@gmail.com", "AQAAAAEAACcQAAAAEFWULtzvKaM4XyjYPdQ+aUjafIo7eAVVhk2LXpm7R7C+HSVYnd+U+DoV25/ik82HUA==", "b3298dcb-c813-4442-8a7a-f11637ddef2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "397396d2-3e62-4595-9453-f88cf7b7e609", "client@gmail.com", "client@gmail.com", "AQAAAAEAACcQAAAAEMuSdgKJ+G4eM/UslTQceqjRoVKnM3jBT6P6/qTUqRkxkT6UDKhbWyrb/K6vimsGkQ==", "b95ae87d-9a5a-4b7d-99cd-0015da56fb4c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a35ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "011233a2-4a48-4265-9814-499994e92d7a", null, null, "AQAAAAEAACcQAAAAENyyuhPuRCUxvQFBStBwnfdmbKgutX6FqJHLGZKBfw2qFvynZo2aXICAW7hwpFfYCQ==", "54a41f71-4291-4f47-8ab9-5d2af2db3569" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "367011a0-3e77-4988-b540-0e26665eaf0e", null, null, "AQAAAAEAACcQAAAAEI1DbjkMtLC6B6vfWMptidNBo9szcJEqZUYqRfKkbrJl9qVE78PB8tBNM3TZD+8GxA==", "fc484c24-7267-4f4e-a1fa-59f649ab383b" });
        }
    }
}
