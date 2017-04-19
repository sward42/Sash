using MyCoolIdea.WebApi.Models;

namespace MyCoolIdea.WebApi.Controllers
{
    public interface ISashGetter
    {
        Sash GetById(int id);
    }
}