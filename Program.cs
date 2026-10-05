// System.Console.WriteLine("Банковский счет");

// double balance = 1000;
// System.Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500; //пополнение
// System.Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200; // покупка
// System.Console.WriteLine($"После покупки на 200: {balance}");

// balance *= 1.05; // начисление на 5% процентов
// System.Console.WriteLine($"После начисления на 5%: {balance}");

// balance /= 2; // разделили счёт пополам с партнером
// System.Console.WriteLine($"После деления пополам: {balance}");

// System.Console.WriteLine();
// System.Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// System.Console.WriteLine($"++weekNumber выводит: {lessonNumber++}");
// System.Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// System.Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
// System.Console.WriteLine($"После этого weekNumber = {weekNumber}");

// System.Console.WriteLine();
// System.Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// System.Console.WriteLine($"Попытка №{++attempts}");
// System.Console.WriteLine($"Попытка №{++attempts}");
// System.Console.WriteLine($"Всего попыток: {attempts}");

// System.Console.WriteLine();
// System.Console.WriteLine("Операторы сравнения");

// double myGrade = 4.67;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;
// System.Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing};");
// System.Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// System.Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}(может голосовать): {canVote}");
// System.Console.WriteLine($"Балл {myGrade} != 2.0 (не двойка): {isNotFailing}");

// System.Console.WriteLine();
// System.Console.WriteLine("Логические операторы");

// bool hasPassingGrade = true;
// bool hasAttedance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttedance;
// bool canRetakeExam = hasPassingGrade || hasAttedance;
// bool isDebtFree = !hasDebt;
// System.Console.WriteLine($"Может получить стипендию (оценка и посещаемость):{canGetScholarship}");
// System.Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canRetakeExam}");
// System.Console.WriteLine($"Нет долгов: {isDebtFree}");

// System.Console.WriteLine();
// System.Console.WriteLine("Короткое замыкание");

// bool CheckAndPrint(string label, bool value)
// {
//     System.Console.WriteLine($"  Вычисляется: {label}");
//     return value;
// }

// System.Console.WriteLine("Проверяем && (первый операнд false):");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// System.Console.WriteLine($"Результат: {resultAnd}");

// System.Console.WriteLine();
// System.Console.WriteLine("Проверяем || (первый операнд true):");
// bool resultOr = CheckAndPrint("C",  true) || CheckAndPrint("D", false);
// System.Console.WriteLine($"Результат: {resultOr}");

// System.Console.WriteLine();
// System.Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// System.Console.WriteLine($"2 + 3 * 4      = {resultNoParens}");
// System.Console.WriteLine($"(2 + 3) * 4    = {resultWithParens}");
// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// System.Console.WriteLine($"5>3 && 2<4 || false    = {logicResult}");
// System.Console.WriteLine($"(5>3 && 2<4) || false  = {logicResultParens}");

// System.Console.WriteLine();
// System.Console.WriteLine("Приемная комиссия");

// System.Console.WriteLine("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// System.Console.WriteLine("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);


// bool hasGoodCertificate = averageGrade >= 4.0;
// bool hasGoodExam = examScore >= 60;
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;
// double totalScore = averageGrade * 10;

// System.Console.WriteLine();
// System.Console.WriteLine("Результат");
// System.Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// System.Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// System.Console.WriteLine($"Льгота: {hasBenefit}");
// System.Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// System.Console.WriteLine($"Итоговый балл: {totalScore}");



// System.Console.WriteLine("Введите целое число");
// int questionNumber = int.Parse(Console.ReadLine());
// bool isEven = questionNumber % 2 == 0;
// System.Console.WriteLine(isEven);

int x = 0;
System.Console.WriteLine($"{x++}");
System.Console.WriteLine($"{x++}");
// Этот метод прибавляет и выводит уже измененное значение т.е во второй строчке будет 2

int x2 = 0;
System.Console.WriteLine($"{++x2}");
System.Console.WriteLine($"{++x2}");
// Этот метод выводит старое значение а потом уже изменяет первоначальное значение т.е во второй строчке будет 1

