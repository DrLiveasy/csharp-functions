// See https://aka.ms/new-console-template for more informationi

int[] ArrayNumeri = { 2, 6, 7, 5, 3, 9};

/*
int[] ArrayAlQuadrato = ElevaArrayAlQuadrato(ArrayNumeri);
StampaArrayInteri(ArrayAlQuadrato);
*/

StampaArrayInteri(ArrayNumeri);
StampaArrayInteri(ElevaArrayAlQuadrato(ArrayNumeri));
StampaArrayInteri(ArrayNumeri);
Console.WriteLine(sommaElementiArray(ArrayNumeri));
Console.WriteLine(
    Quadrato(
        sommaElementiArray(ArrayNumeri)
        )
    );








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
    Console.WriteLine("]");

    //Console.Write("[");
    //for (int i = 0; i < ElevaArrayAlQuadrato(array).Length; i++)
    //{
    //    if (i == array.Length - 1)
    //    {
    //        Console.Write(ElevaArrayAlQuadrato(array)[i]);
    //    }
    //    else
    //    {
    //        Console.Write(ElevaArrayAlQuadrato(array)[i] + " , ");
    //    }
    //}
    //Console.WriteLine("]");

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
int[] ElevaArrayAlQuadrato(int[] array1)
{
    int[] ArrayQuadrato = (int[])array1.Clone();
    for (int i = 0; i < ArrayQuadrato.Length; i++)
    {
        ArrayQuadrato[i] = (ArrayQuadrato[i] * ArrayQuadrato[i]);   

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