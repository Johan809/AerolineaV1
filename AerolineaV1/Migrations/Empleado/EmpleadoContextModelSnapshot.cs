﻿// <auto-generated />
using AerolineaV1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AerolineaV1.Migrations.Empleado
{
    [DbContext(typeof(EmpleadoContext))]
    partial class EmpleadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AerolineaV1.Models.Empleado", b =>
                {
                    b.Property<int>("EmpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Puesto")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.HasKey("EmpID");

                    b.ToTable("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}