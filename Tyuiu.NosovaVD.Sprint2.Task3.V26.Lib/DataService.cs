using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NosovaVD.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double res = 0;
            if(x > 0)
            {
                res = x + Math.Pow(((x + 1) / Math.Cos(Math.Pow(x, 2))), x);
            }
            else
            {
                if (x == 0)
                {
                    res = (15 + x) / (Math.Pow(3, 2) - Math.Sin(Math.Pow(x, 2)));
                }
                else
                {
                    if (x > -30 && x < 0)
                    {
                        res = Math.Pow(((Math.Sin(Math.Pow(x, 3))) / (x + 5)), x);
                    }
                    else
                    {
                        if (x < -30)
                        {
                            res = x + 7 * x - (1 / x);
                        }
                    }
                }
            }          
            return Math.Round(res,3);
        }
    }
}
