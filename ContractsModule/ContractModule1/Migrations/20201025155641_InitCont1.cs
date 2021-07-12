using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContractModule1.Migrations
{
    public partial class InitCont1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicesType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    IsArchived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false),
                    IDCompany = table.Column<int>(nullable: false),
                    NumberContract = table.Column<string>(nullable: false),
                    INN = table.Column<string>(maxLength: 9, nullable: false),
                    KPP = table.Column<string>(nullable: true),
                    BIK = table.Column<string>(maxLength: 9, nullable: false),
                    OGRN = table.Column<string>(maxLength: 13, nullable: false),
                    CheckingAccount = table.Column<string>(maxLength: 20, nullable: false),
                    CorrectiveAccount = table.Column<string>(maxLength: 20, nullable: false),
                    ChiefFirstName = table.Column<string>(nullable: false),
                    ChiefSecondName = table.Column<string>(nullable: false),
                    ChiefThreeName = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Bank = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractCompany_Company_IDCompany",
                        column: x => x.IDCompany,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HashService = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    IDServiceType = table.Column<int>(nullable: false),
                    Color = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    ResearchType = table.Column<bool>(nullable: false),
                    IsComplex = table.Column<bool>(nullable: false),
                    Cabinet = table.Column<string>(nullable: false),
                    IDMKB = table.Column<int>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_ServicesType_IDServiceType",
                        column: x => x.IDServiceType,
                        principalTable: "ServicesType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(nullable: false),
                    Hash = table.Column<string>(nullable: true),
                    IDContract = table.Column<int>(nullable: false),
                    IDService = table.Column<int>(nullable: false),
                    IsArchived = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyServices_ContractCompany_IDContract",
                        column: x => x.IDContract,
                        principalTable: "ContractCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyServices_Services_IDService",
                        column: x => x.IDService,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServices_IDContract",
                table: "CompanyServices",
                column: "IDContract");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServices_IDService",
                table: "CompanyServices",
                column: "IDService");

            migrationBuilder.CreateIndex(
                name: "IX_ContractCompany_IDCompany",
                table: "ContractCompany",
                column: "IDCompany");

            migrationBuilder.CreateIndex(
                name: "IX_Services_IDServiceType",
                table: "Services",
                column: "IDServiceType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyServices");

            migrationBuilder.DropTable(
                name: "ContractCompany");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "ServicesType");
        }
    }
}
