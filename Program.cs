Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("+----- Calcular troco -----+\n");
Console.ResetColor();
Console.Write("|digite o valor da sua compra...: ");
double compra = Convert.ToDouble(Console.ReadLine());

Console.Write("|digite o valor pagamento...: ");
double vp = Convert.ToDouble(Console.ReadLine());

double troco = (vp - compra);
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("-------------------------------");
Console.ResetColor();

Console.WriteLine($"\n o troco de seu pagamento é...: {troco}\n");