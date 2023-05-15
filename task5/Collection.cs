using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Collection : Comedy
    {
        public int numberOfViews { get; set; }
        public List<Comedy> films = new();

        public Collection(int year, string filmName, string director,int views) : base(year, filmName, director)
        {
            this.numberOfViews = views;
        }


        public void addFilm(Comedy film)
        { 
           films.Add(film);
        }

        public void printFilms()
        {
            Console.WriteLine("Фильмы коллекции: ");
            foreach(Comedy comedy in films) 
            {
                Console.Write(comedy.ToString());
            }
        }

        public override string ToString() => $"[name: {name}, filmDirector: {Director}, age: {getAge()}] , views: {numberOfViews}]\n";

        public override void pause()
        {
            Console.WriteLine("Сборник фильмов поставлен на паузу");
        }

        public override void play()
        {
            Console.WriteLine("Начат просмотр сборника фильмов");
        }
    }
}
