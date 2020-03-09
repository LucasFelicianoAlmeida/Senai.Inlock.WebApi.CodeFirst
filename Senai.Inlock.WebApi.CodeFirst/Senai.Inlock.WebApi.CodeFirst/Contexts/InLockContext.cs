using Microsoft.EntityFrameworkCore;
using Senai.Inlock.WebApi.CodeFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.CodeFirst.Contexts
{
    public class InLockContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuario { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Estudios> Estudios { get; set; }

        public DbSet<Jogos> Jogos { get; set; }
        
        /// <summary>
        /// Define as opções de consruçao do banco de dados
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DEV18\\SQLEXPRESS; Database=Inlock_Games_CodeFirst; user Id=sa; pwd=sa@132");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposUsuario>().HasData(
                new TiposUsuario
                {
                    IdTipoUsuario = 1,
                    Titulo = "Administrador"

                },
                new TiposUsuario
                {
                    IdTipoUsuario = 2,
                    Titulo = "Cliente"

                },
                new Usuarios
                {
                    IdUsuario = 2,
                    Email = "cliente@cliente.com",
                    Senha = "cliente",
                    IdTipoUsuario = 2
                });

            modelBuilder.Entity<Estudios>().HasData(
                new Estudios { IdEstudio = 1, NomeEstudio = "Blizzard" },
                new Estudios { IdEstudio = 2, NomeEstudio = "RockStar Studios" },
                new Estudios { IdEstudio = 3, NomeEstudio = "Square Fenix" }
                });

            modelBuilder.Entity<Jogos>().HasData();

        base.OnModelCreating
        }
    }
}
