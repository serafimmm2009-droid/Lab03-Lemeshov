System.Console.WriteLine("Банковский счет");

double balance = 1000;
System.Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; //пополнение
System.Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200; // покупка
System.Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; // начисление на 5% процентов
System.Console.WriteLine($"После начисления на 5%: {balance}");

balance /= 2; // разделили счёт пополам с партнером
System.Console.WriteLine($"После деления пополам: {balance}");
