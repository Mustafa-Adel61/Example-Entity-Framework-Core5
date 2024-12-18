using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExampleEfCore5.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    years_to_retirement = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phone_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_efficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor_Location",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_Location", x => new { x.DoctorId, x.Location });
                    table.ForeignKey(
                        name: "FK_Doctor_Location_doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicines",
                columns: table => new
                {
                    registration_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remaining_shelf_life = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    Supplier_ID = table.Column<int>(type: "int", nullable: false),
                    frequency = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicines", x => x.registration_Number);
                    table.ForeignKey(
                        name: "FK_medicines_suppliers_Supplier_ID",
                        column: x => x.Supplier_ID,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DoctorMedicine",
                columns: table => new
                {
                    doctorsId = table.Column<int>(type: "int", nullable: false),
                    medicinesregistration_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorMedicine", x => new { x.doctorsId, x.medicinesregistration_Number });
                    table.ForeignKey(
                        name: "FK_DoctorMedicine_doctors_doctorsId",
                        column: x => x.doctorsId,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorMedicine_medicines_medicinesregistration_Number",
                        column: x => x.medicinesregistration_Number,
                        principalTable: "medicines",
                        principalColumn: "registration_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Middle_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perscrtion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Doctor_ID = table.Column<int>(type: "int", nullable: false),
                    registration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_patients_doctors_Doctor_ID",
                        column: x => x.Doctor_ID,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patients_medicines_registration",
                        column: x => x.registration,
                        principalTable: "medicines",
                        principalColumn: "registration_Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    tax_Register = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stored_items = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manager_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_scheduel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    registration_Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.tax_Register);
                    table.ForeignKey(
                        name: "FK_warehouses_medicines_registration_Number",
                        column: x => x.registration_Number,
                        principalTable: "medicines",
                        principalColumn: "registration_Number",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bills",
                columns: table => new
                {
                    Numebr_Of_Bill = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    discount = table.Column<float>(type: "real", nullable: false),
                    Payment_method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bills", x => x.Numebr_Of_Bill);
                    table.ForeignKey(
                        name: "FK_bills_patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient_Phone",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient_Phone", x => new { x.Patient_Id, x.Phone_Number });
                    table.ForeignKey(
                        name: "FK_Patient_Phone_patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax_Register = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_employees_warehouses_tax_Register",
                        column: x => x.tax_Register,
                        principalTable: "warehouses",
                        principalColumn: "tax_Register",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bills_PatientId",
                table: "bills",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoctorMedicine_medicinesregistration_Number",
                table: "DoctorMedicine",
                column: "medicinesregistration_Number");

            migrationBuilder.CreateIndex(
                name: "IX_employees_tax_Register",
                table: "employees",
                column: "tax_Register");

            migrationBuilder.CreateIndex(
                name: "IX_medicines_Supplier_ID",
                table: "medicines",
                column: "Supplier_ID");

            migrationBuilder.CreateIndex(
                name: "IX_patients_Doctor_ID",
                table: "patients",
                column: "Doctor_ID");

            migrationBuilder.CreateIndex(
                name: "IX_patients_registration",
                table: "patients",
                column: "registration");

            migrationBuilder.CreateIndex(
                name: "IX_warehouses_registration_Number",
                table: "warehouses",
                column: "registration_Number",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bills");

            migrationBuilder.DropTable(
                name: "Doctor_Location");

            migrationBuilder.DropTable(
                name: "DoctorMedicine");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "Patient_Phone");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "doctors");

            migrationBuilder.DropTable(
                name: "medicines");

            migrationBuilder.DropTable(
                name: "suppliers");
        }
    }
}
