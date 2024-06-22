using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestion_Funeraria__LP2_.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atributo",
                columns: table => new
                {
                    ID_Atributo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Estatus = table.Column<bool>(type: "bit", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Atributo__5ECA4A186BBE52E3", x => x.ID_Atributo);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    ID_Cargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cargo__8D69B95FB68199D1", x => x.ID_Cargo);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    ID_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Total_Cobertura = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__02AA0785B34B9C91", x => x.ID_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    ID_Localidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    ID_Contacto1 = table.Column<int>(type: "int", nullable: true),
                    ID_Contacto2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Localida__8ACE3DA1F196609E", x => x.ID_Localidad);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    ID_Servicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__1932F584415698B8", x => x.ID_Servicio);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Identificacion",
                columns: table => new
                {
                    ID_Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tipo_Ide__2D8D9EE1D17D799B", x => x.ID_Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Atributo_Categorias",
                columns: table => new
                {
                    ID_Atributo = table.Column<int>(type: "int", nullable: false),
                    ID_Categoria = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Atributo__1EE0EA6043280821", x => new { x.ID_Atributo, x.ID_Categoria });
                    table.ForeignKey(
                        name: "FK__Atributo___ID_At__2E1BDC42",
                        column: x => x.ID_Atributo,
                        principalTable: "Atributo",
                        principalColumn: "ID_Atributo");
                    table.ForeignKey(
                        name: "FK__Atributo___ID_Ca__2F10007B",
                        column: x => x.ID_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "ID_Categoria");
                });

            migrationBuilder.CreateTable(
                name: "Jornada_Laboral",
                columns: table => new
                {
                    ID_Jornada_Laboral = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Localidad = table.Column<int>(type: "int", nullable: true),
                    Fecha_Entrada = table.Column<DateOnly>(type: "date", nullable: false),
                    Fecha_Salida = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Jornada___4D9539810E0370F1", x => x.ID_Jornada_Laboral);
                    table.ForeignKey(
                        name: "FK__Jornada_L__ID_Lo__440B1D61",
                        column: x => x.ID_Localidad,
                        principalTable: "Localidad",
                        principalColumn: "ID_Localidad");
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    ID_Sala = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Localidad = table.Column<int>(type: "int", nullable: true),
                    ID_Categoria = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Estatus = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Salas__2071DEA7B374F345", x => x.ID_Sala);
                    table.ForeignKey(
                        name: "FK__Salas__ID_Catego__29572725",
                        column: x => x.ID_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "ID_Categoria");
                    table.ForeignKey(
                        name: "FK__Salas__ID_Locali__286302EC",
                        column: x => x.ID_Localidad,
                        principalTable: "Localidad",
                        principalColumn: "ID_Localidad");
                });

            migrationBuilder.CreateTable(
                name: "Servicios_Categorias",
                columns: table => new
                {
                    ID_Servicio = table.Column<int>(type: "int", nullable: false),
                    ID_Categoria = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Servicio__591855FC0A40FA83", x => new { x.ID_Servicio, x.ID_Categoria });
                    table.ForeignKey(
                        name: "FK__Servicios__ID_Ca__34C8D9D1",
                        column: x => x.ID_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "ID_Categoria");
                    table.ForeignKey(
                        name: "FK__Servicios__ID_Se__33D4B598",
                        column: x => x.ID_Servicio,
                        principalTable: "Servicios",
                        principalColumn: "ID_Servicio");
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Identificacion = table.Column<int>(type: "int", nullable: true),
                    ID_Jornada_Laboral = table.Column<int>(type: "int", nullable: true),
                    ID_Cargo = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NumDocumento = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Empleado__B7872C90AFF4E8ED", x => x.ID_Empleado);
                    table.ForeignKey(
                        name: "FK__Empleados__ID_Ca__403A8C7D",
                        column: x => x.ID_Cargo,
                        principalTable: "Cargo",
                        principalColumn: "ID_Cargo");
                    table.ForeignKey(
                        name: "FK__Empleados__ID_Id__3F466844",
                        column: x => x.ID_Identificacion,
                        principalTable: "Tipo_Identificacion",
                        principalColumn: "ID_Identificacion");
                });

            migrationBuilder.CreateTable(
                name: "Defunciones",
                columns: table => new
                {
                    ID_Defuncion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Sala = table.Column<int>(type: "int", nullable: true),
                    ID_Identificacion = table.Column<int>(type: "int", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Representante = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Representante_Telefono = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Representante_Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Nombre_Difunto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fecha_Nacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Fecha_Fallecimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    Horario_Entrada = table.Column<TimeOnly>(type: "time", nullable: false),
                    Horario_Salida = table.Column<TimeOnly>(type: "time", nullable: false),
                    Certificacion_Defuncion = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Defuncio__E05EBEA85A1B991F", x => x.ID_Defuncion);
                    table.ForeignKey(
                        name: "FK__Defuncion__ID_Id__3A81B327",
                        column: x => x.ID_Identificacion,
                        principalTable: "Tipo_Identificacion",
                        principalColumn: "ID_Identificacion");
                    table.ForeignKey(
                        name: "FK__Defuncion__ID_Sa__398D8EEE",
                        column: x => x.ID_Sala,
                        principalTable: "Salas",
                        principalColumn: "ID_Sala");
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones_Atributo",
                columns: table => new
                {
                    ID_Atributo = table.Column<int>(type: "int", nullable: false),
                    ID_Defuncion = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Facturac__C0CFA1F2AB574138", x => new { x.ID_Atributo, x.ID_Defuncion });
                    table.ForeignKey(
                        name: "FK__Facturaci__ID_At__49C3F6B7",
                        column: x => x.ID_Atributo,
                        principalTable: "Atributo",
                        principalColumn: "ID_Atributo");
                    table.ForeignKey(
                        name: "FK__Facturaci__ID_De__4AB81AF0",
                        column: x => x.ID_Defuncion,
                        principalTable: "Defunciones",
                        principalColumn: "ID_Defuncion");
                });

            migrationBuilder.CreateTable(
                name: "Facturaciones_Servicios",
                columns: table => new
                {
                    ID_Servicio = table.Column<int>(type: "int", nullable: false),
                    ID_Defuncion = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Facturac__87371E6E5CF4A5BB", x => new { x.ID_Servicio, x.ID_Defuncion });
                    table.ForeignKey(
                        name: "FK__Facturaci__ID_De__4E88ABD4",
                        column: x => x.ID_Defuncion,
                        principalTable: "Defunciones",
                        principalColumn: "ID_Defuncion");
                    table.ForeignKey(
                        name: "FK__Facturaci__ID_Se__4D94879B",
                        column: x => x.ID_Servicio,
                        principalTable: "Servicios",
                        principalColumn: "ID_Servicio");
                });

            migrationBuilder.CreateTable(
                name: "Libro_Firma",
                columns: table => new
                {
                    ID_Libro_Firma = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Defuncion = table.Column<int>(type: "int", nullable: true),
                    Nombre_Firma = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mensaje = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Libro_Fi__4A04D334864E53AC", x => x.ID_Libro_Firma);
                    table.ForeignKey(
                        name: "FK__Libro_Fir__ID_De__46E78A0C",
                        column: x => x.ID_Defuncion,
                        principalTable: "Defunciones",
                        principalColumn: "ID_Defuncion");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atributo_Categorias_ID_Categoria",
                table: "Atributo_Categorias",
                column: "ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Defunciones_ID_Identificacion",
                table: "Defunciones",
                column: "ID_Identificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Defunciones_ID_Sala",
                table: "Defunciones",
                column: "ID_Sala");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ID_Cargo",
                table: "Empleados",
                column: "ID_Cargo");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_ID_Identificacion",
                table: "Empleados",
                column: "ID_Identificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_Atributo_ID_Defuncion",
                table: "Facturaciones_Atributo",
                column: "ID_Defuncion");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_Servicios_ID_Defuncion",
                table: "Facturaciones_Servicios",
                column: "ID_Defuncion");

            migrationBuilder.CreateIndex(
                name: "IX_Jornada_Laboral_ID_Localidad",
                table: "Jornada_Laboral",
                column: "ID_Localidad");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_Firma_ID_Defuncion",
                table: "Libro_Firma",
                column: "ID_Defuncion");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_ID_Categoria",
                table: "Salas",
                column: "ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Salas_ID_Localidad",
                table: "Salas",
                column: "ID_Localidad");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_Categorias_ID_Categoria",
                table: "Servicios_Categorias",
                column: "ID_Categoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atributo_Categorias");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Facturaciones_Atributo");

            migrationBuilder.DropTable(
                name: "Facturaciones_Servicios");

            migrationBuilder.DropTable(
                name: "Jornada_Laboral");

            migrationBuilder.DropTable(
                name: "Libro_Firma");

            migrationBuilder.DropTable(
                name: "Servicios_Categorias");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Atributo");

            migrationBuilder.DropTable(
                name: "Defunciones");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Tipo_Identificacion");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Localidad");
        }
    }
}
