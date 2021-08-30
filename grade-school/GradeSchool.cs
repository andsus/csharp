using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    // Grade: [ 2 -> {Bob, Alice}, 5 -> { Bradley, Franklin }]
    private SortedList<int, SortedSet<String>> students 
        = new SortedList<int, SortedSet<String>>();

    // Maintain sorting in Add method
    public void Add(string student, int grade) {
        if (!students.ContainsKey(grade)) {
            students.Add(grade, new SortedSet<string>());
        }
        students[grade].Add(student);
    }

    public IEnumerable<string> Roster() => 
        students
            .SelectMany( s => s.Value);

    public IEnumerable<string> Grade(int grade) =>
        students
        .Where(s => s.Key == grade)
        .SelectMany(s => s.Value);
    
}