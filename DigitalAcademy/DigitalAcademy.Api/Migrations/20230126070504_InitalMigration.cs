using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalAcademy.Api.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City_Tbls",
                columns: table => new
                {
                    city_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City_Tbls", x => x.city_id);
                });

            migrationBuilder.CreateTable(
                name: "Country_Tbls",
                columns: table => new
                {
                    country_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country_Tbls", x => x.country_id);
                });

            migrationBuilder.CreateTable(
                name: "Course_Tbls",
                columns: table => new
                {
                    courseid = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coursename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    courseduration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_Tbls", x => x.courseid);
                });

            migrationBuilder.CreateTable(
                name: "State_Tbls",
                columns: table => new
                {
                    state_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    country_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State_Tbls", x => x.state_id);
                });

            migrationBuilder.CreateTable(
                name: "Student_Tbls",
                columns: table => new
                {
                    student_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    student_fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_mname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    student_lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<int>(type: "int", nullable: false),
                    country_id = table.Column<long>(type: "bigint", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_id = table.Column<long>(type: "bigint", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city_id = table.Column<long>(type: "bigint", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isactive = table.Column<bool>(type: "bit", nullable: false),
                    isfranchiesestudent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student_Tbls", x => x.student_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City_Tbls");

            migrationBuilder.DropTable(
                name: "Country_Tbls");

            migrationBuilder.DropTable(
                name: "Course_Tbls");

            migrationBuilder.DropTable(
                name: "State_Tbls");

            migrationBuilder.DropTable(
                name: "Student_Tbls");
        }
    }
}
