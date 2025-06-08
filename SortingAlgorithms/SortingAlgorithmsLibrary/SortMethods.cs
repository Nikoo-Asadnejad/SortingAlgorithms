using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsLibrary;
public static class SortMethods
{
  public static IList<T> SelectionSort<T>(this IList<T> list) where T : IComparable
  {
   // 2,3,7,1,3,5
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
      list.Swap(firstIndex :  index, secondIndex :minIndex);
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
        list.Swap(firstIndex: j-1 , secondIndex : j);
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
          list.Swap(firstIndex : j , secondIndex : j + 1);
        }
      }

      if (!hasChanged)
        break;
    }

    return list;
  }

  public static IList<T> QuickSort<T>(this IList<T> list) where T : IComparable
  {
    list.QuickSort(0, list.Count - 1);
    return list;
  }
 
    public static void Sort(int[] array) => MergeSortRecursive(array, 0, array.Length - 1);

    private static void MergeSortRecursive(int[] array, int left, int right)
    {
      if (left >= right) return;
      int mid = (left + right) / 2;
      MergeSortRecursive(array, left, mid);
      MergeSortRecursive(array, mid + 1, right);
      Merge(array, left, mid, right);
    }

    private static void Merge(int[] array, int left, int mid, int right)
    {
      int[] leftArr = array[left..(mid + 1)];
      int[] rightArr = array[(mid + 1)..(right + 1)];
      int i = 0, j = 0, k = left;

      while (i < leftArr.Length && j < rightArr.Length)
        array[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];

      while (i < leftArr.Length) array[k++] = leftArr[i++];
      while (j < rightArr.Length) array[k++] = rightArr[j++];
    }
  

  private static IList<T> QuickSort<T>(this IList<T> list , int subArrayFirstIndex , int subArrayLastIndex) where T : IComparable
  {
    if(subArrayFirstIndex < subArrayLastIndex)
    {
      int pivot = list.Partition(subArrayFirstIndex, subArrayLastIndex);
      list.QuickSort(subArrayFirstIndex , pivot);
      list.QuickSort(pivot + 1 , subArrayLastIndex);
    }

    return list;
  }

  private static int Partition<T>(this IList<T> list, int firstIndex , int lastIndex) where T : IComparable
  {
    T pivot = list[(int)((lastIndex + firstIndex) / 2)];
    while (firstIndex < lastIndex)
    {
      while (list[firstIndex].CompareTo(pivot) < 0) firstIndex++;
      while (list[lastIndex].CompareTo(pivot) > 0) lastIndex--;
      if (lastIndex <= firstIndex) break;
      list.Swap(firstIndex, lastIndex);
    }

    //do
    //  {
    //    while (list[firstIndex].CompareTo(pivot) < 0) firstIndex++;
    //    while (list[lastIndex].CompareTo(pivot) > 0) lastIndex--;
    //    if (lastIndex <= firstIndex) break;
    //    list.Swap(firstIndex, lastIndex);
    //  }
    //  while (firstIndex <= lastIndex);

    return lastIndex;
  }
  private static void Swap<T>( this IList<T> list, int firstIndex , int secondIndex)
  {
    T temp = list[firstIndex];
    list[firstIndex] = list[secondIndex];
    list[secondIndex] = temp;
  }

}
