﻿using System;
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

        //Time Complexity for IsEvenNumber: O(1) Constant
        public bool IsEvenNumber(int numberToVerify) 
        {
            bool isEven = false;
            if (numberToVerify % 2 == 0) 
            {
                isEven = true;
            }
            return isEven;
        }

        //Time Complexity for IsLessThan100:   O(n) Linear
        public bool IsLessThan100(List<int> listToCheck)
        {
            bool isLessThan100 = false;
            for (int i = 0; i < listToCheck.Count; i++)
            {
                if (listToCheck[i] >= 100)
                {
                    isLessThan100 = false;
                    break;
                }
                else
                {
                    isLessThan100 = true;
                }
            }
            return isLessThan100;
        }

        //Time Complexity for HasMultipleNames:  O(n log n) Log Linear
        public bool HasMultipleNames(List<string> listToCheck) 
        {
            bool hasMultipleNames = false;
            for (int i = 0; i < listToCheck.Count; i++)
            {
                for (int j = (i + 1); j < listToCheck.Count; j++) 
                {
                    if (listToCheck[i].Equals(listToCheck[j]))
                    {
                        hasMultipleNames = true;
                        break;
                    }
                }
            }
            return hasMultipleNames;
        }

        //Time Complexity for SortToAscending:  O(n^2)
        public List<int> SortToAscending(List<int> listToSort)
        {
            List<int> ascendingList = new List<int>();
            ascendingList.AddRange(listToSort);

            for (int i = 0; i < listToSort.Count; i++)
            {
                for (int j = i + 1; j < listToSort.Count; j++)
                {
                    if (ascendingList[i] > ascendingList[j])
                    {
                        ascendingList[i] = listToSort[j];
                        ascendingList[j] = listToSort[i];
                        listToSort[i] = ascendingList[i];
                        listToSort[j] = ascendingList[j];
                        //listToSort.AddRange(ascendingList);
                        
                    }


                }
            }
            return ascendingList;
        }


                //for (int j = 0; j < listToSort.Count - i; j++)
                //{

                //    //if (listToSort[i] > listToSort[j])
                //    //{
                //    //    ascendingList[i] = listToSort[j];
                //    //    ascendingList[i + 1] = listToSort[i];
                        
                //    //}
                //    //else if (listToSort[i] < listToSort[j])
                //    //{
                //    //    ascendingList[i] = listToSort[i];
                //    //    ascendingList[i + 1] += listToSort[j + 1];
                        
                //    //}
                //    //else
                //    //{
                        
                //    //}
                //}
    }
}
