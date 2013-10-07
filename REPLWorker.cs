using ScriptCs;
using ScriptCs.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentAutomation.REPL
{
    public class ReplWorker
    {
        private Repl repl = null;
        private int workerCount = 0;

        public bool InProgress
        {
            get { return workerCount == 0; }
        }

        public ReplWorker(Repl repl)
        {
            this.repl = repl;
        }

        public void DoWork(Func<Repl, ScriptResult> scriptFunc)
        {
            this.DoWork(scriptFunc, (a) => { });
        }

        public void DoWork(Func<Repl, ScriptResult> scriptFunc, Action<ScriptResult> completeFunc)
        {
            var worker = new BackgroundWorker();
            worker.DoWork += (s, e) =>
            {
                this.workerCount++;
                e.Result = scriptFunc(this.repl);
            };

            worker.RunWorkerCompleted += (s, e) =>
            {
                this.workerCount--;
                completeFunc(e.Result as ScriptResult);
            };

            worker.RunWorkerAsync();
        }
    }
}
