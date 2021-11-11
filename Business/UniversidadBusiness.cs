using Data;
using Entity;
using NLog;
using System;
using System.Collections.Generic;

namespace Business
{
    public class UniversidadBusiness
    {
        private readonly UniversidadData universidadData = new UniversidadData();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public List<UniversidadEntity> LIS_UniversidadBusiness(string CODALU)
        {
            return universidadData.LIS_UniversidadData(CODALU);

        }
        
        
    }
}
