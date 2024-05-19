﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaGeral.Models;

namespace SistemaGeral.Data
{
    public class SistemaGeralContext : DbContext
    {
        public SistemaGeralContext (DbContextOptions<SistemaGeralContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaGeral.Models.Funcionario> Funcionario { get; set; } = default!;
    }
}
