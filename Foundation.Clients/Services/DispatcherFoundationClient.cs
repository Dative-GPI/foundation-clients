using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Dispatcher;

namespace Foundation.Clients.Services
{
    public class DispatcherFoundationClient : IDispatcherFoundationClient
    {
        private IFoundationClient _root;
        public IDispatcherRoutineFoundationClient Routines { get; }

        public DispatcherFoundationClient(
            IDispatcherRoutineFoundationClient routines
        )
        {
            Routines = routines;
        }


        public void Init(IFoundationClient root)
        {
            this._root = root;

            Routines.Init(root);
        }
    }
}