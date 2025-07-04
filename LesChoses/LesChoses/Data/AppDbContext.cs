﻿using Microsoft.EntityFrameworkCore;
using LesChoses.Models;

namespace LesChoses.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Phrase> Phrases { get; set; }
    }
}
