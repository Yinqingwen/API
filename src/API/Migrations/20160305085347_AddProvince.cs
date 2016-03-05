using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace API.Migrations
{
    public partial class AddProvince : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    InUse = table.Column<bool>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    ProvinceCode = table.Column<string>(nullable: false),
                    ProvinceName = table.Column<string>(nullable: false),
                    ReMake1 = table.Column<string>(nullable: true),
                    ReMake2 = table.Column<string>(nullable: true),
                    ReMake3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Province");
        }
    }
}
