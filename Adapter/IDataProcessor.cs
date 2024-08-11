using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    public interface IDataProcessor {
        string ReadData();
        void SaveData(string data);
    }
}
