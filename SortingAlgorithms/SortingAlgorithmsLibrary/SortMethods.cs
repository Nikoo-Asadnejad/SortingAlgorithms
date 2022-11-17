using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsLibrary;
public static class SortMethods
{
  public static IList<T> SelectionSort<T>(this IList<T> list) where T : IComparable
  {
   
    for(int index = 0 ; index < list.Count; index ++)
    {
      int minIndex = index;
      T minValue = list[index];

      for (int j = index + 1; j < list.Count; j++)
      {
        if (list[j].CompareTo(minValue) < 0)
        {
          minValue = list[j];
          minIndex = j;
        }
      }
      list[minIndex] = list[index];
      list[index] = minValue;
    }

    return list;
  }

}
