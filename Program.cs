double PercentualDeBonus, PercentualDeRetorno;
double pontosATransferir, pontosAReduzir, pontosAAcrescentar;

Console.Clear();
Console.WriteLine("--- Milhas Bumerangue --- \n");

Console.Write("Parcentual de bonus.....");
PercentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("PercentualDeBonus.....:");
PercentualDeRetorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a transferir.....:");
pontosATransferir = Convert.ToDouble(Console.ReadLine());

pontosAReduzir = pontosATransferir - (pontosATransferir * PercentualDeRetorno) / 100;
pontosAAcrescentar = pontosATransferir - (pontosATransferir * PercentualDeRetorno) / 100;

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........{pontosAReduzir}:");
Console.WriteLine($"Pontos a acrescentar no destino...{pontosAAcrescentar}:");
