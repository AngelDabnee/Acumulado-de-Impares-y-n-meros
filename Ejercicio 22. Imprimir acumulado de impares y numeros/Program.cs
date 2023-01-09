// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//22.Con un ciclo permite al usuario capturar 10 números,
//cada vez que el número es impar, lo ACUMULAS en una variable.
//Imprime los números y el acumulado de impares al final.
Console.WriteLine("En este programa, acumularemos los números impares que captures para así sumarlos e imprimirte el resultado, Inicia.");
//Datos de entrada
int[] numeros = new int[10];
int impares = 0;
//Proceso
for (int i = 0; i < numeros.Length; i++)//Ciclo para capturar los 10 números
{
    Console.WriteLine("Captura algún número No. " + (i + 1));
    numeros[i] = int.Parse(Console.ReadLine());
    if (numeros[i] % 2 != 0)//Se utiliza esta operación porque cualquier número impar no es 0 en su residuo
    {
        impares = impares + numeros[i];//Acumulamos los números. 
    }
}
Console.WriteLine($"La suma de los números impares que capturaste es {impares}");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);//Imprimiremos los números capturados por el usuario. 
}