using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace Precub_Oana_app.Models
{
    public class Categorie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nume { get; set; }

        [OneToMany]
        public List<Meniu> Meniuri { get; set; }
    }
}

