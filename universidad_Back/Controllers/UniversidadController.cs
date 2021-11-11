using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace universidad_Back.Controllers
{
    

    [ApiController]
    [Route("api/[controller]")]
    public class UniversidadController : Controller
    {
        private readonly UniversidadBusiness objUniversidad = new UniversidadBusiness();
        List<UniversidadEntity> lstUniversidad = new List<UniversidadEntity>();

        string strZona = "";

        //Obtener uno para editar
        [Route("{CODALU}")]
        [HttpGet]
        public List<UniversidadEntity> LIS_Universidad(string CODALU)
        {
            try
            {
                lstUniversidad = objUniversidad.LIS_UniversidadBusiness(CODALU);

            }
            catch (Exception e)
            {
                
                throw;
            }
            return lstUniversidad;
        }
    }
}
