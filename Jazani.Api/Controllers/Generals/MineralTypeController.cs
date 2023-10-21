﻿using Jazani.Application.Generals.Dtos.MineralTypes;
using Jazani.Application.Generals.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jazani.Api.Controllers.Generals
{
    [Route("api/[controller]")]
    [ApiController]
    public class MineralTypeController : ControllerBase
    {

        private readonly IMineralTypeService _mineralTypeService;

        public MineralTypeController(IMineralTypeService mineralTypeService)
        { 
            _mineralTypeService = mineralTypeService;
        }

        // GET: api/<MineralTypeController>
        [HttpGet]
        public async Task<IEnumerable<MineralTypeDto>> Get()
        {
            return await _mineralTypeService.FindAllAsync();
        }

        // GET api/<MineralTypeController>/5
        [HttpGet("{id}")]
        public async Task<MineralTypeDto> Get(int id)
        {
            return await _mineralTypeService.FindByIdAsync(id);
        }

        // POST api/<MineralTypeController>
        [HttpPost]
        public async Task<MineralTypeDto> Post([FromBody] MineralTypeSaveDto mineralTypeSaveDto)
        {
            return await _mineralTypeService.CreateAsync(mineralTypeSaveDto);
        }

        // PUT api/<MineralTypeController>/5
        [HttpPut("{id}")]
        public async Task<MineralTypeDto> Put(int id, [FromBody] MineralTypeSaveDto mineralTypeSaveDto)
        {
            return await _mineralTypeService.EditAsync(id, mineralTypeSaveDto);
        }

        // DELETE api/<MineralTypeController>/5
        [HttpDelete("{id}")]
        public async Task<MineralTypeDto> Delete(int id)
        {
            return await _mineralTypeService.DisabledAsync(id);
        }
    }
}
