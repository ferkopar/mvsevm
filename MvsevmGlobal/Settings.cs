using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvsevmGlobal
{
    public static class Settings
    {
        public static readonly string ConnectionString =
                        "metadata=res://*/MvsevmModelMySql.csdl|res://*/MvsevmModelMySql.ssdl|res://*/MvsevmModelMySql.msl;provider=MySql.Data.MySqlClient;provider connection string=\"server=localhost;user id=user;password=pina;database=mvsevm;Convert Zero Datetime=True;\";";

    }
}
