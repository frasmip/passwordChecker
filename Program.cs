// See https://aka.ms/new-console-template for more information
using PasswordChecker;

Console.WriteLine("Welcome to our password tester 1.0");

int minLength = 8;
string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowercase = "abcdefghijklmnopqrstuvwxyz";
string digits = "0123456789";
string specialChars = "!@#$%^&*";

Console.WriteLine("Enter a password...");
string password = Console.ReadLine();
int score = 0;


if (!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(lowercase))
{

    // conditions 



    score += password.Length >= minLength ? 1 : 0;
    score += Tools.Contains(password, uppercase) ? 1 : 0;
    score += Tools.Contains(password, lowercase) ? 1 : 0;
    score += Tools.Contains(password, digits) ? 1 : 0;
    score += Tools.Contains(password, specialChars) ? 1 : 0;

    //output password 

    string strength = score == 5 ? "extremely strong" :
                      score >= 3 ? "medium" :
                      score >= 1 ? "weak" :
                      "password doens't meet any of the standards.";
    Console.WriteLine($"Your password is {strength}");

} else
{
    Console.WriteLine("You didn't enter a password.");
}

