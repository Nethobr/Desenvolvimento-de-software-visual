/*
	Curitiba, 2022/1
	Universidade Positivo
	Desenvolvimento de Software Visual
	Prof Jean Diogo
	
	PROVA 1
	
	REGRAS
	
	Analise o codigo abaixo e implemente as quatro funcoes que faltam para que os testes feitos na funcao Main tenham o resultado esperado
	Para testar, crie um projeto ("dotnet new console"), substitua o "Program.cs" por este codigo e compile ("dotnet run")
	Voce pode adicionar linhas de codigo a vontade (inclusive novas funcoes), mas nada do que ja esta escrito pode ser apagado
	A interpretacao do codigo faz parte da avaliacao
	A prova eh individual e deve ser submetida no blackboard ate o final da aula
	Apenas este arquivo precisa ser submetido
	O valor total da prova eh 4 pontos e o valor parcial de cada funcao a ser implementada esta comentado nela
	Mesmo que seu codigo nao esteja funcionando totalmente, ele sera analisado e podera receber uma pontuacao proporcional ao que tiver sido feito
	O horario para realizacao da prova eh exatamente o horario da aula
	Voce pode realizar a prova no seu proprio computador ou nos computadores do laboratorio
	Eh permitida consulta a internet e ao material de aula, mas nao eh permitida comunicacao entre os alunos e alunas, nem uso de celular durante a prova
	Plagio e cola implicarao na anulacao da nota dos alunos e alunas envolvidos
	
	ESPECIFICACAO
	
	A universidade positivo esta desenvolvendo uma API em C# para controlar a alocacao de quioesques nos blocos do campus ecoville
	As entidades do sistema sao "Quioesque", "Bloco" e "Alocacao"
	Soh existe um bloco de cada cor e soh um quiosque por empresa, portanto podemos usar cor e empresa como "chaves primarias"
	Os tipos de alimento servidos pelos quiosques sao "Salgado", "Doce" ou "Bebida"
	Os horarios de funcionamento dos blocos e quiosques sao "Manha", "Noite" ou "Ambos"
	A universidade fez uma pesquisa em cada bloco registrando qual tipo de alimento eh preferido pela maioria dos discentes daquele bloco
	Os blocos e quoisques foram cadastrados na funcao Main
	Falta implementar a funcao que aloca os quioesques nos blocos e mais algumas funcoes complementares
	O que cada funcao faz esta escrito no comentario acima dela
	As alocacoes devem cumprir as regras especificadas no comentario da funcao de alocacao
	
	DICAS
	
	Comece olhando quais sao os atributos de cada classe e os tipos deles
	Depois va para a funcao Main entender o que esta sendo feito la
	Por fim va para a classe controle ver quais funcoes devem ser implementadas (sao as marcadas com "TODO")
	
	Boa sorte! Nao tenha medo! De o seu melhor que o professor vai ser generoso na correcao. No comeco eh dificil, mas você consegue! \o/
*/

/*
	<ESCREVA AQUI SEU NOME COMPLETO - ALEXANDRE PHILIPPUS NETO>
	<ESCREVA AQUI O HORARIO DA SUA TURMA - QUINTA, NOITE>
*/

using System;
using System.Collections.Generic;

namespace Prova
{
	class Quiosque
	{
		public string Empresa;
		public bool   ServeBebida;
		public bool   ServeSalgado;
		public bool   ServeDoce;
		public string Horario;
		
		public Quiosque(string empresa, bool serveBebida, bool serveSalgado, bool serveDoce, string horario)
		{
			Empresa      = empresa;
			ServeBebida  = serveBebida;
			ServeSalgado = serveSalgado;
			ServeDoce    = serveDoce;
			Horario      = horario;
		}
	}
	
	class Bloco
	{
		public string Cor;
		public string AlimentoPreferido;
		public string Horario;
		public int    NumeroQuiosques;
		
		public Bloco(string cor, string alimentoPreferido, string horario)
		{
			Cor               = cor;
			AlimentoPreferido = alimentoPreferido;
			Horario           = horario;
			NumeroQuiosques   = 0;
		}
	}
	
