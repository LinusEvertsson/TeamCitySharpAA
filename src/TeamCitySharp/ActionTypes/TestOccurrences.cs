using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCitySharp.Connection;
using TeamCitySharp.DomainEntities;
using TeamCitySharp.Locators;

namespace TeamCitySharp.ActionTypes
{
    internal class TestOccurrences : ITestOccurrences
    {
        private readonly TeamCityCaller _caller;

        internal TestOccurrences(TeamCityCaller caller)
        {
            _caller = caller;
        }

        public List<TestOccurrence> ByBuildId(string buildId)
        {
            var buildWrapper = _caller.GetFormat<TestOccurrenceWrapper>("/app/rest/testOccurrences?locator=build:(id:" + buildId + "),count:100000");
            if (int.Parse(buildWrapper.Count) > 0)
            {
                return buildWrapper.TestOccurrence;
            }
            return new List<TestOccurrence>();
        }
    }
}
