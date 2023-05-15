using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            USSRFilm comedy1 = new Comedy(1990, "Комедия 1", "Гай Ричи");
            USSRFilm comedy2 = new Comedy(2002, "Комедия 2", "Мартин Скорсезе");
            USSRFilm comedy4 = new Comedy(2005, "Комедия 4", "Мартин Скорсезе");
            USSRFilm comedy3 = new Comedy(1950, "Комедия 3", "Стенли Кубрик");
            Collection collection1 = new Collection(2010, "Cборник лучших комедий Мартина Скорсезе", "Мартин Скорсезе", 10000);
            Collection collection2 = new Collection(2000, "Cборник лучших комедий других авторов", "Другой автор хз какой", 20000);

            collection1.addFilm(comedy2);
            collection1.addFilm(comedy4);
            collection2.addFilm(comedy1);
            collection2.addFilm(comedy3);
            collection1.addFilm(collection2);

            comedy1.play();
            comedy1.pause();

            collection1.play();
            collection1.pause();

            collection1.printFilms();
            collection2.printFilms();
        }
    }
}
