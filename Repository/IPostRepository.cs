using ImageBoard.Models;

public interface IPostRepository
{
    Task <IEnumerable<PostModel>> GetPostsAsync();
    Task<bool> create(PostModel post);
    Task<bool> update(PostModel post);
    Task<bool> delete(int id);
}