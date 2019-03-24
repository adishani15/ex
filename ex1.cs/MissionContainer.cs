using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer

    {
        public delegate double MyDel(double x);
        private Dictionary<string, MyDel> openWith;

        public FunctionsContainer()
        {
            this.openWith = new Dictionary<string, MyDel>();
        }

        public List<string> getAllMissions()
        {
            List<string> name = new List<string>();
            foreach (KeyValuePair<string, MyDel> var in this.openWith)
            {
                name.Add(var.Key);
            }
            return name;
        }

        public MyDel this[string s]
        {
            get
            {
                if (!this.openWith.ContainsKey(s))
                {
                    this.openWith.Add(s, val => val);
                }
                return this.openWith[s];
            }
            set
            {
                if (!this.openWith.ContainsKey(s))
                {
                    this.openWith.Add(s, value);
                }
                this.openWith[s] = value;
            }
        }

    }

}
