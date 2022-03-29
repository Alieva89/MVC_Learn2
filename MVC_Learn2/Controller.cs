using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn2
{
    internal class Controller
    {
        public Controller(Model model)
        {
            Model = model;
        }

        private Model Model { get; set; }

        public void Calculate(double speed, double time)
        {
            /*Model.CalculateResult(speed, time);*/
        }
    }
}
