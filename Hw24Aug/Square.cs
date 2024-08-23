
namespace Hw24Aug
{
    internal class Square : Figure
    {
        private int _side;
        public virtual int side {
            get
            {
                return _side;
            }
            set 
            { 
                if (value < 0)
                    value=value*-1;

                _side = value;
            } 
        }

        public override int CalcArea()
        {
            return side*side;
            
        }
    }
}
