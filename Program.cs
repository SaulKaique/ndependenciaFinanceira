decimal gastosMensais, ValorAInvestir;
double valoraserdividido;

Console.WriteLine("--- Vivendo de dividendos ---\n");

Console.Write("Gastos mensais (em R$)....: ");
gastosMensais = Convert.ToDecimal(Console.ReadLine());

Console.Write("Rendimentos mensais (%)...: ");
valoraserdividido = Convert.ToDouble(Console.ReadLine());

ValorAInvestir = gastosMensais / Convert.ToDecimal(valoraserdividido / 100);

Console.WriteLine($"\nPara receber {gastosMensais:C} por mês com rendimentos de {valoraserdividido:N1}% você precisa ter investido {ValorAInvestir:C}.");