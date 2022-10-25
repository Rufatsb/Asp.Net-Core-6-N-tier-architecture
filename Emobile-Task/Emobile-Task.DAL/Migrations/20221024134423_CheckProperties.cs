using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Emobile_Task.DAL.Migrations
{
    public partial class CheckProperties : Migration
    {
       
          protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Isdeleted",
                table: "Countries",
                type: "bit",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<bool>(
             name: "Isdeleted",
                table: "Cities",
                type: "bit",
                nullable: false,
                defaultValue: false);
            migrationBuilder.AddColumn<bool>(
                name: "Isdeleted",
                table: "Travel",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    

        
    }
}
