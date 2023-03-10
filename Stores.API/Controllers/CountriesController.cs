using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stores.API.Data;
using Stores.Shared.Entities;


namespace Stores.API.Controllers
{
    [ApiController] //  Etiqueta Controlador de Api
    [Route("/api/countries")] // Otra etiqueta invoca el get, el post y delete
    public class CountriesController: ControllerBase

    {
        // Variable tipo privado 
        private readonly DataContext _context;
        private readonly DataContext context;

        //Invocar el constructor dentro de los () son los parametros
        public CountriesController(DataContext context)
        {
            //parametro del cuerpo
            _context = context;
        }
        
        // Crear un metodito 1 Get
        [HttpGet]
        //Manera Asincrona y siempre dar un return
        public async Task <ActionResult> Get() 
        {
            // Los get son unos select 
            return Ok (await _context.Countries.ToListAsync());

        
        }

        // Insertar datos, parametros, el post pertenece a Create
        [HttpPost]
        public async Task<ActionResult> Post(Country country)
        {
            _context.Add(country);
            await _context.SaveChangesAsync();
            return Ok(country);


        }




    }

}
