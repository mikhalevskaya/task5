using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    interface IFilm
    {
        public string Name { get; set; }

        public void pause();
        public void play();
    }
}