	class Alocacao
	{
		public string EmpresaQuiosque;
		public string CorBloco;
		
		public Alocacao(string empresaQuiosque, string corBloco)
		{
			EmpresaQuiosque = empresaQuiosque;
			CorBloco        = corBloco;
		}
	}
	
	class Controle
	{
		public List<Quiosque> Quiosques;
		public List<Bloco>    Blocos;
		public List<Alocacao> Alocacoes;
		
		public Controle()
		{
			Quiosques = new List<Quiosque>();
			Blocos    = new List<Bloco>();
			Alocacoes = new List<Alocacao>();
		}
		
		//(0.5 pontos)
		//retorna numero de quiosques que abrem apenas a noite
		public int GetNumeroQuiosquesApenasNoite()
		{
			int numeroQuiosquesApenasNoite = 0;
			
			foreach (var q in Quiosques)
			{
				if (q.Horario == "Noite" || q.Horario == "Ambos")
					numeroQuiosquesApenasNoite++;
			}	// Fim foreach
			
			return numeroQuiosquesApenasNoite;
		}	// Fim GetNumeroQuiosquesApenasNoite
		
		//(0.5 pontos)
		//retorna string com os nomes dos quiosques (separados por virgula) que servem salgados pela manha
		public string GetEmpresasSalgadoManha()
		{
			string empresasSalgadoManha = "";
			
			foreach (var q in Quiosques)
			{
				if (q.Horario == "Ambos" || q.Horario == "Manha")
					if ( q.ServeSalgado == true )
						empresasSalgadoManha += q.Empresa + ", ";
			}	// Fim foreach

			empresasSalgadoManha = empresasSalgadoManha.Remove(empresasSalgadoManha.Length -2);
			return empresasSalgadoManha += ".";
		}	// Fim GetEmpresasSalgadoManha
		
		//(1 ponto)
		//retorna o tipo de alimento que foi o mais escolhido como o preferido dentre todos os blocos
		public string GetAlimentoMaisPreferido()
		{
			string alimentoMaisPreferido = "";

			// ID de cada alimento
			int [] alimentos = new int [3] {0, 0, 0};

			// Pegando as escolhas
			foreach (var b in Blocos)
			{
				switch (b.AlimentoPreferido)
				{
					case "Salgado":
						alimentos[0] ++;
						break;
					case "Doce":
						alimentos[1] ++;
						break;
					case "Bebida":
						alimentos[2] ++;
						break;
				}	// Fim switch
			}	// Fim foreach

			// Vendo quem é o maior
			if (alimentos[0] > alimentos[1] && alimentos[0] > alimentos[2])
				alimentoMaisPreferido = "Salgado";
			else if (alimentos[1] > alimentos[0] && alimentos[1] > alimentos[2])
				alimentoMaisPreferido = "Doce";
			else
				alimentoMaisPreferido = "Bebida";

			
			return alimentoMaisPreferido;
		}	// Fim GetAlimentoMaisPreferido
		
