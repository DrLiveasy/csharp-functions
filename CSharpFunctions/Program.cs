// See https://aka.ms/new-console-template for more informationi












//-------------------Funzioni-------------------


//preso un array di numeri interi, stampa a video
//il contenuto dell’array in questa forma
//“[elemento 1, elemento 2, elemento 3, ...]”.
void StampaArrayInteri(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + " , ");
        }
    }
    Console.Write("]");

}
//restituisca il quadrato del numero passato
//come parametro.
int Quadrato(int numero)
{
    numero = numero * numero;

    return numero;
}
//preso un array di numeri interi, restituisca un
//nuovo array con tutti gli elementi elevati quadrato.
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] ArrayQuadrato = (int[])array.Clone();
    for (int i = 0; i < ArrayQuadrato.Length; i++)
    {
        ArrayQuadrato[i] = ArrayQuadrato[i] * ArrayQuadrato[i];

    }
    return ArrayQuadrato;
}
//preso un array di numeri interi, restituisca
//la somma totale di tutti gli elementi dell’array.
int sommaElementiArray(int[] array)
{
    int somma = 0;
    foreach (int i in array)
    {
        somma += i;
    }

    return somma;
}