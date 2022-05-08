using Microsoft.Xrm.Sdk;
using System;

namespace Dataverse.ServerExtensions.Framework
{
    public abstract class PluginBase : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }

        protected abstract void ExecuteLogic();
    }
}
