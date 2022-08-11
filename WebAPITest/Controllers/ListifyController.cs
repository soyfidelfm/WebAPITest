using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListifyController : ControllerBase
    {        
        [HttpGet(Name = "listify")]
        public int listify(int begin, int end, int index)
        {
            if(end<begin)
                return 0;            
            return Enumerable.Range(begin, end).ElementAt(index);
        }
    }
}
