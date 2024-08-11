using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    public class JSONDataProcessor : IDataProcessor {
        private JObject _jsonData;

        public JSONDataProcessor() {
            _jsonData = new JObject();
        }

        public string ReadData() {
            return _jsonData.ToString();
        }

        public void SaveData(string data) {
            _jsonData = JObject.Parse(data);
        }
    }
}
