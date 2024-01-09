using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Precub_Oana_app.Models
{
    public class Locatie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Adresa { get; set; }

        [OneToMany]
        public List<Rezervare> Rezervari { get; set; }
    }
}
