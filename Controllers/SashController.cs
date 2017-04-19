using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyCoolIdea.WebApi.DAL;

namespace MyCoolIdea.WebApi.Controllers
{
    public class SashController : ApiController
    {
        readonly ISashGetter _getter;

        public SashController()
        {
            _getter = new SashGetter();
        }

        public SashController(ISashGetter getter)
        {
            _getter = getter;
        }

        [HttpGet]
        [Route("api/sash/{id}")]
        public HttpResponseMessage CrazyTime(int id)
        {
            var sash = _getter.GetById(id);

            if (sash == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"The Sash with an id of {id} does not exist");
            }

            return Request.CreateResponse(HttpStatusCode.OK, sash);
        }
    }
}
