/*Ex-if-else-elseif:
1. Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários 
quando for hora de reabastecer um produto. 
Escreva um código que verifique a quantidade de um produto em estoque. Se a 
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor, 
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente.". */
int escolha, p1 = 5, p2 = 2, p3 = 12, p4 = 13, p5 = 14;
Console.Write("____________________________________________\n" +
    "1.Calça.\n" +
    "2.Saia\n" +
    "3.Vestido\n"+
    "4.Shorts\n"+
    "4.Bermuda\n"+
    "5.Blusa\n"+
    "Escolha:");
escolha = Convert.ToInt32(Console.ReadLine());   
switch (escolha)
{
    case 1:
        {
            if (p1 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");

            else
                Console.WriteLine($"Quantidade: {p1}\nEstoque suficiente.\n");
        }
        break;
    case 2:
        {
            if (p2 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");

            else
                Console.WriteLine($"Quantidade: {p2}\nEstoque suficiente.\n");
        }
        break;
    case 3:
        {
            if (p3 < 5)
                Console.Write("Alerta: Estoque Baixo.\nReabasteça esse produto.\n");

            else
                Console.WriteLine($"Quantidade: {p3}\nEstoque suficiente.\n");

        }
        break;
        case 4:
        {
            Console.WriteLine($"Quantidade: {p4}\nEstoque suficiente.");
        }
        break;
        case 5:
        {
            Console.WriteLine($"Quantidade: {p5}\nEstoque suficiente.");
        }
        break;
    default: { Console.WriteLine("Valor Inválido\n"); }break;
} //feito
/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte 
de uma promoção de vendas. Escreva um código que determine o valor total da 
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um 
desconto de 10% e exiba: "Desconto de 10% aplicado!". Se o valor total for R$ 
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um 
desconto de 10%.". */
/*Ex-switch:
1. Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana, 
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 = 
"Segunda-feira", etc.).*/
int diadasemana = 7;
switch (diadasemana)
{
    case 7:
        Console.WriteLine("Domingo.");
        break;
        case 6:
        Console.WriteLine("Sábado.");
        break;
        case 5:
        Console.WriteLine("Sexta.");
        break; 
    case 4:
        Console.WriteLine("Quinta.");
        break; case 3:
        Console.WriteLine("Quarta.");
        break; case 2:
        Console.WriteLine("Terça.");
       break; 
        case 1:
        Console.WriteLine("Segunda.");
       break;    
}
/*2. Faça um programa que calcule o preço final de um produto com base em um 
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto 
correspondente ao preço do produto.
o Código 1: 10% de desconto
o Código 2: 20% de desconto
o Código 3: 30% de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro.*/
/*Ex-for:
1. Faça um programa de tabuada de multiplicação 
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de 
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número 
pelos valores de 1 a 10.*/
/*2. Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses 
números. Utilize o laço for para ler os números e calcular a média.*/
/*Ex-while:
1. Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no 
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar" 
cada visitante até que a capacidade máxima seja atingida. A cada visitante 
adicional, exiba o número total de visitantes até o momento.*/
/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo 
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O 
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha 
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de 
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas."*/