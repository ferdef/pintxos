﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Pintxos.Models;

namespace Pintxos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContestModel> Contests { get; set; }
        public DbSet<FamilyModel> Families { get; set; }
        public DbSet<PintxoModel> Pintxos { get; set; }
        public DbSet<PintxoVoteModel> PintxoVotes { get; set; }
    }
}
