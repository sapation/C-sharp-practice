namespace console_app
{
    public class Student
    {
        private string _name;
        public Student(string name)
        {
            _name = name;
            Console.WriteLine("A new student has been created!");
        }

        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
    }
}