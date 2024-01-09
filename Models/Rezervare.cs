using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Precub_Oana_app.Models
{
    public class Rezervare
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Client))]
        public int ClientID { get; set; }

        [ForeignKey(typeof(Locatie))]
        public int LocatieID { get; set; }

        public DateTime DataRezervarii { get; set; }
        public string OraRezervarii { get; set; }
    }
}
