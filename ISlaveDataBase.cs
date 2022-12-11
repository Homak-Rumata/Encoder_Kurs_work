using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_окно
{
    internal interface ISlaveDataBase//:IDataBase
    {
        public string[] ProjectList();

        public string Data(string name);

        public void Data(string name, string data);

    }
}
