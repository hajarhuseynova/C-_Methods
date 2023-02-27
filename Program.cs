////task1
//int[] numbers = { 1, 5, 20, 3, 7, 15 };

//string result = Finding(numbers, 20);

//Console.WriteLine(result);

//string Finding(int[] numbers, int number)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] == number)
//        {
//            return "Array'de bu eded var";
//        }
//    }
//    return "Array'de bu eded yoxdur";
//}
//task2

Console.WriteLine("The maximum number of array:" + FindingMax(1, 20, 102, 130, 45, 80, 90, 60, 23));


int FindingMax(params int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (max < numbers[i])
        {
            max = numbers[i];
        }
    }
    return max;
}