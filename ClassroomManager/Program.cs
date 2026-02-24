using System;


ClassroomManager c1 = new ClassroomManager("1반");
ClassroomManager c2 = new ClassroomManager("2반");

c1.AddStudent("홍길동");
c1.AddStudent("김철수");
c1.AddStudent("이영희");
c2.AddStudent("박민수");
c2.AddStudent("정수진");
c1.ShowStudents();
c2.ShowStudents();
ClassroomManager.ShowTotalClassrooms();
class ClassroomManager
{
    const int MaxStudents = 5;
    private readonly string className;
    private string[] names;
    private int studentCount = 0;
    private static int totalClasses;

    public ClassroomManager(string className)
    {
        this.className = className;
        names = new string[MaxStudents];
        totalClasses++;
    }
    public void AddStudent(string name)
    {
        if (studentCount == 5)
        {
            Console.WriteLine("최대 학생 수 초과");
            return;
        }
        names[studentCount++] = name;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"=== {className}반 학생 목록 ({studentCount} / {MaxStudents}) ===\n");
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == null) break;
            Console.WriteLine($"{i + 1}. {names[i]}");
        }
        Console.WriteLine();
    }
    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실 수: {totalClasses}");
    }

}