using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class StatusViewModel
    {
        public Uri Url { get; set; }

        public FluentAutomation.SeleniumWebDriver.Browser? Browser { get; set; }

        public string Name { get; set; }
    }
}
