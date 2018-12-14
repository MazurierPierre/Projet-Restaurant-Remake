using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    class Actor : IActor//, IObserver<T>
    {
        public IDisposable cancellation { get; set; }
        public List<string> itemInfo { get; set; }
        public Dictionary<string, IAct> actions { get; set; }
        public IAct iAct { get; set; }
        public InitControler initControler;

        /*
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(T value)
        {
            throw new NotImplementedException();
        }
        */
    }
}
