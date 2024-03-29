﻿using ComicBookGalleryModel.Migrations;
using ComicBookGalleryModel.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ComicBookGalleryModel.Data
{
    /// <summary>
    /// Entity Framework context class.
    /// </summary>
    public class Context : DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Role> Roles { get; set; }

        public Context()
        {
#if DEBUG
			// Disable the database initializer in favor of using Code First Migrations.
			Database.SetInitializer<Context>(null);
#else
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
#endif
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the pluralizing table name convention 
            // so our table names will use our entity class singular names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Using the fluent API to configure the precision and scale
            // for the ComicBook.AverageRating property.
            modelBuilder.Entity<ComicBookAverageRating>()
                .Property(cb => cb.AverageRating)
                .HasPrecision(5, 2);
        }
    }
}
