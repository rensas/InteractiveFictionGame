using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveFictionGame
{
    class World
    {
        private List<WorldRoom> _rooms { get; set; }
        private String _name { get; set; }

        public World(String name)
        {
            this._name = name;
        }
    }
}
