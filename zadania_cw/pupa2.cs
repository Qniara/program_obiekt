using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pob_cw_pupciasne
{
    internal class Program
    {
        //funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę - CreateArray()
        static void CreateArray()
        {
            int size = int.Parse(Console.ReadLine());

        }
        //funkcja statyczna, która ustawia elementy tablicy SetArray()

        //funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
        static void Main(string[] args)
        {

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy.Następnie program
            //wyświetla sumę wszystkich elementów tablicy. W celu zabezpieczenia programu przed niepoprawnymi danymi
            //wejściowymi, użyliśmy metody int.TryParse(), która pozwala na sprawdzenie, czy wprowadzona wartość jest
            //liczbą całkowitą.Jeśli użytkownik wprowadzi niepoprawną wartość, program wyświetli stosowny komunikat i
            //poprosi o ponowne wprowadzenie liczby.

            //Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla
            //sumę wszystkich elementów tablicy.Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers. Użyj pętli for, aby
            //pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers. Wyświetl na ekranie komunikat, który
            //prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i
            //zweryfikować. Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca
            //ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne
            //wprowadzenie liczby. Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą
            //całkowitą i przypisać ją do zmiennej input. Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje
            //tablicę liczb całkowitych i zwraca ich sumę. Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers
            //i zwrócić sumę. Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum. Wyświetl na ekranie
            //komunikat, który pokazuje sumę podanych liczb.
            //int GetIntegerFromUser()
        }
    }
}
