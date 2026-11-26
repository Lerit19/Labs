namespace PersonLibrary
{
    public enum Pol
    {
        Jenskii,
        Myjskoi,
    }
    public class Person
    {
        private int _index;
        /// <summary>
        /// 
        /// </summary>
        private string _name;
        /// <summary>
        /// 
        /// </summary>
        private string _surname;
        /// <summary>
        /// 
        /// </summary>
        private int _age;
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(Name),
                        "Name is null or empty!");
                }
                _name = value;
            }

        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(Surname),
                        "Surname is null or empty!");
                }
                _surname = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("Ne mojet chelovek jit' men'we 0 let!");
                }
                else
                {
                    _age = value;
                }

            }

        }
        public Pol Pol { get; set; }
        public Person(string name, string surname, int age, Pol pol)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Pol = pol;
            _index++;
        }

        public string GetInfo()
        {
            return "Tip:\n" +
                $"- Im9: {Name}\n" +
                $"- Famili9: {Surname}\n" +
                $"- Skok let: {Age}\n" +
                $"- Pol: {Pol}\n";
        }

    }
}
