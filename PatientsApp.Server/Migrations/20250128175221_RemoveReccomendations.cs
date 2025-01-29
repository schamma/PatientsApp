﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatientsApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveReccomendations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reccomendations",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reccomendations",
                table: "Users",
                type: "TEXT",
                nullable: true);
        }
    }
}
