﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webApi.healthClinic.Contexts;

#nullable disable

namespace webApi.healthClinic.Migrations
{
    [DbContext(typeof(healthClinicContext))]
    [Migration("20230927202334_database")]
    partial class database
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webApi.healthClinic.Domains.Clinica", b =>
                {
                    b.Property<Guid>("IdClinica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("CHAR(14)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("HorarioFuncionamento")
                        .HasColumnType("DATE");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdClinica");

                    b.ToTable("Clinica");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Consulta", b =>
                {
                    b.Property<Guid>("IdConsulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("DATE");

                    b.Property<Guid>("IdMedico")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPaciente")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdConsulta");

                    b.HasIndex("IdMedico");

                    b.HasIndex("IdPaciente");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.FeedBack", b =>
                {
                    b.Property<Guid>("IdFeedBack")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<bool>("Exibe")
                        .HasColumnType("BIT");

                    b.Property<Guid>("IdConsulta")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdFeedBack");

                    b.HasIndex("IdConsulta");

                    b.ToTable("FeedBack");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Medico", b =>
                {
                    b.Property<Guid>("IdMedico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("CHAR(8)");

                    b.Property<string>("Especialização")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<Guid>("IdClinica")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeMedico")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("IdMedico");

                    b.HasIndex("IdClinica");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Medico");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Paciente", b =>
                {
                    b.Property<Guid>("IdPaciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)");

                    b.Property<Guid>("IdUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Idade")
                        .HasColumnType("INT");

                    b.Property<string>("NomePaciente")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdPaciente");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.TipoUsuario", b =>
                {
                    b.Property<Guid>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeTipoUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TipoUsuario");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Usuario", b =>
                {
                    b.Property<Guid>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("IdTipoUsuario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("CHAR(60)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdTipoUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Consulta", b =>
                {
                    b.HasOne("webApi.healthClinic.Domains.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("IdMedico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webApi.healthClinic.Domains.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("IdPaciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.FeedBack", b =>
                {
                    b.HasOne("webApi.healthClinic.Domains.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("IdConsulta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Medico", b =>
                {
                    b.HasOne("webApi.healthClinic.Domains.Clinica", "Clinica")
                        .WithMany()
                        .HasForeignKey("IdClinica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webApi.healthClinic.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinica");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Paciente", b =>
                {
                    b.HasOne("webApi.healthClinic.Domains.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("webApi.healthClinic.Domains.Usuario", b =>
                {
                    b.HasOne("webApi.healthClinic.Domains.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("IdTipoUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}