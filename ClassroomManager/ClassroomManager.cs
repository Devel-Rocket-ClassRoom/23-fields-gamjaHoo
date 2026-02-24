using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomManager
{
    internal class ClassroomManager
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
}
