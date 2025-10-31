// See https://aka.ms/new-console-template for more information
using Calculator;

var calculator = new Calc();
int result = 0;
result = calculator.Add(5);
Console.WriteLine(result);
result = calculator.Sub(3);
Console.WriteLine(result);
result = calculator.Undo(2);
Console.WriteLine(result);
result = calculator.Redo(1);
Console.WriteLine(result);
