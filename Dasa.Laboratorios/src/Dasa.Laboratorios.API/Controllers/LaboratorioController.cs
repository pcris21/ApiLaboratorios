using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dasa.Laboratorios.Dominio.Commands;
using Dasa.Laboratorios.Dominio.Commands.LaboratorioCommands.Inputs;
using Dasa.Laboratorios.Dominio.Enuns;
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
    public class LaboratorioController : ControllerBase
    {
        private readonly ILaboratorioRepositorio _laboratorioRepositorio;
        private readonly LaboratorioHandler _laboratorioHandler;

        public LaboratorioController(ILaboratorioRepositorio laboratorioRepositorio, LaboratorioHandler laboratorioHandler)
        {
            _laboratorioRepositorio = laboratorioRepositorio;
            _laboratorioHandler = laboratorioHandler;
        }

        [HttpGet]
        [Route("v1/laboratorios")]
        public IEnumerable<LaboratorioQueryResult> Get()
        {
           return  _laboratorioRepositorio.Listar();
           
        }

        [HttpPost]
        [Route("v1/laboratorios")]
        public ICommandResult Post([FromBody] CriarLaboratorioCommand laboratorioCommand)
        {
            var result = (CommandResult)_laboratorioHandler.Handle(laboratorioCommand);
            return result;
        }
    }
}