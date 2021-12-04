using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomColorGenerator
{
    internal class Generator
    {
        private static Generator istance = null;
        private List<RandomColor> _colors_list;
        private byte _current_index = 0;
        static Generator()
        {
        }
        private Generator()
        {
            _colors_list = new List<RandomColor>();
        }

        public static Generator Instance {
            get {
                {
                    if(istance == null)
                    {
                        istance = new Generator();
                    }
                    return istance;
                }
            }
        }

        public void generateColor()
        {
            _colors_list.Add(new RandomColor());
        }

        public string Color()
        {
            System.Console.WriteLine(_colors_list.Last());
            return _colors_list.Last().Value;
        }

        public string goBack() { 
            if(_current_index > 0)
            {
                _current_index--;
                return _colors_list[_current_index].Value;
            }
            return null;
        }

        public string goForward()
        {
            if (_current_index < _colors_list.Count)
            {
                _current_index++;
                return _colors_list[_current_index].Value;
            }
            return null;
        }
    }
}
