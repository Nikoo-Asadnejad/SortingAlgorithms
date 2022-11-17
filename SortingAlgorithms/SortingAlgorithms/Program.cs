using SortingAlgorithmsLibrary;

Console.WriteLine("Selection Sort");
List<int> ints = new () { 1, -10 , 9 , -15 ,3 , 8};
Console.WriteLine($"Input Values : {ints.GetString<int>()}");
Console.WriteLine($"SelectionSort result : { ints.SelectionSort<int>().GetString<int>() }");

 ints = new() { 1, -10, 9, -15, 3, 8 };
Console.WriteLine($"InsertionSort result : {ints.InsertionSort<int>().GetString<int>()}");

Console.ReadKey();

