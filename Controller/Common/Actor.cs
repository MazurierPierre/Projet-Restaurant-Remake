using Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public abstract class Actor : IActor, IAct
    {
        public string name { get; set; }
        public IDisposable cancellation { get; set; }
        public List<string> itemInfo { get; set; }
        public IAct iAct { get; set; }
        public Dictionary<string, IAct> mapActions { get; set; }
        public Boolean lockAction;

        protected Actor(string name)
        {
            this.name = name;
            this.mapActions = new Dictionary<string, IAct>();
        }

        public virtual void act()
        {
            throw new NotImplementedException();
        }

        public virtual void threadStart()
        {
            throw new NotImplementedException();
        }

        public virtual void action(string choice)
        {
            throw new NotImplementedException();
        }
    }
}
