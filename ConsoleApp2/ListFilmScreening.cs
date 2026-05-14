using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp2
{
    public class ListFilmScreening
    {
        public List<FilmScreening> ListFilmScreenin = new List<FilmScreening>();
        public ListFilmScreening() { }
        public ListFilmScreening(List<FilmScreening> listFilmScreenin)
        {
            this.ListFilmScreenin = listFilmScreenin;
        }
        public void PrintList()
        {
            foreach (var film in ListFilmScreenin)
            {
                Console.Write("#) ");
                film.Info();
                Console.WriteLine();
            }
        }
        public void AddToList(FilmScreening listFilmScreening_) 
        {
            ListFilmScreenin.Add(listFilmScreening_);
        }
        public void AddManualToList() 
        {
            string tempNameFilm, tempZal, tempDataTime, tempTimeTime;
            int tempNumberSeats;
            decimal tempTicketBill;

            Console.WriteLine("Введите название для фильма: ");
            tempNameFilm = Console.ReadLine().ToString();
            Console.WriteLine("Введите зал показа: ");
            tempZal = Console.ReadLine().ToString();
            Console.WriteLine("Введите Год Месяц и день через '.': ");
            tempDataTime = Console.ReadLine().ToString();
            Console.WriteLine("Введите время показа через ':': ");
            tempTimeTime = Console.ReadLine().ToString();
            Console.WriteLine("Введите Кол-Во мест: ");
            tempNumberSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Цену на билет: ");
            tempTicketBill = Convert.ToDecimal(Console.ReadLine());

            FilmScreening temp = new FilmScreening(tempNameFilm, tempZal, tempDataTime, tempTimeTime, tempNumberSeats, tempTicketBill);
            this.AddToList(temp);
        }
        public void SortByTitleLength()
        {
            for (int i = 0; i < ListFilmScreenin.Count - 1; i++)
            {
                for (int j = 0; j < ListFilmScreenin.Count - 1 - i; j++)
                {
                    if (ListFilmScreenin[j].nameFilm.Length > ListFilmScreenin[j + 1].nameFilm.Length)
                    {
                        var temp = ListFilmScreenin[j];
                        ListFilmScreenin[j] = ListFilmScreenin[j + 1];
                        ListFilmScreenin[j + 1] = temp;
                    }
                }
            }
        }
        public void Removee(string title, string date, string time)
        {
            for (int i = 0; i < ListFilmScreenin.Count; i++)
            {
                if (ListFilmScreenin[i].nameFilm == title &&
                    ListFilmScreenin[i].dataTime == date &&
                    ListFilmScreenin[i].timeTime == time)
                {
                    ListFilmScreenin.RemoveAt(i);
                }
            }
        }
    }
}
