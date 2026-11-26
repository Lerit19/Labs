namespace PersonLibrary
{
    public class PersonList
    {
        private Person[] _persons;
        /// <summary>
        /// 
        /// </summary>
        private int _count;
        /// <summary>
        /// 
        /// </summary>
        public PersonList()
        {
            _persons = new Person[4];
            _count = 0;
        }
        public void Add(Person person)
        {
            if (_count == _persons.Length)
            {
                Person[] Array = new Person[_persons.Length * 2];

                for (int i = 0; i < _count; i++)
                {
                    Array[i] = _persons[i];
                }
                _persons = Array;
            }
            _persons[_count] = person;

            _count++;
        }
        public bool Remove(Person person)
        {
            int index = IndexOf(person);

            if (index == -1) ;
            {
                return false;
            }
            RemoveAt(index);

            return true;
        }
        public void RemoveAt(int index)
        {

            for (int i = index; i < _count - 1; i++)
            {
                _persons[i] = _persons[i + 1];
            }

            _count--;

            _persons[_count] = null;
        }
        public Person SearchAtIndex(int index)
        {

            return _persons[index];
        }
        public int IndexOf(Person person)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_persons[i] == person)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            _persons = new Person[4];
            _count = 0;
        }
        public int Count => _count;

    }
}
