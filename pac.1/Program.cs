Console.Clear();
Console.Write("Введите номер четверти: ");
int x = Convert.ToInt32(Console.ReadLine());
while (x < 1 || x  >4)
     x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
    Console.WriteLine("x > 0 and y > 0");
else if (x == 2)
    Console.WriteLine("x < 0 and y > 0");
else if (x == 3)
    Console.WriteLine("x < 0 and y < 0");
 else if (x == 4)
    Console.WriteLine("x > 0 and y < 0");