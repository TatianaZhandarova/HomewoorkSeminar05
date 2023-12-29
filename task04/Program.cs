//Задайте двумерный массив из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен 
//наименьший элемент массива. Под удалением понимается создание нового 
//двумерного массива без строки и столбца



int [,] numbers = NewMatrixStr(3,3);
PrintArray(numbers);
Console.WriteLine();

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
        Console.WriteLine( );    
    }
}

int min = numbers[0,0];
int minStr = 0;
int minStl = 0;
for(int i = 0; i<numbers.GetLength(0); i++){
    for(int j = 0; j<numbers.GetLength(1); j++){
        if(numbers[i,j]<min){
            min = numbers[i,j];
            minStr = i;
            minStl = j;
        }
    }
}
Console.WriteLine($"{min}[{minStr},{minStl}]");

int [,] array = NewMatrixStr2(minStr,minStl,numbers);

int [,] NewMatrixStr2(int minStr, int minStl, int [,] numbers){
    int [,] arr = new int[numbers.GetLength(0)-1,numbers.GetLength(1)-1];
    int iNew = 0;
    int jNew = 0;
    for(int i = 0; i<numbers.GetLength(0); i++){//строка
        if (i == minStr) {
            continue;
        }
        
        for(int j = 0; j<numbers.GetLength(1); j++){//столбцы
            if(j==minStl){
                continue;
            }
            arr[iNew,jNew] = numbers[i,j];
            jNew++;
        } 
        jNew = 0;  
        iNew++;
    }
    return arr;
}
PrintArray(array);