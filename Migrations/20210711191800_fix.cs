using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mantencion.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "Trabaja_ens");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Trabaja_ens");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "SeUsaEns");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "SeUsaEns");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "id_trabajaen",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "id_SeUsaEn",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "id_seUsaEn",
                table: "Mantencions");

            migrationBuilder.DropColumn(
                name: "id_trabajaEn",
                table: "Mantencions");

            migrationBuilder.RenameColumn(
                name: "id_trabajador",
                table: "Trabaja_ens",
                newName: "id_mecanico");

            migrationBuilder.AddColumn<int>(
                name: "mantencionid",
                table: "Trabaja_ens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mecanicoid",
                table: "Trabaja_ens",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mantencionid",
                table: "SeUsaEns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "materialid",
                table: "SeUsaEns",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Mecanicos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "rut",
                table: "Mecanicos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombreMaterial",
                table: "Materials",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trabaja_ens_mantencionid",
                table: "Trabaja_ens",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabaja_ens_mecanicoid",
                table: "Trabaja_ens",
                column: "mecanicoid");

            migrationBuilder.CreateIndex(
                name: "IX_SeUsaEns_mantencionid",
                table: "SeUsaEns",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_SeUsaEns_materialid",
                table: "SeUsaEns",
                column: "materialid");

            migrationBuilder.AddForeignKey(
                name: "FK_SeUsaEns_Mantencions_mantencionid",
                table: "SeUsaEns",
                column: "mantencionid",
                principalTable: "Mantencions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeUsaEns_Materials_materialid",
                table: "SeUsaEns",
                column: "materialid",
                principalTable: "Materials",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabaja_ens_Mantencions_mantencionid",
                table: "Trabaja_ens",
                column: "mantencionid",
                principalTable: "Mantencions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trabaja_ens_Mecanicos_mecanicoid",
                table: "Trabaja_ens",
                column: "mecanicoid",
                principalTable: "Mecanicos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeUsaEns_Mantencions_mantencionid",
                table: "SeUsaEns");

            migrationBuilder.DropForeignKey(
                name: "FK_SeUsaEns_Materials_materialid",
                table: "SeUsaEns");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabaja_ens_Mantencions_mantencionid",
                table: "Trabaja_ens");

            migrationBuilder.DropForeignKey(
                name: "FK_Trabaja_ens_Mecanicos_mecanicoid",
                table: "Trabaja_ens");

            migrationBuilder.DropIndex(
                name: "IX_Trabaja_ens_mantencionid",
                table: "Trabaja_ens");

            migrationBuilder.DropIndex(
                name: "IX_Trabaja_ens_mecanicoid",
                table: "Trabaja_ens");

            migrationBuilder.DropIndex(
                name: "IX_SeUsaEns_mantencionid",
                table: "SeUsaEns");

            migrationBuilder.DropIndex(
                name: "IX_SeUsaEns_materialid",
                table: "SeUsaEns");

            migrationBuilder.DropColumn(
                name: "mantencionid",
                table: "Trabaja_ens");

            migrationBuilder.DropColumn(
                name: "mecanicoid",
                table: "Trabaja_ens");

            migrationBuilder.DropColumn(
                name: "mantencionid",
                table: "SeUsaEns");

            migrationBuilder.DropColumn(
                name: "materialid",
                table: "SeUsaEns");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "rut",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "nombreMaterial",
                table: "Materials");

            migrationBuilder.RenameColumn(
                name: "id_mecanico",
                table: "Trabaja_ens",
                newName: "id_trabajador");

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "Trabaja_ens",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Trabaja_ens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "SeUsaEns",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "SeUsaEns",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "estado",
                table: "Mecanicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Mecanicos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "id_trabajaen",
                table: "Mecanicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "estado",
                table: "Materials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "id_SeUsaEn",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_seUsaEn",
                table: "Mantencions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_trabajaEn",
                table: "Mantencions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
