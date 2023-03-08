using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using P4E1119450112.Controllesr;
using P4E1119450112.Models;
using System.Threading.Tasks;

namespace P4E1119450112.Controllesr
{
    public class ubicaControllers
    {
        readonly SQLiteAsyncConnection connection;

        public ubicaControllers(String DBPath)
        {
            connection = new SQLiteAsyncConnection(DBPath);
            connection.CreateTableAsync<Models.Ubicacion>();
        }
       public Task<int> Saveubica(Models.Ubicacion ubicacion)
        {
            if (ubicacion.id != 0)

                return connection.UpdateAsync(ubicacion);

            else
                return connection.InsertAsync(ubicacion);
        }

        public Task<Models.Ubicacion> Getubica(int pid)
        {
            return connection.Table<Models.Ubicacion>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        //lista de ubicaciones
        public Task<List<Models.Ubicacion>> GetListubica()
        {
            return connection.Table<Models.Ubicacion>().ToListAsync();
        }
    }
}
