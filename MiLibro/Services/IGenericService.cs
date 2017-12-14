using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiLibro.Services
{
    interface IGenericService
    {
        bool Create(string query);
        SqlDataReader Read(string query);
        bool Update(string query);
        bool Delete(string query);
    }
}
