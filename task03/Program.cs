//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов

int [,] numbers = NewMatrixStr(9,8);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"[{String.Join(",", NeedNum(numbers))}]");


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
        int sum = 0;
        for(int j = 0; j<matr.GetLength(1); j++){
            Console.Write(matr[i,j] + " ");
            sum +=matr[i,j];
        }
        Console.Write( " Sum:" + sum); 
        Console.WriteLine();   
    }
}


if(CheckNum(numbers)){

} else Console.WriteLine("задайте прямоугольный двумерный массив");

bool CheckNum(int [,] count){
    for (int i = 0; i < count.GetLength(0); i++)
    {
        for (int j = 0; j < count.GetLength(1); j++)
        {
            if(count.GetLength(0)==count.GetLength(1)){
                return false;
            }
        }
    }
    return true;
}

int[] NeedNum(int [,] col){
    int sumMin = 0;
    int [] minArray = new int[col.GetLength(1)];
    for(int i = 0; i<col.GetLength(0); i++){//строка
        int sum = 0;
        int [] array = new int[col.GetLength(1)];
        for(int j = 0; j<col.GetLength(1); j++){
            sum +=col[i,j];
            array[j] = col[i,j];
        }
        if ((i == 0) || sum < sumMin) {
            sumMin = sum;
            minArray = array;
        }

    }
    return minArray; 
}