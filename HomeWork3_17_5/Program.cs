using HomeWork3_17_5;

var calculator = new Calculator();

int r = 7877;
double s = 231.23;
var a = calculator.Add(r, s);
var b = calculator.Subtract(r, s);
var c = calculator.Multiply(r, s);
var d = calculator.Divide(r, s);

Console.WriteLine($"{r} + {s} = {a}");
Console.WriteLine($"{r} - {s} = {b}");
Console.WriteLine($"{r} * {s} = {c}");
Console.WriteLine($"{r} / {s} = {d}");