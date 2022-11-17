using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsLibrary;
  public static class EnumrableExtensions
  {
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> enumrable)
       => enumrable.Select((item, index) => (item, index));
  }

