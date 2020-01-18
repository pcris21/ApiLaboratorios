using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dasa.Laboratorios.Dominio.Commands;
using Dasa.Laboratorios.Dominio.Commands.ExameCommands.Inputs;
using Dasa.Laboratorios.Dominio.Handlers;
using Dasa.Laboratorios.Dominio.Queries;
using Dasa.Laboratorios.Dominio.Repositorios;
using Dasa.Laboratorios.Shared.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dasa.Laboratorios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExameController : ControllerBase
    {
        private readonly IExameRepositorio _exameRepositorio;
        private readonly ExameHandler _exameHandler;
        public ExameController(IExameRepositorio exameRepositorio, ExameHandler exameHandler)
        {
            _exameRepositorio = exameRepositorio;
        }

        [HttpGet]
        [Route("v1/exames")]
        public IEnumerable<ExameQueryResult> Get()
        {
            return _exameRepositorio.Listar();
        }

        [HttpPost]
        [Route("v1/exames")]
        public ICommandResult Post([FromBody] CriarExameCommand exameCommand)
        {
            var result = (CommandResult)_exameHandler.Handle(exameCommand);
            return result;
        }
    }
}