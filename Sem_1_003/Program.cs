// задача 4 семинар 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;


while(count <= number)

    if(count % 2 ==0) 
    {
        Console.Write(count + " ");
        count++;
    }
else
{
     count++;
}


// задача решена верно
// решение от автотеста

//for (int count = 2; count <= number; count += 2)
//        {
//            Console.Write($"{count} ");
//        }

