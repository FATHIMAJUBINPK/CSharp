Day 3 – Object-Oriented Programming in C#
Goal: Learn classes, objects, and encapsulation while applying them in a Windows Forms application.


📝 Topics

Classes, objects, properties, and methods
Constructors & encapsulation
Event-driven programming in WinForms



🛠️ Exercises

Exercise 1 – Create a Student Class
Define a simple Student class with properties for Name, Age, and Course.

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }

    public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
    }

    public override string ToString()
    {
        return $"{Name}, {Age} years, Course: {Course}";
    }
}



Exercise 2 – Input Form


Create a form to input student details.


Display student info in a ListBox.



private void btnAddStudent_Click(object sender, EventArgs e)
{
    string name = txtName.Text;
    int age = int.Parse(txtAge.Text);
    string course = txtCourse.Text;

    Student s = new Student(name, age, course);
    listBoxStudents.Items.Add(s.ToString());
}
