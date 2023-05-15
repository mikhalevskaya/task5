using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Comedy : USSRFilm
    {

        public Comedy(int year, string filmName, string director) : base(year, filmName, director) {}

     

        public override string ToString()
        {
            return $"[name: {name}, filmDirector: {Director}, age: {getAge()}]\n";
        }

        public override void pause()
        {
            Console.WriteLine("Комедия поставлена на паузу");
        }

        public override void play()
        {
            Console.WriteLine("Начат просмотр комедии");
        }
    }
}
