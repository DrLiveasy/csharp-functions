// See https://aka.ms/new-console-template for more informationi












//-------------------Funzioni-------------------

void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");
    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i]);
        }
        else
        {
            Console.Write(arrayInteri[i] + " , ");
        }
    }
    Console.Write("]");

}