string frase, baleeis; //criado duas variáveis do tipo string

Console.WriteLine(); // Console.WriteLine() sem valor quebra a linha
Console.WriteLine("**/-- Imitando Dory --/**\n"); // cria um titulo

Console.WriteLine("Vamos ver como sua frase fica em Baleeis? Escreva uma frase\n"); // informa o que o programa irá fazer
frase = Console.ReadLine()!; // atribui um valor para a variável frase e aguarda o usuário digitar a frase.

baleeis = frase // atribui o valor frase para a variável baleeis
.Replace("a", "aaa") // replace troca o primeiro valor para o segundo
.Replace("A", "AAA")
.Replace("e", "eee")
.Replace("E", "EEE")
.Replace("i", "iii")
.Replace("I", "III")
.Replace("o", "ooo")
.Replace("O", "OOO")
.Replace("u", "uuu")
.Replace("U", "UUU");

Console.WriteLine();// Console.WriteLine() sem valor quebra a linha
Console.WriteLine("Sua frase em Baleeis ficou assim:\n"); // passa uma informação
Console.WriteLine(baleeis); // resultado da variável balleis. 