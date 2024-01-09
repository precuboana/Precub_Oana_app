using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precub_Oana_app.Models
{
    public class Meniu
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Denumire { get; set; }
        public double Pret { get; set; }

        [ForeignKey(typeof(Categorie))]
        public int CategorieID { get; set; }

        [ManyToOne]
        public Categorie Categorie { get; set; }
    }
}
