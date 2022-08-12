using Microsoft.EntityFrameworkCore.Migrations;

namespace Automoviles.DataAccess.Migrations
{
    public partial class ver2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Colores_ColorId1",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Combustibles_CombustibleId1",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Paises_PaisId1",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Seguros_SeguroId1",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Tipos_TipoId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ColorId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_CombustibleId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PaisId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_SeguroId1",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TipoId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "ColorId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "CombustibleId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "PaisId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "SeguroId1",
                table: "Vehiculos");

            migrationBuilder.DropColumn(
                name: "TipoId1",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<int>(
                name: "TipoId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SeguroId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrecioId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "PaisId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Modelo",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "CombustibleId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ColorId",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Transmisiones",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Tipos",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Seguros",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Paises",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Marcas",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Combustibles",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Colores",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.CreateTable(
                name: "Modelos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelos", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ColorId",
                table: "Vehiculos",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_CombustibleId",
                table: "Vehiculos",
                column: "CombustibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_Modelo",
                table: "Vehiculos",
                column: "Modelo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PaisId",
                table: "Vehiculos",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_SeguroId",
                table: "Vehiculos",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoId",
                table: "Vehiculos",
                column: "TipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Colores_ColorId",
                table: "Vehiculos",
                column: "ColorId",
                principalTable: "Colores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Combustibles_CombustibleId",
                table: "Vehiculos",
                column: "CombustibleId",
                principalTable: "Combustibles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Modelos_Modelo",
                table: "Vehiculos",
                column: "Modelo",
                principalTable: "Modelos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Paises_PaisId",
                table: "Vehiculos",
                column: "PaisId",
                principalTable: "Paises",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Seguros_SeguroId",
                table: "Vehiculos",
                column: "SeguroId",
                principalTable: "Seguros",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Tipos_TipoId",
                table: "Vehiculos",
                column: "TipoId",
                principalTable: "Tipos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Colores_ColorId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Combustibles_CombustibleId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Modelos_Modelo",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Paises_PaisId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Seguros_SeguroId",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Tipos_TipoId",
                table: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Modelos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_ColorId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_CombustibleId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_Modelo",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PaisId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_SeguroId",
                table: "Vehiculos");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_TipoId",
                table: "Vehiculos");

            migrationBuilder.AlterColumn<string>(
                name: "TipoId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SeguroId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PrecioId",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PaisId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "Vehiculos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CombustibleId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ColorId",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ColorId1",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CombustibleId1",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaisId1",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeguroId1",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoId1",
                table: "Vehiculos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Transmisiones",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Tipos",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Seguros",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Paises",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Marcas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Combustibles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Colores",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_ColorId1",
                table: "Vehiculos",
                column: "ColorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_CombustibleId1",
                table: "Vehiculos",
                column: "CombustibleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PaisId1",
                table: "Vehiculos",
                column: "PaisId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_SeguroId1",
                table: "Vehiculos",
                column: "SeguroId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoId1",
                table: "Vehiculos",
                column: "TipoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Colores_ColorId1",
                table: "Vehiculos",
                column: "ColorId1",
                principalTable: "Colores",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Combustibles_CombustibleId1",
                table: "Vehiculos",
                column: "CombustibleId1",
                principalTable: "Combustibles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Paises_PaisId1",
                table: "Vehiculos",
                column: "PaisId1",
                principalTable: "Paises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Seguros_SeguroId1",
                table: "Vehiculos",
                column: "SeguroId1",
                principalTable: "Seguros",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Tipos_TipoId1",
                table: "Vehiculos",
                column: "TipoId1",
                principalTable: "Tipos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
