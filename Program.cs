using DesafioPOO.Models;

//  Testes em ambos as classes realizado, agindo como esperado.

Console.WriteLine("Smartphone Nokia");

Nokia celularNokia = new Nokia("4758-1245", "X30", "449279095666730", 4096);

celularNokia.Ligar();
celularNokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");
Console.WriteLine("Smartphone iPhone");

Iphone celularIphone = new Iphone("4457-9543", "iPhone 11", "353995102427923", 4096);

celularIphone.ReceberLigacao();
celularIphone.InstalarAplicativo("Facebook");
