﻿using Microsoft.EntityFrameworkCore;
using ProjetoTesteEmMVC.Models;

namespace ProjetoTesteEmMVC.Data
{
    public class BancoContext : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public BancoContext(DbContextOptions<BancoContext>options) : base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
        }

        public DbSet<PersonagensModel> Personagens { get; set; }
    }
}
