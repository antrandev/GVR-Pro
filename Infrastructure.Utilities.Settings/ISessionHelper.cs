using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Settings
{
    public interface ISessionHelper
    {
        List<Dictionary<string, string>> GetListOfDatabases(string dbName);
    }
}
