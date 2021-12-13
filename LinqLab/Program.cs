using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            Console.WriteLine("For numbers");
            Console.WriteLine();

            Console.WriteLine("1. Find min:");
            int min = nums.Min();
            Console.WriteLine(min);
            Console.WriteLine("2. Find max:");
            int max = nums.Max();
            Console.WriteLine(max);
            Console.WriteLine("3. Find Maximum value less than 10000");
            int maxUnder1000 = nums.Where(x => x < 1000).Max();
            Console.WriteLine(maxUnder1000);
            Console.WriteLine("4. find all the values between 10 and 100");
            List<int> nums1 = nums.Where(x => x >= 10 && x <= 100).ToList();
            foreach(int num in nums1)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("5. Find all the values between 100000 and 999999");
            List<int> nums2 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            foreach (int num in nums2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("6. Count all the even numbers");
            int evenCount = nums.Count(x => x % 2 == 0);
            Console.WriteLine(evenCount);

            Console.WriteLine();
            Console.WriteLine("For Students:");
            Console.WriteLine();

            Console.WriteLine("1. Find all students age of 21 and over (aka US drinking age)");
            List<Student> studentsDrinking = students.Where(x => x.Age >= 21).ToList();
            foreach(Student s in studentsDrinking)
            {
                Console.WriteLine(s.Name + " " + s.Age);
            }
            Console.WriteLine("2. Find the oldest student:");
            int oldestAge = students.Max(x => x.Age);
            Student oldestStudent = students.Where(x => x.Age == oldestAge).ToList().First();
            Console.WriteLine(oldestStudent.Name + " " + oldestStudent.Age);
            Console.WriteLine("3. Find the youngest student");
            int youngestAge = students.Min(x => x.Age);
            Student youngestStudent = students.Where(x => x.Age == youngestAge).ToList().First();
            Console.WriteLine(youngestStudent.Name + " " + youngestStudent.Age);
            Console.WriteLine("4. Find the oldest student under the age of 25");
            int oldestAgeUnder25 = students.Where(x => x.Age < 25).Max(x => x.Age);
            Student oldestStudentUnder25 = students.Where(x => x.Age == oldestAgeUnder25).ToList().First();
            Console.WriteLine(oldestStudentUnder25.Name + " " + oldestStudentUnder25.Age);
            Console.WriteLine("5. Find all students over 21 and with even ages");
            List<Student> over21AndEven = students.Where(x => x.Age >= 25 && x.Age % 2 == 0).ToList();
            foreach(Student s in over21AndEven)
            {
                Console.WriteLine(s.Name + " " + s.Age);
            }
            Console.WriteLine("6. Find all teenage students");
            List<Student> teenageStudents = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            foreach (Student s in teenageStudents)
            {
                Console.WriteLine(s.Name + " " + s.Age);
            }
            Console.WriteLine("7. Find all students whose name starts with a vowel");
            List<Student> studentsStartsWithVowel = students.Where(x => x.Name.StartsWith('A') || 
            x.Name.StartsWith('E') || x.Name.StartsWith('I') | x.Name.StartsWith('O') || x.Name.StartsWith('U')).ToList();
            foreach(Student s in studentsStartsWithVowel)
            {
                Console.WriteLine(s.Name + " " + s.Age);
            }

        }
    }
}
