using ScriptCs;
using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class ReplScriptServicesBuilder : ScriptServicesBuilder
    {
        public ReplScriptServicesBuilder(ScriptConsole console, Common.Logging.ILog logger, IRuntimeServices runtimeServices = null)
            : base(console, logger, runtimeServices)
        {
            this.Overrides.Add(typeof(IScriptExecutor), typeof(Repl));
        }
    }
}
