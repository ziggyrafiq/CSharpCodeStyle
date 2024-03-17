// Global usings
global using System;

using ZiggyRafiq.CodeStyles.Helper;
using ZiggyRafiq.CodeStyles.Models;

// Variables and data types
int age = 25;
string name = "John";
double height = 6.1;

// Control flow
if (age >= 18)
{
    Console.WriteLine($"You are an adult {name} and your height is {height}.");
}
else
{
    Console.WriteLine($"You are a minor {name} and your height is {height}.");
}


//Person Code Example
var person = new Person
{ Name="Tony Walker",
  Age=21
};

var student = new Student
{
    Name = "Lisa Simth",
    Age = 18,
    SchoolName = "Birmingham City High School",
    SchoolEmail = "info@birminghamcityhighschool.edu"
};

PersonChecker.CheckIfStudent(person);
PersonChecker.CheckIfStudent(student);

Console.WriteLine("Hello, world! using Global using System example, which is by default part of the console application in C#.");

//Calculator Code Example
var calculator = new Calculator();

int num1 = 10;
int num2 = 5;

// Addition
Console.WriteLine($"Addition: {num1} + {num2} = {calculator.Add(num1, num2)}");

// Subtraction
Console.WriteLine($"Subtraction: {num1} - {num2} = {calculator.Subtract(num1, num2)}");

// Multiplication
Console.WriteLine($"Multiplication: {num1} * {num2} = {calculator.Multiply(num1, num2)}");

// Division
try
{
    Console.WriteLine($"Division: {num1} / {num2} = {calculator.Divide(num1, num2)}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

//Remove Duplicates Code Example
int[] numbers = { 1, 1, 2, 2, 3, 4, 5, 5, 6 };

int length = Remove.Duplicates(numbers);
Console.WriteLine("Array with duplicates removed:");
for (int i = 0; i < length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine(); 

Console.WriteLine($"Length of the modified array: {length}");