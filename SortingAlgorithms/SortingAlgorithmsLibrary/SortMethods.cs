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

  public static IList<T> InsertionSort<T>(this IList<T> list) where T : IComparable
  {

    for (int index = 1; index < list.Count; index++)
    {
      int j = index;
      while (j > 0 && list[j].CompareTo(list[j-1]) < 0)
      {
        T temp = list[j - 1];
        list[j - 1] = list[j];
        list[j] = temp;
        j--;
      }
    }

    return list;
  }

  public static IList<T> BubbleSort<T>(this IList<T> list) where T : IComparable
  {

    for (int index = 0; index < list.Count; index++)
    {
      bool hasChanged = false;
      for (int j = 0; j < list.Count -1; j++)
      {
        if (list[j+1].CompareTo(list[j]) < 0)
        {
          hasChanged = true;
          T temp = list[j];
          list[j] = list[j + 1];
          list[j + 1] = temp;
        }
      }

      if (!hasChanged)
        break;
    }

    return list;
  }

}
