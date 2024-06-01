using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Gestion_Funeraria__LP2_.Models;

namespace Sistema_Gestion_Funeraria__LP2_.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly FunerariaContext context;
        private readonly IMapper mapper;

        public CargoController(FunerariaContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cargo>>> GetCargo()
        {
            if (context.Cargos == null)
                return NotFound();
            var cargo = await context.Cargos.ToListAsync();
            return cargo;

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cargo>> GetCargo(int id)
        {
            if (context.Cargos == null)
                return NotFound();
            var cargo = await context.Cargos.FirstOrDefaultAsync(x=>x.IdCargo==id);
            if (cargo==null)
                return NotFound();
            return cargo;

        }

    }
}
