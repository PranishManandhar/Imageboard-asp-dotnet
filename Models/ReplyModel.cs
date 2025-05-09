using System;
using System.Collections.Generic;

namespace ImageBoard.Models
{
    public class ReplyModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? ImageURL { get; set; }


        public PostModel? Post { get; set; }
    }
}