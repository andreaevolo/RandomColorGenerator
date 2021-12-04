using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomColorGenerator
{
    public class RandomColor
    {
        private string _value = null;
        public RandomColor()
        {
            Random random = new Random();
            _value = $"{random.Next(0, 256)},{random.Next(0, 256)},{random.Next(0, 256)}";
        }
        public string Value { get => _value; }
        
    }
}
