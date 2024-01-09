using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Precub_Oana_app.Models;

namespace Precub_Oana_app.Data
{
    public class ShoppingListDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ShoppingListDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            _database.CreateTableAsync<Rezervare>().Wait();
            _database.CreateTableAsync<Client>().Wait();
            _database.CreateTableAsync<Meniu>().Wait();
            _database.CreateTableAsync<Categorie>().Wait();
            _database.CreateTableAsync<Locatie>().Wait();
        }
        public Task<List<Rezervare>> GetRezervariAsync()
        {
            return _database.Table<Rezervare>().ToListAsync();
        }

        public Task<Rezervare> GetRezervareAsync(int id)
        {
            return _database.Table<Rezervare>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveRezervareAsync(Rezervare rezervare)
        {
            if (rezervare.ID != 0)
            {
                return _database.UpdateAsync(rezervare);
            }
            else
            {
                return _database.InsertAsync(rezervare);
            }
        }

        public Task<int> DeleteRezervareAsync(Rezervare rezervare)
        {
            return _database.DeleteAsync(rezervare);
        }


        // CRUD pentru Client
        public Task<List<Client>> GetClientiAsync()
        {
            return _database.Table<Client>().ToListAsync();
        }

        public Task<Client> GetClientAsync(int id)
        {
            return _database.Table<Client>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveClientAsync(Client client)
        {
            if (client.ID != 0)
            {
                return _database.UpdateAsync(client);
            }
            else
            {
                return _database.InsertAsync(client);
            }
        }

        public Task<int> DeleteClientAsync(Client client)
        {
            return _database.DeleteAsync(client);
        }


        // CRUD pentru Meniu
        public Task<List<Meniu>> GetMeniuriAsync()
        {
            return _database.Table<Meniu>().ToListAsync();
        }

        public Task<Meniu> GetMeniuAsync(int id)
        {
            return _database.Table<Meniu>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveMeniuAsync(Meniu meniu)
        {
            if (meniu.ID != 0)
            {
                return _database.UpdateAsync(meniu);
            }
            else
            {
                return _database.InsertAsync(meniu);
            }
        }

        public Task<int> DeleteMeniuAsync(Meniu meniu)
        {
            return _database.DeleteAsync(meniu);
        }



        // CRUD pentru Categorie
        public Task<List<Categorie>> GetCategoriiAsync()
        {
            return _database.Table<Categorie>().ToListAsync();
        }

        public Task<Categorie> GetCategorieAsync(int id)
        {
            return _database.Table<Categorie>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCategorieAsync(Categorie categorie)
        {
            if (categorie.ID != 0)
            {
                return _database.UpdateAsync(categorie);
            }
            else
            {
                return _database.InsertAsync(categorie);
            }
        }

        public Task<int> DeleteCategorieAsync(Categorie categorie)
        {
            return _database.DeleteAsync(categorie);
        }



        // CRUD pentru Locatie
        public Task<List<Locatie>> GetLocatiiAsync()
        {
            return _database.Table<Locatie>().ToListAsync();
        }

        public Task<Locatie> GetLocatieAsync(int id)
        {
            return _database.Table<Locatie>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveLocatieAsync(Locatie locatie)
        {
            if (locatie.ID != 0)
            {
                return _database.UpdateAsync(locatie);
            }
            else
            {
                return _database.InsertAsync(locatie);
            }
        }

        public Task<int> DeleteLocatieAsync(Locatie locatie)
        {
            return _database.DeleteAsync(locatie);
        }



        public Task<Utilizator> GetUtilizatorAsync(string numeUtilizator)
        {
            return _database.Table<Utilizator>()
                            .Where(u => u.NumeUtilizator == numeUtilizator)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveUtilizatorAsync(Utilizator utilizator)
        {
            return _database.InsertAsync(utilizator);
        }


    }
}

