

namespace Hw24Aug
{
    internal class Rectangular : Figure
    {
        private int _width;
        public int width 
        {
            get 
            { 
                return _width;
            } set 
            {
                if (value < 0)
                    value = -1 * value;

                _width = value;
            }
        }

        private int _length;
        public int length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                    value = -1 * value;

                _length = value;
            }
        }

        public override int CalcArea()
        {
            return length * width;
        }
    }
}
