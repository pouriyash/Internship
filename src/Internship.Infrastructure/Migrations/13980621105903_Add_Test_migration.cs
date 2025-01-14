﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship.Infrastructure.Migrations
{
    public partial class Add_Test_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoutineStep = table.Column<int>(nullable: false),
                    RoutineIsFlown = table.Column<bool>(nullable: false),
                    RoutineIsDone = table.Column<bool>(nullable: false),
                    RoutineFlownDate = table.Column<DateTime>(nullable: true),
                    RoutineStepChangeDate = table.Column<DateTime>(nullable: true),
                    RoutineIsSucceeded = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
