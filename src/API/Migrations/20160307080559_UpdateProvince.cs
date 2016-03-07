using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace API.Migrations
{
    public partial class UpdateProvince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProvinceCode",
                table: "City",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "ProvinceCode", table: "City");
        }
    }
}
