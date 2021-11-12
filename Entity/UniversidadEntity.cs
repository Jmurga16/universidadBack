using System;

namespace Entity
{
    public class UniversidadEntity
    {
        public string CODALU { get; set; }
        public string NOMALU { get; set; }
        public string APEALU { get; set; }
        public string CODCUR { get; set; }
        public string NOMCUR { get; set; }
        public int NOTA { get; set; }
        public int CREDITO { get; set; }

    }
    public class AlumnosEntity
    {
        public string CODALU { get; set; }
        public string NOMALU { get; set; }
        public string APEALU { get; set; }
    }
    public class CursosEntity
    {
        public string CODCUR { get; set; }
        public string NOMCUR { get; set; }
        public int CREDITO { get; set; }
    }

    public class Alu_CurEntity
    {
        public string CODALU { get; set; }
        public string CODCUR { get; set; }
        public int NOTA { get; set; }
    }


}
