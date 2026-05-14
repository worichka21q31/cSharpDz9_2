using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ConsoleApp2
{

    public class Menu
    {

        public static bool Start()
        {

            string choise;
            Console.Write("\nВыберите пункт\n" +
                "1) Фильм\n" +
                "2) Покупка\n" +
                "3) Словарь\n" +
                "4) Выйти" +
                "\nВвод: ");
            choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    ListFilmScreening MyList = new ListFilmScreening();
                    FilmScreening Film0 = new FilmScreening("Приключение", "Восьмой", "24.12.01", "12:11", 22, 760m);
                    FilmScreening Film1 = new FilmScreening("Новый Век", "Пятый", "24.12.01", "14:11", 13, 870m);
                    FilmScreening Film2 = new FilmScreening("Зло Опять", "3д Второй", "24.12.01", "12:11", 72, 220m);
                    FilmScreening Film3 = new FilmScreening("Братва Братва", "Восьмой", "24.12.01", "12:71", 12, 1200m);
                    FilmScreening Film4 = new FilmScreening("Заезд 8", "Восьмой", "24.01.01", "12:11", 42, 700m);
                    MyList.AddToList(Film0);
                    MyList.AddToList(Film1);
                    MyList.AddToList(Film2);
                    MyList.AddToList(Film3);
                    MyList.AddToList(Film4);
                    while (true)
                    {
                        string choiseF;
                        MyList.PrintList();
                        Console.Write("\nВыберите пункт\n" +
                            "1) Сортировка\n" +
                            "2) Добавить Ручками\n" +
                            "3) Удаление\n" +
                            "4) Выйти" +
                            "\nВвод: ");
                        choiseF = Console.ReadLine();
                        if (choiseF == "1") { MyList.SortByTitleLength(); }
                        else if (choiseF == "2") { MyList.AddManualToList(); }
                        else if (choiseF == "3") 
                        {
                            string name, time, date;
                            Console.Write("\nВведите название\n");
                            name = Console.ReadLine();
                            Console.Write("\nВведите Время\n");
                            time = Console.ReadLine();
                            Console.Write("\nВведите дату\n");
                            date = Console.ReadLine();
                            MyList.Removee(name, date, time);

                        }
                        else if (choiseF == "4") { break; }
                    }

                    break;
                case "2":
                    Console.WriteLine("" +
                        "Выберите способ оплаты:" +
                        "\n1 - Безналичный (карта)" +
                        "\n2 - Наличные");
                    Console.Write("\nВвод ");

                    string choiceP = Console.ReadLine();

                    long phone = 79991234567; 
                    decimal amount = 500.0m;

                    if (choiceP == "1")
                    {
                        var cashN = new NonCash
                        {
                            idCard = "1234 5678 9012 3456",
                            dateIssue = "21.21.21",
                            fio = "ИВАНОВ ИВАН",
                            codeCVC = 123
                        };
                        var purchaseCard = new Purchase<NonCash>(cashN, phone, amount);
                        Console.WriteLine("\nинфо о покупке");
                        Console.WriteLine(purchaseCard.Info());
                    }
                    else if (choiceP == "2")
                    {
                        var cash = new Cash { сhange = 100.0m };
                        var purchaseCash = new Purchase<Cash>(cash, phone, amount);
                        Console.WriteLine("\nинфо о покупке");
                        Console.WriteLine(purchaseCash.Info());
                    }
                    break;
                case "3":
                    Console.WriteLine("Введите текст:");
                    string input = Console.ReadLine();

                    Dictionary<string, int> result = WordCounter.CountWords(input);
                    WordCounter.PrintDictionary(result);
                    break;
                default:
                    Console.Write("\nВыход... ");
                    return false;
            }
            return true;
        }
    }
}
