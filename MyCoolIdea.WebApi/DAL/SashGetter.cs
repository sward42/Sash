using MyCoolIdea.WebApi.Controllers;
using MyCoolIdea.WebApi.Models;

namespace MyCoolIdea.WebApi.DAL
{
    public class SashGetter : ISashGetter
    {
        public Sash GetById(int id)
        {
            if (id == 0) return null;

            return new Sash
            {
                Cost = 12,
                Name = "Divorce Sash",
                QuantityRemaining = 1
            };
        }
    }
}