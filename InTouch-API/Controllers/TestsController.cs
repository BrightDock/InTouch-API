using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace InTouch_API.Controllers
{
    public class TestsController : ApiController
    {
        public List<Tests> GetTests()
        {
            using (var Db = new InTouch_DBEntities())
            {
                return Db.Tests.ToList();
            }
        }

        public async Task AddTest(Tests test)
        {
            using (var Db = new InTouch_DBEntities())
            {
                Db.Tests.Add(test);
                await Db.SaveChangesAsync();
            }
        }
    }
}
