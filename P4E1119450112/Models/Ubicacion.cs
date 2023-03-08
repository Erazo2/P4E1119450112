using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace P4E1119450112.Models
{
    class Ubicacion
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }   
        public double latitud { get; set; }
        public double longitud { get;set; }
        [MaxLength (200)]
        public string descripcion { get; set; }
        [MaxLength(200)]
        public string descripcionCorta { get; set; }

    }
}
