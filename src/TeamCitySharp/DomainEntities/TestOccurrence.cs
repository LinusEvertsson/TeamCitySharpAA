using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySharp.DomainEntities
{
    public class TestOccurrence
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Duration { get; set; }
        public string Href { get; set; }
    }
}
