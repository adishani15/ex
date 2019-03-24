using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private List<FunctionsContainer.MyDel> listDel;
        public event EventHandler<double> OnCalculate;

        public String Name { get; }
        public String Type { get; }

        public ComposedMission(string s)
        {
            this.listDel = new List<FunctionsContainer.MyDel>();
            this.Name = s;
            this.Type = "Composed";
        }

        public ComposedMission Add(FunctionsContainer.MyDel del)
        {
            this.listDel.Add(del);
            return this;
        }


        public double Calculate(double value)
        {
            double temp = value;
            foreach (FunctionsContainer.MyDel var in this.listDel)
            {
                temp = var(temp);

            }
            this.OnCalculate?.Invoke(this, temp);
            return temp;
        }


    }

}

