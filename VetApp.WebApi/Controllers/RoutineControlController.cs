﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VetApp.Model;
using VetApp.Services.Services.MongoRepository;

namespace VetApp.WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoutineControlController : BaseMongoController<RoutineControl>
    {

        public RoutineControlController(RoutineControlRepository routineControlRepository) : base(routineControlRepository)
        {
        }
    }
}