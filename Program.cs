using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //сума елементів масива А із 100 цілих чисел
            int A[100];
            int suma;//змінна,що містить суму
            int i;//додаткова змінна
            //Введення масива А
            // ...
            // знаходження суми 
            suma = 0;
            for (i = 0; i < 100; i++)
                suma += A[i];
        }
    }
}
