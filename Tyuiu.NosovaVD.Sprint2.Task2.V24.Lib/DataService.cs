using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NosovaVD.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if((x >= 3 && x < 6) && (y >= 3 && y < 8))
            {
                res = true;
            }
            else if((x >= 6 && x < 9) && (y >= 5 && y < 11))
            {
                res = true;
            }
            else if ((x >= 9 && x < 13) && (y >= 3 && y < 7))
            {
                res = true;
            }
            else if ((x == 13) && (y == 6))
            {
                res = true;
            }
            else if ((x >= 9 && x < 13) && (y >= 9 && y < 11))
            {
                res = true;
            }
            else if ((x >= 3 && x < 8) && (y == 11))
            {
                res = true;
            }
            else if ((x == 7) && (y == 12))
            {
                res = true;
            }
            else if ((x >= 11 && x < 13) && (y >= 11 && y < 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
