//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

System.Console.WriteLine("Введите номер строки: ");
string str1 = Console.ReadLine();

System.Console.WriteLine("Введите номер столбца: ");
string str2 = Console.ReadLine();

int num1 = Convert.ToInt32(str1);
int num2 = Convert.ToInt32(str2);
Console.WriteLine();

int [,] numbers = NewMatrixStr(9,9);
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
    
 bool fl=false;   
 int numFind = 0;
for(int i = 0; i<numbers.GetLength(0); i++){
    for(int j = 0; j<numbers.GetLength(1); j++){
        if (num1==i && num2==j){
            fl = true;
            numFind = numbers[i,j];
        }
    }
}
if (fl) {
    Console.WriteLine(numFind);
} else {
        Console.WriteLine("Введенного элемента не существует");
}

