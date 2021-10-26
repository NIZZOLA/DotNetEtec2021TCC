using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Tcc2021.Models
{
    public class Tcc2021Context : DbContext
    {
        public Tcc2021Context (DbContextOptions<Tcc2021Context> options)
            : base(options)
        {
        }

        public DbSet<Tcc2021.Models.UsuarioModel> UsuarioModel { get; set; }
    }
}
