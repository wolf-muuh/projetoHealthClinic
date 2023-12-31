﻿using Microsoft.EntityFrameworkCore;
using webApi.healthClinic.Domains;

namespace webApi.healthClinic.Contexts
{ 
    public class healthClinicContext : DbContext
    {
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<FeedBack> FeedBack { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE17-S15; Database = healthClinic.api; User Id= sa; Pwd = Senai@134; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
