//Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

int [,] numbers = NewMatrixStr(4,3);
Console.WriteLine("Init Array:");
PrintArray(numbers);
Console.WriteLine();

int[,] changeArr = NewArray(numbers);
Console.WriteLine("Swap Array:");
PrintArray(changeArr);

int [,] NewMatrixStr(int i, int j){
    int [,] array = new int[i,j];
    for(i = 0; i<array.GetLength(0); i++){//строка
        for(j = 0; j<array.GetLength(1); j++){//столбцы
            array[i,j] = new Random().Next(1,10);
        }
    }
 return array;
}

void PrintArray(int [,] matr){
    for(int i = 0; i<matr.GetLength(0); i++){
        for(int j = 0; j<matr.GetLength(1); j++){
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine("");    
    }
}

int [,] NewArray (int [,] count){
    
    for(int j = 0; j<count.GetLength(1); j++){
            int firstTmp = count[0,j];
            int lastTmp = count[count.GetLength(0)-1,j];
            
            count[0,j] = lastTmp;
            count[count.GetLength(0)-1,j] = firstTmp;
                     
    }

    return count;
}