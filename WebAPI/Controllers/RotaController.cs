using Entities.Interfaces;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class RotaController : ControllerBase
    {
        private readonly IRotaBusiness RotaRepository;

        public RotaController(IRotaBusiness rotaRepository)
        {
            RotaRepository = rotaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            try
            {
                List<RotaEntity> rotaList = RotaRepository.Listar();
                if (rotaList == null)
                {
                    return NotFound();
                }
                else
                    return StatusCode(200, rotaList);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Inserir([FromBody] RotaEntity rota)
        {
            try
            {
                bool sucesso = RotaRepository.Inserir(rota);

                if (sucesso)
                {
                    return StatusCode(201);
                }
                else
                    return BadRequest("Falha ao criar nova rota");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] RotaEntity rota)
        {
            try
            {
                bool sucesso = RotaRepository.Atualizar(rota);

                if (sucesso)
                {
                    return StatusCode(201);
                }
                else
                    return BadRequest("Falha ao atualizar rota");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                bool sucesso = RotaRepository.Excluir(id);

                if (sucesso)
                {
                    return StatusCode(201);
                }
                else
                    return BadRequest("Falha ao atualizar rota");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("Melhor/")]
        public async Task<IActionResult> GetMelhorRota(string origem, string destino)
        {
            try
            {
                var sucesso = RotaRepository.MelhorRota(origem, destino);

                if (sucesso != null)
                {
                    return StatusCode(200, sucesso);
                }
                else
                    return BadRequest("Falha ao encontrar");
            }
            catch (Exception)
            {
                throw;
            }
        }
        [HttpGet("id/")]
        public async Task<IActionResult> Buscar(int id)
        {
            try
            {
                RotaEntity rota = RotaRepository.Buscar(id);
                if (rota == null)
                {
                    return NotFound();
                }
                else
                    return StatusCode(200, rota);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
