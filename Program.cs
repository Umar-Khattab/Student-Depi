//Omar Khattab Hassan
namespace Student_Depi
{
    public class Students
    {
        public class Node
        {
            public int id;
            public string name;
            public int[] marks;
            public int age;
            public string email;
            public Node next;
        }
        public Node head;
        public void AddStudent(int id, string name, int[] marks, int age, string email)
        {
            Node newNode = new Node();
            newNode.id = id;
            newNode.name = name;
            newNode.marks = marks;
            newNode.age = age;
            newNode.email = email;
            newNode.next = head;
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
        }
        public void DisplayStudent(int id)
        {
            Node current = head;
            while (current != null)
            {
                if (current.id == id)
                {
                    Console.WriteLine("ID: " + current.id);
                    Console.WriteLine("Name: " + current.name);
                    Console.WriteLine("Marks: ");
                    foreach (int mark in current.marks)
                    {
                        Console.WriteLine(mark);
                    }
                    Console.WriteLine("Age: " + current.age);
                    Console.WriteLine("Email: " + current.email);
                    string Grade = "";
                    if (current.marks.Average() >= 90)
                    {
                        Grade = "A+";
                    }
                    else if (current.marks.Average() >= 80)
                    {
                        Grade = "A";
                    }
                    else if (current.marks.Average() >= 70)
                    {
                        Grade = "B";
                    }
                    else if (current.marks.Average() >= 60)
                    {
                        Grade = "C";
                    }
                    else if (current.marks.Average() >= 50)
                    {
                        Grade = "D";
                    }
                    else
                    {
                        Grade = "F";
                    }
                    break;
                    Console.WriteLine($"Grade : {Grade}");
                }
                
                current = current.next;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor current = Console.ForegroundColor;
            current = ConsoleColor.DarkGreen;
            Students students = new Students();
            while (true)
            {
                Console.WriteLine("1: Add New Student");
                Console.WriteLine("2: Display Student");
                Console.WriteLine("3: Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Marks: ");
                        string[] marks = Console.ReadLine().Split(' ');
                        int[] marksArray = new int[marks.Length];
                        for (int i = 0; i < marks.Length; i++)
                        {
                            marksArray[i] = Convert.ToInt32(marks[i]);
                        }
                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Email: ");
                        string email = Console.ReadLine();
                        students.AddStudent(id, name, marksArray, age, email);
                        break;
                    case 2:
                        Console.Write("Enter ID: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        students.DisplayStudent(id1);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }   
            }
        }
    }
}
