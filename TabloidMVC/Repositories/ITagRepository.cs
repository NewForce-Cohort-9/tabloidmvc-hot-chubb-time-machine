using TabloidMVC.Models;

namespace TabloidCLI
{
    public interface ITagRepository
    {
        Tag Get(int id);
        List<Tag> GetAll();
    }
}