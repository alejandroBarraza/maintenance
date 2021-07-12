using Microsoft.EntityFrameworkCore.Migrations;

namespace mantencion.Migrations
{
    public partial class fixdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeUsaEns");

            migrationBuilder.DropTable(
                name: "Trabaja_ens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "Matarials");

            migrationBuilder.AddColumn<string>(
                name: "apellido",
                table: "Mecanicos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "Matarials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matarials",
                table: "Matarials",
                column: "id");

            migrationBuilder.CreateTable(
                name: "MantencionMaterials",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_mantencion = table.Column<int>(type: "int", nullable: false),
                    mantencionid = table.Column<int>(type: "int", nullable: true),
                    id_material = table.Column<int>(type: "int", nullable: false),
                    materialid = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantencionMaterials", x => x.id);
                    table.ForeignKey(
                        name: "FK_MantencionMaterials_Mantencions_mantencionid",
                        column: x => x.mantencionid,
                        principalTable: "Mantencions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MantencionMaterials_Matarials_materialid",
                        column: x => x.materialid,
                        principalTable: "Matarials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MantencionMecanicos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_mantencion = table.Column<int>(type: "int", nullable: false),
                    mantencionid = table.Column<int>(type: "int", nullable: true),
                    id_mecanico = table.Column<int>(type: "int", nullable: false),
                    mecanicoid = table.Column<int>(type: "int", nullable: true),
                    horas = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MantencionMecanicos", x => x.id);
                    table.ForeignKey(
                        name: "FK_MantencionMecanicos_Mantencions_mantencionid",
                        column: x => x.mantencionid,
                        principalTable: "Mantencions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MantencionMecanicos_Mecanicos_mecanicoid",
                        column: x => x.mecanicoid,
                        principalTable: "Mecanicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MantencionMaterials_mantencionid",
                table: "MantencionMaterials",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_MantencionMaterials_materialid",
                table: "MantencionMaterials",
                column: "materialid");

            migrationBuilder.CreateIndex(
                name: "IX_MantencionMecanicos_mantencionid",
                table: "MantencionMecanicos",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_MantencionMecanicos_mecanicoid",
                table: "MantencionMecanicos",
                column: "mecanicoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MantencionMaterials");

            migrationBuilder.DropTable(
                name: "MantencionMecanicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matarials",
                table: "Matarials");

            migrationBuilder.DropColumn(
                name: "apellido",
                table: "Mecanicos");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "Matarials");

            migrationBuilder.RenameTable(
                name: "Matarials",
                newName: "Materials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "id");

            migrationBuilder.CreateTable(
                name: "SeUsaEns",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    id_mantencion = table.Column<int>(type: "int", nullable: false),
                    id_material = table.Column<int>(type: "int", nullable: false),
                    mantencionid = table.Column<int>(type: "int", nullable: true),
                    materialid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeUsaEns", x => x.id);
                    table.ForeignKey(
                        name: "FK_SeUsaEns_Mantencions_mantencionid",
                        column: x => x.mantencionid,
                        principalTable: "Mantencions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SeUsaEns_Materials_materialid",
                        column: x => x.materialid,
                        principalTable: "Materials",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trabaja_ens",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horas = table.Column<float>(type: "real", nullable: false),
                    id_mantencion = table.Column<int>(type: "int", nullable: false),
                    id_mecanico = table.Column<int>(type: "int", nullable: false),
                    mantencionid = table.Column<int>(type: "int", nullable: true),
                    mecanicoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trabaja_ens", x => x.id);
                    table.ForeignKey(
                        name: "FK_Trabaja_ens_Mantencions_mantencionid",
                        column: x => x.mantencionid,
                        principalTable: "Mantencions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trabaja_ens_Mecanicos_mecanicoid",
                        column: x => x.mecanicoid,
                        principalTable: "Mecanicos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeUsaEns_mantencionid",
                table: "SeUsaEns",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_SeUsaEns_materialid",
                table: "SeUsaEns",
                column: "materialid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabaja_ens_mantencionid",
                table: "Trabaja_ens",
                column: "mantencionid");

            migrationBuilder.CreateIndex(
                name: "IX_Trabaja_ens_mecanicoid",
                table: "Trabaja_ens",
                column: "mecanicoid");
        }
    }
}
