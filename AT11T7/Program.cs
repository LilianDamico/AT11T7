//Inicio
using System.Runtime.Serialization;
int soma = 0;
int media, nota = 0;
int i;
do
{
    for(i = 0; i < 4; i++)
    {
        Console.Write("Informe a nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
        soma = soma + nota;
    }    
    media = soma / 4;
} while(nota<0 || nota>10);
Console.WriteLine("A média final foi: " + media);
Console.ReadKey();





//Olha do que me livrei...
//Console.WriteLine("Informe a primeira nota: ");
//n1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Informe a segunda nota: ");
//n2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Informe a terceira nota: ");
//n3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Informe a quarta nota: ");
//n4 = Convert.ToInt32(Console.ReadLine());
//media = (n1 + n2 + n3 + n4) / 4;
//Fim