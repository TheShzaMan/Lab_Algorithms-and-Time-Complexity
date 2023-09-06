using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Algorithms_and_BigONotation
{
    public class Algorithms
    {
        public Algorithms()
        {
            
        }
        public bool IsEvenNumber(int numberToVerify) 
        {
            bool isEven = false;
            if (numberToVerify % 2 == 0) 
            {
                isEven = true;
            }
            return isEven;
        }
    }
}
