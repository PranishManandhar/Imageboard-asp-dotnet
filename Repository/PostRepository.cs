using ImageBoard.Data;
using ImageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
public class PostRepository : IPostRepository, IDisposable
{
    private readonly ImageBoardContext _context;

    public PostRepository(ImageBoardContext context)
    {
        _context = context;
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
