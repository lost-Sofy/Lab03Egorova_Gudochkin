// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500;
// Console.WriteLine($"после пополнения на 500: {balance}");

// balance -= 200;
// Console.WriteLine($"после покупки а 200: {balance}");

// balance *= 1.05;
// Console.WriteLine($"после начисления 5%: {balance}");

// balance /= 2;
// Console.WriteLine($"после деления пополам: {balance}");


Console.WriteLine();
Console.WriteLine("оператры сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;

bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"возраст {myAge} >= {votingAge} (может голосовать): {canVote}");
Console.WriteLine($"балл {myGrade} != 2.0 (не двойка): {isNotFailing}");



























