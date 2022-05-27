using System;

namespace gameboy
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp,odp2;
            do
            {
             Console.WriteLine("Witaj w gameboy'u! W jaką grę chcesz dziś zagrać? ");
             Console.WriteLine("Kostki/Zgadywanka/TotoLotek/Kalkulator");
             odp=Console.ReadLine();
                if(odp=="Kostki")
             {
                gameKostki();
             }
             else if(odp=="Zgadywanka")
             {
                gameZgadywanka();
             }
             else if(odp=="TotoLotek")
             {
                 totoLotek();
             }
             
             Console.WriteLine("Chcesz zagrać w kolejną grę? (tak/nie) ");
             odp2=Console.ReadLine();

            }while(odp2=="tak");
            


        }
        static void gameKostki()
        {
            int runds;
            int playerRandom;
            int enemyRandom;
            int playerPoints=0;
            int enemyPoints=0;
            string odp;
         do{
             Console.WriteLine("Ile rund chcesz zagrać? ");
             runds=Convert.ToInt32(Console.ReadLine());
             for(int i=0;i<runds;i++)
             {
              Console.WriteLine("Naciśnij spacje aby rzucić. ");
              Console.ReadKey();
              Random rnd=new Random();
              playerRandom=rnd.Next(1,6);
              Console.WriteLine("Wyrzuciłeś "+playerRandom);
              
              Console.WriteLine("...");
              System.Threading.Thread.Sleep(1000); 

             enemyRandom=rnd.Next(1,6);
             Console.WriteLine("Przeciwnik wyrzucił "+enemyRandom);
             if(playerRandom>enemyRandom)
             {
                 playerPoints++;
             }
             else if(playerRandom<enemyRandom)
             {
                 enemyPoints++;
             }
             else
             {
                 playerPoints++;
                 enemyPoints++;
              }
              
             }
             Console.WriteLine("Koniec! Rundy przeciwnika: {0}, Twoje Rundy:  {1}.",enemyPoints,playerPoints);
             if(playerPoints>enemyPoints)
             {
                 Console.WriteLine("Wygrałeś! ");
             }
             else if(enemyPoints>playerPoints)
             {
                 Console.WriteLine("Przegrałeś! ");
             }
             else
             {
                 Console.WriteLine("Remis! ");
             }
             
             Console.WriteLine("Gramy dalej? (tak/nie) ");
             odp=Console.ReadLine();
            } while(odp=="tak");
        }
        static void gameZgadywanka()
        {
            const int start=1;
            const int end=200;
            int a,b;
            string answ;
            do
            {
                Random rnd=new Random();
                a=rnd.Next(start,end+1);
                do
                {
                    Console.WriteLine("Spróbuj zgadnąć liczbę z przedziału <{0}, {1}> ",start,end);
                    b=Convert.ToInt32(Console.ReadLine());
                    if(b<a)
                    {
                        Console.WriteLine("Pudło! Za mało! ");
                    }
                     if(b>a)
                    {
                        Console.WriteLine("Pudło! Za duzo! ");
                    }
                }while(b!=a);
                Console.WriteLine("Brawo! Zgadłeś! Wylosowana liczba: {0} ",a);
                Console.WriteLine("Czy chcesz grać dalej? (tak/nie) ");
                answ=Console.ReadLine();
            }while(answ=="tak");

        }
        static void totoLotek()
        {
            string odp;
            do
            {
                int[] numery = new int[6];

             Random generator = new Random();
             int index = 0;
             bool losujKolejne;
             do
             {
                numery[index] = generator.Next(1, 50);
                losujKolejne = true;
                for (int i = 0; i < index; i++)
                {
                    if (numery[index] == numery[i])
                    {
                        losujKolejne = false;
                        break;
                    }
                }
                if (losujKolejne)
                {
                    index++;
                }
             } while (index < numery.Length);

             Console.WriteLine("Wylosowane liczby to: ");

             foreach(int numer in numery)
             {
                Console.Write(numer + ", ");
             }
             Console.WriteLine("Czy chcesz grać dalej? (tak/nie) ");
             odp=Console.ReadLine();
            }while(odp=="tak");
        }
        
    }
}
