using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Commands.EntitiesCommands;
using Domain.Commands.EntitiesCommands.Tasks;
using Domain.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
          [FromBody]CreateTaskCommand command,
          [FromServices]CommandTaskHandler handler)
        {
           
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}

