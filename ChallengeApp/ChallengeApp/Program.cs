using ChallengeApp;


Employee user1 = new Employee("Andrew", "Golara", 56);
Employee user2 = new Employee("Professional", "Fajer", 50);
Employee user3 = new Employee("John", "Doe", 24);


user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(3);
user1.AddScore(8);
user1.AddScore(6);
var result1 = user1.Result;
// Console.WriteLine(result1);

user2.AddScore(4);
user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(6);
user2.AddScore(9);
var result2 = user2.Result;
// Console.WriteLine(result2);

user3.AddScore(8);
user3.AddScore(9);
user3.AddScore(10);
user3.AddScore(6);
user3.AddScore(4);
var result3 = user3.Result;
// Console.WriteLine(result3);


if (result1 > result2 && result1 > result3)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user1.Name);
    Console.WriteLine("Nazwisko: " + user1.Surname);
    Console.WriteLine("Wiek: " + user1.Age);
    Console.WriteLine("Wynik: " + result1);
}
else if (result2 > result1 && result2 > result3)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user2.Name);
    Console.WriteLine("Nazwisko: " + user2.Surname);
    Console.WriteLine("Wiek: " + user2.Age);
    Console.WriteLine("Wynik: " + result2);
}
else if (result3 > result1 && result3 > result2)
{
    Console.WriteLine("Najwyzszy wynik ma:");
    Console.WriteLine("Imie: " + user3.Name);
    Console.WriteLine("Nazwisko: " + user3.Surname);
    Console.WriteLine("Wiek: " + user3.Age);
    Console.WriteLine("Wynik: " + result3);
}