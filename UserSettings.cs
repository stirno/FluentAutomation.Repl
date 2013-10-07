using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class UserSettings
    {
        public UserSettings()
        {
            this.StatusLineString = "[$browser:$site]";
            this.StatusLineSeparator = "> ";
        }

        public string StatusLineString { get; set; }

        public string StatusLineSeparator { get; set; }
    }
}
