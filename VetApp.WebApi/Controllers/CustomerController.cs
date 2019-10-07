using Microsoft.AspNetCore.Mvc;
using VetApp.Model;
using VetApp.Services.Services.MongoRepository;

namespace VetApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseMongoController<Customer>
    {

        public CustomerController(CustomerRepository customerRepository) : base(customerRepository)
        {
        }
    }
}