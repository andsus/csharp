using System;
using System.Collections.Generic;
using System.Linq;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Grade { get; set; }

    public int CompareTo(Student? other) =>
        this.Name.CompareTo(other.Name);

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}
public class GradeSchool
{
    private SortedSet<Student> roster;

    // Grade: [ 2 -> {Bob, Alice}, 5 -> { Bradley, Franklin }]

    public GradeSchool()
    {
        roster = new SortedSet<Student>();
    }

    // Maintain sorting in Add method
    public bool Add(string student, int grade) =>
        roster.Add(new Student(student, grade));

    public IEnumerable<string> Roster() =>
        roster
            .OrderBy(s => s.Name)
            .OrderBy(s => s.Grade)
            .Select(s => s.Name);

    public IEnumerable<string> Grade(int grade) =>
        roster
        .Where(s => s.Grade == grade)
        .Select(s => s.Name);

}