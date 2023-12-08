using CrudFeelps.InputModels;
using Dominio;
using entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrudFeelps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        private readonly InterfaceVaga _interceVaga;

        public VagasController(InterfaceVaga vagaService)
        {
            _interceVaga = vagaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vaga>>> GetAllVagas()
        {
            var vagas = await _interceVaga.List();
            return Ok(vagas);
        }

        // Aqui, você pode adicionar outros métodos como Post (Criar), Put (Atualizar), Delete, etc.
        // Por exemplo:

        [HttpPost]
        public async Task<ActionResult<Vaga>> CreateVaga([FromBody] Vaga vaga)
        {
            await _interceVaga.Add(vaga);
            return CreatedAtAction(nameof(GetVagaById), new { id = vaga.Id }, vaga);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vaga>> GetVagaById(int id)
        {
            var vaga = await _interceVaga.GetEntityByID(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return Ok(vaga);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVaga(int id, [FromBody] InputVaga vagaInput)
        {
            var vaga = await _interceVaga.GetEntityByID(id);
            if (vaga == null)
            {
                return NotFound();
            }

            vaga.Empresa = vagaInput.ValidaCampo(vagaInput.empresa) ? vagaInput.empresa : vaga.Empresa;
            vaga.Email = vagaInput.ValidaCampo(vagaInput.email) ? vagaInput.email : vaga.Email;
            vaga.CNPJ = vagaInput.ValidaCampo(vagaInput.cnpj) ? vagaInput.cnpj : vaga.CNPJ;
            vaga.FoneSolicitante = vagaInput.ValidaCampo(vagaInput.foneSolicitante) ? vagaInput.foneSolicitante : vaga.FoneSolicitante;
            vaga.NomeSolicitante = vagaInput.ValidaCampo(vagaInput.nomeSolicitante) ? vagaInput.nomeSolicitante : vaga.NomeSolicitante;
            vaga.ModeloContratacao = vagaInput.ValidaCampo(vagaInput.modeloContratacao) ? vagaInput.modeloContratacao : vaga.ModeloContratacao;
            vaga.TipoContratacao = vagaInput.ValidaCampo(vagaInput.tipoContratacao) ? vagaInput.tipoContratacao : vaga.TipoContratacao;
            vaga.LocalContratacao = vagaInput.ValidaCampo(vagaInput.localContratacao) ? vagaInput.localContratacao : vaga.LocalContratacao;
            vaga.Cargo = vagaInput.ValidaCampo(vagaInput.cargo) ? vagaInput.cargo : vaga.Cargo;
            vaga.HorarioTrabalho = vagaInput.ValidaCampo(vagaInput.horarioTrabalho) ? vagaInput.horarioTrabalho : vaga.HorarioTrabalho;
            vaga.PrioridadeContratacao = vagaInput.ValidaCampo(vagaInput.prioridadeContratacao) ? vagaInput.prioridadeContratacao : vaga.PrioridadeContratacao;
            vaga.Senioridade = vagaInput.ValidaCampo(vagaInput.senioridade) ? vagaInput.senioridade : vaga.Senioridade;
            vaga.RegimeTrabalho = vagaInput.ValidaCampo(vagaInput.regimeTrabalho) ? vagaInput.regimeTrabalho : vaga.RegimeTrabalho;
            vaga.BudgetMaximo = vagaInput.ValidaCampo(vagaInput.budgetMaximo) ? vagaInput.budgetMaximo.GetValueOrDefault() : vaga.BudgetMaximo;
            vaga.DescricaoBeneficios = vagaInput.ValidaCampo(vagaInput.DescricaoBeneficios) ? vagaInput.DescricaoBeneficios : vaga.DescricaoBeneficios;
            vaga.Responsabilidades = vagaInput.ValidaCampo(vagaInput.Responsabilidades) ? vagaInput.Responsabilidades : vaga.Responsabilidades;
            vaga.RequisitosTecnicos = vagaInput.ValidaCampo(vagaInput.RequisitosTecnicos) ? vagaInput.RequisitosTecnicos : vaga.RequisitosTecnicos;
            vaga.RequisitosComportamentais = vagaInput.ValidaCampo(vagaInput.RequisitosComportamentais) ? vagaInput.RequisitosComportamentais : vaga.RequisitosComportamentais;
            await _interceVaga.Update(vaga);
            return Ok(vaga);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaga(int id)
        {
            var vaga = await _interceVaga.GetEntityByID(id);
            await _interceVaga.Delete(vaga);
            return Ok();
        }
    }
}


