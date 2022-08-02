using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tph_mapping.Migrations
{
    public partial class tphtptmerged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Address_AddressId",
                table: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_AddressId",
                table: "UserAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserAccountAccountId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserAccountAccountId",
                table: "Addresses",
                column: "UserAccountAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserAccounts_UserAccountAccountId",
                table: "Addresses",
                column: "UserAccountAccountId",
                principalTable: "UserAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserAccounts_UserAccountAccountId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserAccountAccountId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UserAccountAccountId",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "UserAccounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_AddressId",
                table: "UserAccounts",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccounts_Address_AddressId",
                table: "UserAccounts",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
