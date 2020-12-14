using Api.Core.Model;
using Api.Core.MongoRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Core.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RockSongsController : BaseMongoController<RockSongs>
    {
       
        public RockSongsController(RockSongsRepository rockSongsRepository) : base(rockSongsRepository)
        {
        }
    }
}