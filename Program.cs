namespace assignment2._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student();
            myStudent.StudentId = 1;
            myStudent.StudentFName = "JongDo";
            myStudent.StudentLName = "Yoo";
            myStudent.StudentGrade = 'A'; 
            Console.WriteLine("StupdentId is: " + myStudent.StudentId);
            Console.WriteLine("StudentFName is: " + myStudent.StudentFName);
            Console.WriteLine("StudentLName is: " + myStudent.StudentLName);
            Console.WriteLine("StudentGrade is: " + myStudent.StudentGrade);
            
        }
    }

    public class Student
    {
        private int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }
        
        private string _studentFName;
        public string StudentFName 
        { 
            get { return _studentFName; } 
            set { _studentFName = value; }
        }
        
        private string _studentLName;
        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        private char _studentGrade;
        public char StudentGrade 
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
        

        
        
        
       
            
    }

    

    
}
