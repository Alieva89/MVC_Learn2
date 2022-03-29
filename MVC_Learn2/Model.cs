using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Learn2
{
    internal class Model
    {
        public delegate void ModelHndl(double result);
        public event ModelHndl? modelHndl;

        public void CalculateResult(ActionEnum action, double value, double value2)
        {
            switch (action)
            {
                case ActionEnum.SPEED:
                    modelHndl.Invoke(value2 / value);
                    break;
                case ActionEnum.TIME:
                    modelHndl.Invoke(value / value2);
                    break;
                case ActionEnum.DISTANCE:
                    modelHndl.Invoke(value * value2);
                    break;
                default:
                    break;
            }
        }
    }
}
