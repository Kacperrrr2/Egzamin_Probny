using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        /**
         * <Najlpeszy czas>
         * <Liczy najmniejsza czas w przedzial  w podanej ilosci kilometrow>
         * Parametry wejściowe:
         * <wielksoc> - przedial kilometrow>
         * <czasy> - <czasy przebiegane w kazdym kilometerze>
         * ...
         * wartość zwracana:
         * <opis zwraca najmniejszy czas w przedziale w podanej ilosci kilometrow>
         * autor: Kacper Petelicki>
         **/
        int NajlepszyCzas(int wielkość, int[]czasy)
        {
            int suma = 0;
            int maxSuma = int.MaxValue;
            for (int i = 0; i < czasy.Length; i++)
            {
                suma = 0;
                for (int j = 0; j < wielkość;j++)
                {
                    if (czasy.Length <= (i + j))
                    {
                        suma = maxSuma;

                    }
                    else
                    {

                        suma += czasy[i + j];
                    } 

                
                }
                if (suma < maxSuma)
                {
                    maxSuma = suma;
                }
            }
            return maxSuma;
        }
        static void Main(string[] args)
        {
            Program program = new Program();    
            Console.WriteLine("Ile kilometrów przebiegłeś");
            if(int.TryParse(Console.ReadLine(), out int km))
            {
                int[]czasy = new int[km];
                Console.WriteLine("Podaj czasy na każdym kilometrze: ");
                for (global::System.Int32 i = 0; i < czasy.Length; i++)
                {
                    czasy[i] = int.Parse(Console.ReadLine());
                }
               
                Console.WriteLine("Podaj jakiej wielkości najlepszego odcinka szukasz (w km): ");
                if (int.TryParse(Console.ReadLine(),out int wielkość))
                {
                    Console.WriteLine(program.NajlepszyCzas(wielkość,czasy).ToString());
                }
                
                {
                    
                }
            }
            else
            {
                Console.WriteLine("Błąd");
                return; 
            }
        }
    }
}