		//(2 pontos)
		//aloca os quiosques nos blocos obedecendo as seguintes condicoes:
		//	- no maximo dois quiosques por bloco
		//	- o quiosque deve servir o alimento preferido do bloco
		//	- o bloco tem que estar aberto em todo horario de funcionamento do quiosque (mas nao tem problema se o quiosque estiver fechado em parte do horario do bloco)
		//	(se quiser, faca funcoes separadas pra testar cada uma dessas condicoes)
		//	(se nao conseguir testar a terceira condicao, tente alocar corretamente seguindo pelo menos as duas primeiras)
		//	(nao eh necessario lancar excecao caso algum quiosque nao possa ser alocado)
		public void AlocarTodoMundo()
		{
			foreach (var q in Quiosques)
			{
				// Pegando o alimento preferido e transformando para string \^o^/
				string alimento = "";
				if (q.ServeBebida)
					alimento = "Bebida";
				if (q.ServeDoce)
					alimento = "Doce";
				if (q.ServeSalgado)
					alimento = "Salgado";

				// Dando um oi para os blocos (・∀・)ノ
				foreach (var b in Blocos)
				{
					// Criando a verificação e var para a locação (⊙_⊙;)
					Alocacao aloc;
					if (b.NumeroQuiosques < 2 &&
						b.AlimentoPreferido == alimento && 
						b.Horario == q.Horario)
					{
						// Verificando se a empresa já está com uma locação
						b.NumeroQuiosques ++;
						int count = 0;
						foreach (var a in Alocacoes)
						{
							if (a.EmpresaQuiosque == q.Empresa)
								count ++;
						}	// Fim foreach
	
						// Alocando o bichin (╯°□°）╯︵ ┻━┻
						if (count == 0)
						{
							aloc = new Alocacao (q.Empresa, b.Cor);
							Alocacoes.Add(aloc);
						}	// Fim if
					}	// Fim if	
				}	// Fim foreach
			}	// Fim foreach
		}	// Fim AlocarTodoMundo
	}	// Fim GetAlimentoMaisPreferido
	
	class Program
	{
		static void Main(string[] args)
		{
			var controle = new Controle();
			
			controle.Quiosques.Add(new Quiosque("Bobs"        , true , true , false, "Manha"));
			controle.Quiosques.Add(new Quiosque("Burger King" , true , true , false, "Ambos"));
			controle.Quiosques.Add(new Quiosque("Cabra Café"  , true , false, false, "Manha"));
			controle.Quiosques.Add(new Quiosque("Cacau Show"  , false, false, true , "Noite"));
			controle.Quiosques.Add(new Quiosque("Freddo"      , false, false, true , "Manha"));
			controle.Quiosques.Add(new Quiosque("Giraffas"    , true , true , false, "Manha"));
			controle.Quiosques.Add(new Quiosque("McDonalds"   , true , true , false, "Ambos"));
			controle.Quiosques.Add(new Quiosque("Pizza Hut"   , false, true , false, "Noite"));
			controle.Quiosques.Add(new Quiosque("Ultra Coffee", true , false, true , "Ambos"));
			controle.Quiosques.Add(new Quiosque("Zuka"        , false, false, true , "Noite"));
			
			controle.Blocos.Add(new Bloco("Amarelo" , "Salgado", "Ambos"));
			controle.Blocos.Add(new Bloco("Azul"    , "Doce"   , "Noite"));
			controle.Blocos.Add(new Bloco("Bege"    , "Salgado", "Noite"));
			controle.Blocos.Add(new Bloco("Branco"  , "Salgado", "Manha"));
			controle.Blocos.Add(new Bloco("Cinza"   , "Doce"   , "Ambos"));
			controle.Blocos.Add(new Bloco("Laranja" , "Salgado", "Ambos"));
			controle.Blocos.Add(new Bloco("Marrom"  , "Salgado", "Manha"));
			controle.Blocos.Add(new Bloco("Verde"   , "Bebida" , "Manha"));
			controle.Blocos.Add(new Bloco("Vermelho", "Doce"   , "Manha"));
			controle.Blocos.Add(new Bloco("Roxo"    , "Bebida" , "Noite"));
			
			controle.AlocarTodoMundo();
			
			Console.WriteLine("O numero de quiosques que abrem apenas a noite eh: " + controle.GetNumeroQuiosquesApenasNoite());
			Console.WriteLine("Os quiosques que servem salgados pela manha sao: "   + controle.GetEmpresasSalgadoManha()      );
			Console.WriteLine("O tipo de alimento mais preferido pelos blocos eh: " + controle.GetAlimentoMaisPreferido()     );
			Console.WriteLine("Lista de alocacoes:");
			foreach(var alocacao in controle.Alocacoes)
			{
				Console.WriteLine($"O quiosque {alocacao.EmpresaQuiosque} foi alocado no bloco {alocacao.CorBloco}.");
			}
		}
	}
}
