using System.Globalization;

Console.Clear();

double salario, fgts, resultadoSalario;

Console.Write("Digite seu salário: ");
salario = Convert.ToInt32(Console.ReadLine());

fgts = 0.08;

resultadoSalario = salario * fgts;
Console.Clear();

Console.WriteLine($"Salário..: {salario.ToString("C", CultureInfo.CurrentCulture)}");
Console.WriteLine($"FGTS.....: {resultadoSalario.ToString("C", CultureInfo.CurrentCulture)}");