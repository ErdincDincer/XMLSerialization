using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Address
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        [XmlAttribute]
        public int Priority { get; set; }
    }
}
