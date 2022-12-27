void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] createAndFillMatr(){
    Console.WriteLine("Введите количество строк ");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов ");
    int col = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[line, col];

    for (int i = 0; i < numbers.GetLength(0); i++){
         for (int j = 0; j < numbers.GetLength(1); j++){
            numbers[i, j] = Convert.ToInt32(new Random().Next(-100, 100)) / 10;
        }
    }
    PrintArray(numbers);
    return numbers;
}
// Task 1
// void createAndFillMatrDouble(){
//     Console.WriteLine("Введите количество строк ");
//     int line = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите количество столбцов");
//     int col = Convert.ToInt32(Console.ReadLine());
//     double[,] numbers = new double[line, col];
//     for (int i = 0; i < numbers.GetLength(0); i++){
//         for (int j = 0; j < numbers.GetLength(1); j++)
//         {
//             numbers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }

//     for (int i = 0; i < numbers.GetLength(0); i++){
//         Console.Write("[ ");
//         for (int j = 0; j < numbers.GetLength(1); j++){
//             Console.Write(numbers[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

//Task 2
// void findNumByPos(){
//     Console.Write("Введите строку : ");
//     int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
//     Console.Write("Введите столбец : ");
//     int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
//     int[,] arr = createAndFillMatr();
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
//     {
//     Console.WriteLine("Элемент не существует  ");
//     }
//     else
//     {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
//     }
// }

//Task 3
void findAverage(){
    int[,] arr = createAndFillMatr();
    double sum = 0;
    for (int col = 0; col < arr.GetLength(1); col++){
        for (int line = 0; line < arr.GetLength(0); line++)
        {
            sum += arr[line, col];
        }
        Console.Write($"{ sum / arr.GetLength(0)} ");
    }
}


//Task 1
//createAndFillMatrDouble();

//Task2 
//findNumByPos();

//Task 3
findAverage();