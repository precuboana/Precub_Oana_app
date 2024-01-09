using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Precub_Oana_app.Models
{
    public class Utilizator
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }
        // Rolul poate fi adăugat dacă implementezi un sistem de roluri
        //public string Rol { get; set; }
    }
}
