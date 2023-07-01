// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int [] Numbers (int size)
{
    int [] array = new int [size]; 
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = Convert.ToInt32(Console.ReadLine());     
    }
    return array;
}


void Count (int [] array)
{
    
    for ( int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
}

void CountOfPositNums (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write( " -> " + count);
}

Console.WriteLine("Сколько чисел вы хотите ввести ");
int count = Convert.ToInt32(Console.ReadLine());

int [] nums = Numbers(count);
Count(nums);
CountOfPositNums(nums);















