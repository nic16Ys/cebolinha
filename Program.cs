// See https://aka.ms/new-console-template for more information
Console.WriteLine("DIGITE UMA FRASE : ");
string frase = Console.ReadLine();
string frasec = frase 
.Replace ("r" , "l") 
.Replace ("R" , "L") ;

Console.WriteLine(frasec);
