using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    public struct FilmScreening
    {
        public string nameFilm { get; set; }
        public string zal;
        public string dataTime;
        public string timeTime;
        public int numberSeats;
        public decimal ticketBill;

        public FilmScreening(string nameFilm, string zal, string dataTime, string timeTime, int numberSeats, decimal ticketBill)
        {
            this.nameFilm = nameFilm;
            this.zal = zal;
            this.dataTime = dataTime;
            this.timeTime = timeTime;
            this.numberSeats = numberSeats;
            this.ticketBill = ticketBill;
        }
        public void Info()
        {
            Console.WriteLine($"Фильм {nameFilm} будет в {zal} зале {dataTime} " +
                $"числа в {timeTime} мест {numberSeats} ");
        }
        public decimal Calculation(int buyers, FilmScreening FilmPtr)
        {
            if (buyers > 0)
            {
                return buyers * FilmPtr.ticketBill;
            }
            else { return FilmPtr.numberSeats * FilmPtr.ticketBill; }


        }
    }
}