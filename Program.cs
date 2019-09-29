using System;

namespace Godisautomaten
{
    class Program
    {
        /*
        Skapa ett program för en godisautomat. I godisautomaten finns det ett antal godisar per sort.
        Som användare får man skriva in ett nummer på luckan ur vilken man vill köpa godis. 
        Varje gång man köper en godis minskar antalet av just den godistypen. 
        Användaren får fortsätta köpa godis så länge hen vill. Det kan aldrig bli färre än 0 godisar i en lucka.
        Blir det färre får användaren ett meddelande om att godiset är slut.
        Här är ett exempel på hur menyn kan se ut:
        LUCKA NR 1: Japp antal 3st LUCKA NR 2: Daim antal 5st LUCKA NR 3: Marabou antal 5st
        LUCKA NR 4: Pigall antal 4st Vilken godis vill du ha? (q för att avlusta): 1 
        får en Japp, mums! Tryck på valfri tangent för att köpa mer godis 
        (Här ska skärmen tömmas och menyn visas igen med rätt antal)
         */

        static void Main(string[] args)
        {

        //Godis saldo deklareras utan för loop, för att kunna räkna ner till saldo 0.
        int japp = 5;
        int daim = 5;
        int bounty = 5;
        int pigall = 5;

        while(true)
        {
        System.Console.WriteLine("Lucka nr [1] | Japp, antal = {0} ", japp);
        System.Console.WriteLine("Lucka nr [2] | Daim, antal = {0} ", daim);
        System.Console.WriteLine("Lucka nr [3] | Bounty, antal = {0} ", bounty);
        System.Console.WriteLine("Lucka nr [4] | Pigall, antal = {0} ", pigall);
        System.Console.WriteLine("[A]vsluta");
        System.Console.Write("Välj en lucka i godisautomaten:");

        string menyval = Console.ReadLine();
        switch(menyval)
        {
            //När saldo når 0, godis slut.
            //Annars räkna ner för varje val av godis sort.
            //Readkey() väntar på att man trycker på en tangent innan program fortsätter.

            case "1":
            if(japp == 0)
            {
                System.Console.WriteLine("*************");
                System.Console.WriteLine("*Godis slut!*");
                System.Console.WriteLine("*************");
                System.Console.WriteLine("Tryck på valfri knapp för att köpa något annat godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                japp--;
                System.Console.WriteLine("****************");
                System.Console.WriteLine("*Gott, en japp!*");
                System.Console.WriteLine("****************");
                System.Console.WriteLine("Tryck på valfri knapp för att fortsätta köpa godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            case "2":
            if(daim == 0)
            {
                System.Console.WriteLine("*************");
                System.Console.WriteLine("*Godis slut!*");
                System.Console.WriteLine("*************");
                System.Console.WriteLine("Tryck på valfri knapp för att köpa något annat godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                daim--;
                System.Console.WriteLine("****************");
                System.Console.WriteLine("*Gott, en Daim!*");
                System.Console.WriteLine("****************");
                System.Console.WriteLine("Tryck på valfri knapp för att fortsätta köpa godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            case "3":
            if(bounty== 0)
            {
                System.Console.WriteLine("*************");
                System.Console.WriteLine("*Godis slut!*");
                System.Console.WriteLine("*************");
                System.Console.WriteLine("Tryck på valfri knapp för att köpa något annat godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                bounty--;
                System.Console.WriteLine("******************");
                System.Console.WriteLine("*Gott, en Bounty!*");
                System.Console.WriteLine("******************");
                System.Console.WriteLine("Tryck på valfri knapp för att fortsätta köpa godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            case "4":
            if(pigall== 0)
            {
                System.Console.WriteLine("*************");
                System.Console.WriteLine("*Godis slut!*");
                System.Console.WriteLine("*************");
                System.Console.WriteLine("Tryck på valfri knapp för att köpa något annat godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            else
            {
                pigall--;
                System.Console.WriteLine("******************");
                System.Console.WriteLine("*Gott, en Pigall!*");
                System.Console.WriteLine("******************");
                System.Console.WriteLine("Tryck på valfri knapp för att fortsätta köpa godis.");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            case "a":
            case "A":
            System.Console.WriteLine("Godisautomaten avslutad!");
            return;

            //default fångar upp om man inte skriver in ett giltigt alterntiv till godisautomaten.    
            default:
            System.Console.WriteLine("************************************");
            System.Console.WriteLine("* Du måste välja mellan lucka 1-4  *");
            System.Console.WriteLine("************************************");

            break;
            }
        
        }


            
        }
    }
}
