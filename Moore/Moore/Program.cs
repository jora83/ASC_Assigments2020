using System;
/*
 *Putem afla  dupa cat timp vom avea o putere de calcul de 100 de ori mai mare decat cea in momentul actual
 *cu ajutorul legii lui Moore care spune ca: puterea de calcul a procesoarelor se dubleaza la fiecare
 * 18 luni iar pretul ramane acelasi. Pentru a calcula timpul in care puterea de procesare v-a fi de 100 de
 * ori mai mare ne vom folosi de functia logartimica
 */
namespace Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            double timp = Math.Log(100, 2) * 1.5;

            Console.Write("Puterea de calcul a procesoarelor v-a fi de 100 de ori mai mare in {0} ani", timp);
        }
    }
}