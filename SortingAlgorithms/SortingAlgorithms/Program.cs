using SortingAlgorithmsLibrary;

List<int> ints = new () { 1, -10 , 9 , -15 ,3 , 8};
Console.WriteLine($"Input Values : {ints.GetString<int>()}");

Console.WriteLine($"SelectionSort result : { ints.SelectionSort<int>().GetString<int>() }");

ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"InsertionSort result : {ints.InsertionSort<int>().GetString<int>()}");

ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"BubbleSort result : {ints.BubbleSort<int>().GetString<int>()}");

Console.ReadKey();

