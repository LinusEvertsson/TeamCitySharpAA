using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCitySharp.DomainEntities
{
    public class TestOccurrenceWrapper
    {
        public string Count { get; set; }
        public List<TestOccurrence> TestOccurrence { get; set; }
    }
}
