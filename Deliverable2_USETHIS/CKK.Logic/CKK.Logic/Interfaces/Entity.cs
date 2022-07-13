using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        public int _id;
        public string _name;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                if (value < 0)
                {
                    throw new InvalidIdException();
                }
            }

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
