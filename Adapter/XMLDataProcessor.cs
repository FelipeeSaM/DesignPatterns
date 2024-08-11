using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adapter {
    public class XMLDataProcessor {
        private XElement _xmlData;

        public XMLDataProcessor() {
            _xmlData = new XElement("Root");
        }

        public string ReadXML() {
            return _xmlData.ToString();
        }

        public void SaveXML(string data) {
            _xmlData = XElement.Parse(data);
        }
    }
}
