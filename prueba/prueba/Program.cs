//Menu
string problema = "";
bool continuar = true;
do
{
    Console.WriteLine("Seleccion de problema: ");
    Console.WriteLine("(1) Calculadora de sumas y restas en binario, decimal y hexadecimal ");
    Console.WriteLine("(2) Contador de vocales en una cadena ");
    Console.WriteLine("(3) Sumadora factorial ");
    Console.WriteLine("(4) Repartidor de porciones ");
    Console.WriteLine("(0) Salir ");
    problema = Console.ReadLine();
    Console.Clear();
    switch (problema)
    {
        case "1":
            Console.WriteLine("Problema 1: ");
            Problema1();
            break;
        case "2":
            Console.WriteLine("Problema 1: ");
            Problema2();
            break;
        case "3":
            Console.WriteLine("Problema 1: ");
            Problema3();
            break;
        case "4":
            Console.WriteLine("Problema 1: ");
            Problema4();
            break;
        case "0":
            Console.WriteLine("Salir ");
            continuar = false;
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (continuar);

// problema 1
void Problema1()
{
    string baseNum = "";
    bool suma = true;
    int num1, num2, resSuma, resResta;
    num1 = 0;
    num2 = 0;
    resSuma = 0;
    resResta = 0;
    string num1str, num2str;

    Console.WriteLine("Desea Sumar o Restar:");
    Console.WriteLine("(1) Suma ");
    Console.WriteLine("(2) Resta ");
    string sumastr = Console.ReadLine();
    suma = sumastr == "1" ? true : false;

    Console.WriteLine("Ingrese base: ");
    Console.WriteLine("(1) Decimal ");
    Console.WriteLine("(2) Binario ");
    Console.WriteLine("(3) Hexdecimal ");

    baseNum = Console.ReadLine();
    Console.WriteLine("Ingrese primer número: ");
    num1str = Console.ReadLine();
    Console.WriteLine("Ingrese segundo número: ");
    num2str = Console.ReadLine();
    Console.WriteLine("--------------------------");
    Console.WriteLine("Resultado: ");
    switch (baseNum)
    {
        case "1":
            num1 = Convert.ToInt32(num1str, 10);
            num2 = Convert.ToInt32(num2str, 10);
            break;
        case "2":
            num1 = Convert.ToInt32(num1str, 2);
            num2 = Convert.ToInt32(num2str, 2);
            break;
        case "3":
            num1 = Convert.ToInt32(num1str, 16);
            num2 = Convert.ToInt32(num2str, 16);
            break;
    }

    resSuma = num1 + num2;
    resResta = num1 - num2;

    if (suma)
    {
        Console.WriteLine("Binario: " + Convert.ToString(resSuma, 2));
        Console.WriteLine("Decimal: " + Convert.ToString(resSuma, 10));
        Console.WriteLine("Haxadecimal: " + Convert.ToString(resSuma, 16));
    }
    else
    {
        Console.WriteLine("Binario: " + Convert.ToString(resResta, 2));
        Console.WriteLine("Decimal: " + Convert.ToString(resResta, 10));
        Console.WriteLine("Haxadecimal: " + Convert.ToString(resResta, 16));
    }

}

// problema 2
void Problema2()
{
    Console.WriteLine("Ingrese una cadena: ");
    string inputVocales = "";
    inputVocales = Console.ReadLine();
    inputVocales = inputVocales.ToLower();

    char[] inputCH = inputVocales.ToCharArray();
    int counter = 0;

    foreach (var item in inputCH)
    {
        switch (item)
        {
            case 'a':
                counter++;
                break;
            case 'e':
                counter++;
                break;
            case 'i':
                counter++;
                break;
            case 'o':
                counter++;
                break;
            case 'u':
                counter++;
                break;
        }
    }
    Console.WriteLine("--------------------------");
    Console.WriteLine("Cantidad vocales: " + counter);
}

// problema 3
void Problema3()
{
    Console.WriteLine("Ingrese numero para calcular factorial");
    int x = Convert.ToInt32(Console.ReadLine());
    int resultado = 1;
    while (x > 0)
    {
        resultado *= x;
        x--;
    }
    Console.WriteLine("--------------------------");
    Console.WriteLine("Resultado: " + resultado);
}

// problema 4
void Problema4()
{
    Console.WriteLine("Ingrese numero de amigos");
    int numAmigos = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese numero de porciones por amigo");
    int numPorciones = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("--------------------------");
    int resultado4 = (int)Math.Ceiling(((double)numAmigos * (double)numPorciones) / 4);
    Console.WriteLine("Se necesitan {0} pasteles", resultado4);
}


Console.ReadKey();