using System;

class Pessoa 
{
	string Nome;
	int Idade;
	int Peso;
	double Altura;

	public void Envelhecer(int L)
	{
		if (L > Idade)
		{
			Idade = L;
		}
		else 
		{
			Console.WriteLine("Não envelheceu kk");
		}
		if (L < 21)
		{
			Altura = ((L - Idade) * 0.5) + Altura;
		}
	}
	public void Engordou(int G)
	{
		if (Peso < G)
		{
			Peso = G;
		}
	}
	public void Emagrecer(int M)
	{
		if (Peso >= M)
		{
			Peso = M;
		}
	}
	public void Crescer(double T)
	{
		if (Altura < T)
		{
			Altura = T;
		}
	}
}