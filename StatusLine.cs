using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class StatusLine
    {
        private UserSettings settings = null;
        private StatusViewModel viewModel = null;

        public StatusLine(UserSettings settings, StatusViewModel viewModel)
        {
            this.settings = settings;
            this.viewModel = viewModel;
        }

        public override string ToString()
        {
            // token replacement
            var formatString = this.settings.StatusLineString;

            if (this.viewModel.Url != null)
                formatString = formatString.Replace("$site", this.viewModel.Url.DnsSafeHost);

            if (!string.IsNullOrEmpty(this.viewModel.Name))
                formatString = formatString.Replace("$name", this.viewModel.Name);

            if (this.viewModel.Browser.HasValue)
                formatString = formatString.Replace("$browser", this.viewModel.Browser.ToString().ToLower());

            // strip any unreplaced tokens
            formatString = Regex.Replace(formatString, "\\$\\w+", "");

            return formatString + settings.StatusLineSeparator;
        }
    }
}
