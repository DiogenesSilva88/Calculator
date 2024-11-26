using System;

Menu();

void Menu()
{
	// Limpa o console para uma melhor visualização
	Console.Clear();

	// Exibe as opções disponíveis para o usuário
	Console.WriteLine("O que deseja fazer?");
	Console.WriteLine("1 - Soma");
	Console.WriteLine("2 - Subtração");
	Console.WriteLine("3 - Divisão");
	Console.WriteLine("4 - Multiplicação");
	Console.WriteLine("5 - Sair");

	Console.WriteLine("----------");
	Console.WriteLine("Selecione uma opção: ");

	// Lê a entrada do usuário e tenta convertê-la para um short
	if (short.TryParse(Console.ReadLine(), out short res))
	{
		// Executa a função correspondente à opção escolhida
		switch (res)
		{
			case 1: Soma(); break;              // Chama a função Soma
			case 2: Subtracao(); break;         // Chama a função Subtracao
			case 3: Divisao(); break;           // Chama a função Divisao
			case 4: Multiplicacao(); break;     // Chama a função Multiplicacao
			case 5: Environment.Exit(0); break; // Encerra o programa
			default: Menu(); break;              // Se a opção for inválida, exibe o menu novamente
		}
	}
	else
	{
		// Mensagem de erro para entrada inválida
		Console.WriteLine("Opção inválida! Tente novamente.");
		Menu(); // Exibe o menu novamente
	}
}

void Soma()
{
	// Limpa o console antes de executar a operação
	Console.Clear();

	// Lê os valores do usuário utilizando a função LerValor
	float v1 = LerValor("Primeiro valor: ");
	float v2 = LerValor("Segundo valor: ");

	// Realiza a soma dos valores
	float resultado = v1 + v2;

	// Exibe o resultado da soma
	Console.WriteLine($"O resultado da soma é {resultado}");
	Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
	Menu(); // Retorna ao menu principal
}

void Subtracao()
{
	// Limpa o console antes de executar a operação
	Console.Clear();

	// Lê os valores do usuário utilizando a função LerValor
	float v1 = LerValor("Primeiro valor: ");
	float v2 = LerValor("Segundo valor: ");

	// Realiza a subtração dos valores
	float resultado = v1 - v2;

	// Exibe o resultado da subtração
	Console.WriteLine($"O resultado da subtração é {resultado}");
	Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
	Menu(); // Retorna ao menu principal
}

void Divisao()
{
	// Limpa o console antes de executar a operação
	Console.Clear();

	// Lê os valores do usuário utilizando a função LerValor
	float v1 = LerValor("Primeiro valor: ");
	float v2 = LerValor("Segundo valor: ");

	// Verifica se o segundo valor é zero para evitar divisão por zero
	if (v2 == 0)
	{
		Console.WriteLine("Erro: Divisão por zero não é permitida.");
		Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
		Menu(); // Retorna ao menu principal
		return; // Encerra a função
	}

	// Realiza a divisão dos valores
	float resultado = v1 / v2;

	// Exibe o resultado da divisão
	Console.WriteLine($"O resultado da divisão é {resultado}");
	Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
	Menu(); // Retorna ao menu principal
}

void Multiplicacao()
{
	// Limpa o console antes de executar a operação
	Console.Clear();

	// Lê os valores do usuário utilizando a função LerValor
	float v1 = LerValor("Primeiro valor: ");
	float v2 = LerValor("Segundo valor: ");

	// Realiza a multiplicação dos valores
	float resultado = v1 * v2;

	// Exibe o resultado da multiplicação
	Console.WriteLine($"O resultado da multiplicação é {resultado}");
	Console.ReadKey(); // Aguarda o usuário pressionar uma tecla
	Menu(); // Retorna ao menu principal
}

// Função para ler um valor do usuário com validação
float LerValor(string mensagem)
{
	float valor; // Declaração da variável para armazenar o valor lido

	while (true) // Loop infinito até que um valor válido seja inserido
	{
		Console.WriteLine(mensagem); // Exibe a mensagem solicitando o valor
		string entrada = Console.ReadLine(); // Lê a entrada do usuário

		// Verifica se a entrada não é nula ou vazia
		if (string.IsNullOrWhiteSpace(entrada))
		{
			Console.WriteLine("Entrada não pode ser vazia! Por favor, digite um número válido.");
			continue; // Retorna ao início do loop para solicitar nova entrada
		}

		// Tenta converter a entrada para um float
		if (float.TryParse(entrada, out valor))
		{
			return valor; // Retorna o valor válido
		}
		else
		{
			// Mensagem de erro para valor inválido
			Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
		}
	}
}
