// Задача: на входе 3 числа, на выход большее

int a = 1;
int b = 3;
int c = 5;
if (a > b && a > c)
                    Console.WriteLine("max = " + a); 
                else if (b > c)
                    Console.WriteLine("max = " + b); 
                else
                    Console.WriteLine("max = " + c); 
            
            Console.ReadLine();