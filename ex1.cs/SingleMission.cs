using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private FunctionsContainer.MyDel del;
        public event EventHandler<double> OnCalculate;

        public String Name { get; }
        public String Type { get; }

        public SingleMission(FunctionsContainer.MyDel d, string s)
        {
            this.del = d;
            this.Name = s;
            this.Type = "Single";
        }


        public double Calculate(double value)
        {
            double ans = this.del(value);
            this.OnCalculate?.Invoke(this, ans);
            return ans;
        }


    }
}

