using ExpressoAPI.Data;
using System.Linq;
using System.Web.Http;

namespace ExpressoAPI.Controllers
{
    public class MenuController : ApiController
    {
        ExpressoDbContext expressoDbContext = new ExpressoDbContext();

        public IHttpActionResult GetMenu()
        {
            var menus = expressoDbContext.Menus.Include("SubMenus");
            return Ok(menus);
        }

        public IHttpActionResult GetMenu(int id)
        {
            var menus = expressoDbContext.Menus.Include("SubMenus").FirstOrDefault(m => m.Id == id);
            if(menus==null)
            {
                return NotFound();
            }
            return Ok(menus);
        }
    }
}

//Eager loading is achieved using the Include method