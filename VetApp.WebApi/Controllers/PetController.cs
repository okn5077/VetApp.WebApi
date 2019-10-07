using Microsoft.AspNetCore.Mvc;
using VetApp.Model;
using VetApp.Services.Services.MongoRepository;

namespace VetApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : BaseMongoController<Pet>
    {

        public PetController(PetRepository petRepository) : base(petRepository)
        {
        }


    }
}