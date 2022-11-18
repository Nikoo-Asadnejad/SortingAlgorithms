using SortingAlgorithmsLibrary;

List<int> ints = new () { 1, -10 , 9 , -15 ,3 , 8};
Console.WriteLine($"Input Values : {ints.GetString<int>()}");

Console.WriteLine($"SelectionSort result : { ints.SelectionSort().GetString() }");

ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"InsertionSort result : {ints.InsertionSort().GetString()}");

ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"BubbleSort result : {ints.BubbleSort().GetString()}");

ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"QuickSort result : {ints.QuickSort().GetString()}");

Console.ReadKey();

