using System;
using Microsoft.EntityFrameworkCore;
using RegistroBonyAuto.Models;

namespace RegistroBonyAuto.Dal

{
    public class Contexto : DbContext
    {
        public DbSet<Prioridad> Prioridades {get; set;}

        public Contexto(DbContextOptions<Contexto>options): base(options){}

        
    }
}