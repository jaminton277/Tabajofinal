using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroMat2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "escuela",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escuela", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "estudiante",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    edad = table.Column<double>(nullable: false),
                    correo = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    grado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estudiante", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "maestro",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    apellidos = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    correo = table.Column<string>(nullable: true),
                    telefono = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maestro", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "seccion",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ubicacion = table.Column<string>(nullable: true),
                    EscuelaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seccion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_seccion_escuela_EscuelaID",
                        column: x => x.EscuelaID,
                        principalTable: "escuela",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "registro",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecharegistro = table.Column<DateTime>(nullable: false),
                    estudianteID = table.Column<int>(nullable: false),
                    maestroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_registro_estudiante_estudianteID",
                        column: x => x.estudianteID,
                        principalTable: "estudiante",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_registro_maestro_maestroID",
                        column: x => x.maestroID,
                        principalTable: "maestro",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_registro_estudianteID",
                table: "registro",
                column: "estudianteID");

            migrationBuilder.CreateIndex(
                name: "IX_registro_maestroID",
                table: "registro",
                column: "maestroID");

            migrationBuilder.CreateIndex(
                name: "IX_seccion_EscuelaID",
                table: "seccion",
                column: "EscuelaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registro");

            migrationBuilder.DropTable(
                name: "seccion");

            migrationBuilder.DropTable(
                name: "estudiante");

            migrationBuilder.DropTable(
                name: "maestro");

            migrationBuilder.DropTable(
                name: "escuela");
        }
    }
}
