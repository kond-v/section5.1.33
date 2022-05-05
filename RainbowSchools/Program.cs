// See https://aka.ms/new-console-template for more information

doWork();

void doWork()
{
    string fileName = @"C:\Venkata\trunk\simplilearn\section5.1.33\RainbowSchools\data\student.txt";
    try
    {
        string[] studentsData = File.ReadAllLines(fileName);
        List<RainbowSchools.Student> students = new List<RainbowSchools.Student>();
        foreach (string studentData in studentsData) { students.Add(new RainbowSchools.Student(studentData)); }
        RainbowSchools.Student temp ;
        for(int i = 0; i < students.Count; i++)
        {
            for(int j = 0; j < students.Count-1; j++)
            {
                if(string.Compare(students[j].name, students[j + 1].name) > 0)
                {
                    temp = students[j];
                    students[j]= students[j+1];
                    students[j+1]= temp;
                }
            }
        }
        foreach(RainbowSchools.Student student in students)
        {
            student.Showoff();
        }
        Console.WriteLine("Provide Student Name to search: ");
        string? searchStudentName = Console.ReadLine();
        Boolean found = false;
        if(searchStudentName != null)
        {
            foreach(RainbowSchools.Student student in students)
            {
                if (searchStudentName.Equals(student.name)) { 
                    student.Showoff();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("{0} Student not found", searchStudentName);
            }
        }

    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}