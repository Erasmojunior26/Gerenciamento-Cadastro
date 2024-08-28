using Formulario.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Formulario.Context
{
    public class FormularioContext : DbContext
    {
        public FormularioContext(DbContextOptions<FormularioContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
