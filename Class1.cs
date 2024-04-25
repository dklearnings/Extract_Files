using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Files
{
    public class FileMapping
    {
        public Mapping[] Mapping { get; set; }
    }

    public class Mapping
    {
        public int Id { get; set; }
        public string FormType { get; set; }

        public string FormMappig { get; set; }
        
    }
}
