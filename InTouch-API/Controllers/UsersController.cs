using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InTouch_API.Controllers
{
    [RoutePrefix("api/Users")]
    public class UsersController : ApiController
    {
        [Route("GetUsers")]
        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            using (var Db = new InTouch_DBEntities())
            {
                return Db.Users.ToList();
            }
        }

        public async Task AddUser(Users user)
        {
            using (var Db = new InTouch_DBEntities())
            {
                Db.Users.Add(user);
                await Db.SaveChangesAsync();
            }
        }
    }
}
