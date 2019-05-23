using System;

namespace BookStruct
{
    public struct Book
    {
        private string _name; 
        private string _id;

        public string Name
        {
            get
            {

                return _name;
            }
            private set
            {

                _name = value;

            }
        }


        public string Id
        {
            get
            {

                return _id;
            }
            private set
            {
            _id = value;
            }
        }

        public string LocalID
        {
            get
            {
             return string.Format("{0}_{1}", _name, _id);
            }
        }
        public Book(string name, string id)
        {
            _name = name;
            _id = id;
        
        }
    }
}
