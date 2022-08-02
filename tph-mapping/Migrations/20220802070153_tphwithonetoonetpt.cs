using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tph_mapping.Migrations
{
    public partial class tphwithonetoonetpt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserAccounts_UserAccountAccountId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_UserAccountAccountId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "UserAccountAccountId",
                table: "Addresses",
                newName: "AccountRef");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AccountRef",
                table: "Addresses",
                column: "AccountRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_UserAccounts_AccountRef",
                table: "Addresses",
                column: "AccountRef",
                principalTable: "UserAccounts",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_UserAccounts_AccountRef",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_AccountRef",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "AccountRef",
                table: "Addresses",
                newName: "UserAccountAccountId");

            migrationBuilder.AddColumn<Guid>(
                name: "AccountId",
                table: "Addresses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
