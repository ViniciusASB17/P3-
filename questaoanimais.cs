/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld
{
	static void Main()
	{
		string palavra1="";
		string palavra2="";
		string palavra3="";
		Console.WiriteLine("Escreva a primeira palavra:");
		palavra1=Console.ReadLine().ToLower();
		Console.WiriteLine("Escreva a primeira palavra:");
		palavra2=Console.ReadLine().ToLower();
		Console.WiriteLine("Escreva a primeira palavra:");
		palavra3=Console.ReadLine().ToLower();

		if (palavra1=="vertebrado")
		{
			if (palavra2=="ave")
			{
				if (palavra3=="carnivoro")
				{
					resultado="Aguia";
				}
				else if (palavra3=="onivoro")
				{
					resultado="Pomba";
				}


			}
			else if (palavra2=="mamifero")
			{
				if (palavra3=="onivoro")
				{
					resultado="Homem";
				}
				else if (palavra3=="herbivoro")
				{
					esultado="vaca";
				}
			}

			else if (palavra1=="invertebrado")
			{
				if (palavra2=="inseto")
				{
					if (palavra3=="hematofago")
					{
						resultado="Pulga";
					}

					else if (palavra3=="herbivoro")
					{
						resultado="largata";
					}

				}
			}
			else if (palavra2=="anelideo")
			{

				if (palavra3=="hematofogo")
				{
					resultado="sanguesuga";
				}
			}


			else if (palavra3=="onivoro")
			{
				resultado="minhoca";
			}
			
			Console.WiriteLine(resultado);

		}
	}
}


