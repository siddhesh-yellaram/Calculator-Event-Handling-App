using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEventHandlingApp.Model
{
    public delegate void Add(Calculator obj);
    public class Calculator
    {
        public event Add AddCompletion;
        private int _x, _y, _res;

        public int X
        {
            get
            {
                return _x;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
        }

        public int Result
        {
            get
            {
                return _res;
            }
        }
        public void Add(int x, int y)
        {
            _x = x;
            _y = y;
            _res = _x + _y;
            if (AddCompletion != null)
            {
                AddCompletion(this);
            }
        }
    }
}
