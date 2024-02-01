// семинар 1 задача 2
// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит,
// является ли число чётным (делится ли оно на два без остатка).

int number;                             
    Console.WriteLine("введите число: ");
    number = Convert.ToInt32(Console.ReadLine()); 
    
    if (number % 2 == 0)
    {
        Console.WriteLine("четное");    
    }
    else
    {
        Console.WriteLine("нечетное");
    }

//    решение верное
// ответ из автотеста
// if ((number % 2) == 0)
//        {
//            Console.WriteLine($"четное");
//        }
//        else
//        {
//            Console.WriteLine($"нечетное");
//        }


