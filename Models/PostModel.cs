using System;
using System.Collections.Generic;

namespace ImageBoard.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; }  = DateTime.UtcNow;
        public string? ImageURL { get; set; }
    

        public List<ReplyModel> Replies { get; set; } = new();
    }
}
// This code defines a PostModel class that represents a post in an image board application.