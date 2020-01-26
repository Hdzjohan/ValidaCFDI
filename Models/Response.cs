using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ValidacionCFDI.Models
{
    public class Response
    {
        public string RFC { get; set; }
        public XmlDocument CFDI { get; set; }
    }
}
