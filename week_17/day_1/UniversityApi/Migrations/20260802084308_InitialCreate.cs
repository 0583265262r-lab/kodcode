using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
    protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "Students",
            columns: table => new
            {
            Id = table.Column<int>(nullable: false)
            .Annotation("MySql:ValueGenerationStrategy",
            MySqlValueGenerationStrategy.IdentityColumn),
            FullName = table.Column<string>(maxLength: 100, nullable:
            false),
            Email = table.Column<string>(maxLength: 100, nullable:
            false),
            // ...
            });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Students");
        }
    }
}
