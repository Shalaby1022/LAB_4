namespace StudentClass
{
    internal class Program
    {
        class Student
        {
            private string ssn;
            private string name;
            private int age;
            private string address;

            public void SetSSn(string _ssn)
            {
                ssn = _ssn;

            }
           public void SetName(string _name)
            {
                name = _name;
            }
            public void SetAge(int _age)
            {
                age = _age;
            }
            public void SetAdress(string _address)
            {
                address = _address;
            }
            public string GetSsn()
            {
                return ssn;
            }
            public string GetName()
            {
                return name;
            }
            public int GetAge()
            {
                return age;
            }
            public string GetAdress()
            {
                return address;

            }

            public string PrintData()
            {
                return $"SSN is {ssn} , Name is {name} , Age is {age} , Address is {address}";

            }
        }
        static void Main(string[] args)
        {
            // One User 
            Student student = new Student();

            Console.WriteLine("Enter student details:");
            Console.Write("SSN: ");
            student.SetSSn(Console.ReadLine());

            Console.Write("Name: ");
            student.SetName(Console.ReadLine());

            Console.Write("Age: ");
            student.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Address: ");
            student.SetAdress(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Student Information:");
            Console.WriteLine(student.PrintData());



            // group of users 

            Console.Write("Enter the number of students: ");
            int numStudents = int.Parse(Console.ReadLine());

            Student[] students = new Student[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");
                Student stu = new Student();

                Console.Write("SSN: ");
                student.SetSSn(Console.ReadLine());

                Console.Write("Name: ");
                student.SetName(Console.ReadLine());

                Console.Write("Age: ");
                student.SetAge(int.Parse(Console.ReadLine()));

                Console.Write("Address: ");
                student.SetAdress(Console.ReadLine());

                students[i] = stu;
                Console.WriteLine();
            }

            Console.WriteLine("Student Information:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                students[i].PrintData();
            }


        }




    }
}