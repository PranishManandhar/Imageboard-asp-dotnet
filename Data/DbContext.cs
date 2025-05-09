using Microsoft.EntityFrameworkCore;
using ImageBoard.Models;

namespace ImageBoard.Data
{
    public class ImageBoardContext :DbContext
    {
        // allows .net to inject connectionString via program.cs
        public ImageBoardContext(DbContextOptions<ImageBoardContext> options) : base(options)
        {
        }
        // DbSets represent tables in the database, each tied to a model
        public  DbSet<PostModel> Posts { get; set; } = null!;
        public  DbSet<ReplyModel> Replies { get; set; } = null!;

        // RelationSh9ip Builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostModel>()
                .HasMany(p => p.Replies)
                .WithOne(p=>p.Post)
                .HasForeignKey(p=>p.PostId);
        }
    }
}