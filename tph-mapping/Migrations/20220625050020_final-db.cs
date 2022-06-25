using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tph_mapping.Migrations
{
    public partial class finaldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_UserAccounts_AccountId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_AccountId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "UserAccounts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccounts_Address_AddressId",
                table: "UserAccounts");

            migrationBuilder.DropIndex(
                name: "IX_UserAccounts_AddressId",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "UserAccounts");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Address_AccountId",
                table: "Address",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_UserAccounts_AccountId",
                table: "Address",
                column: "AccountId",
                principalTable: "UserAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
