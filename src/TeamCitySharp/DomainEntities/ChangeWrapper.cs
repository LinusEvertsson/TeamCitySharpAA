using System.Collections.Generic;

namespace TeamCitySharp.DomainEntities
{
    public class ChangeWrapper
    {
        public string Count { get; set; }
        public List<Change> Change { get; set; }
    }
}