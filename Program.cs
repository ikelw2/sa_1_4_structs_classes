using System.Reflection.Metadata.Ecma335;

// 1. Create a structure named “Point” and 2 data members: X and Y coordinate.
// Declare 2 points: P1 and P2.
// Determine if P2 is to the right or left of P1 or on same axis , by comparing the x Coordinates.
// ( if p1.x is more than p2.x , it is to the right )

// here, we are using cartesian coordinates, so we don't need to worry about international date line where
// longitudes carry over from 180 to -180 degrees, because we are only dealing with X and Y coordinates in a 2D plane.

Point P1 = new Point(2, 3);
Point P2 = new Point(3, 4);

Console.WriteLine($"Point P1 is at coordinates ({P1.xCoord}, {P1.yCoord}) and Point P2 is at coordinates ({P2.xCoord}, {P2.yCoord}).");
Console.WriteLine($"The Leftmost point is at coordinates ({ReturnLeftMostPoint(P1, P2).xCoord}, {ReturnLeftMostPoint(P1, P2).yCoord}). (if equal will return P1)");
Console.WriteLine();

Console.WriteLine($"Confirmation: Point P1 is to the {(P1.xCoord < P2.xCoord ? "left" : (P1.xCoord > P2.xCoord ? "right" : "on the same longitude"))} of Point P2.");
Console.WriteLine();

Console.ReadLine();


// 2. Write a class: “Student” with private data members:
// StudentId(int), StudentFname(string), StudentLname(string), StudentGrade(char)
// and public properties for each data member.
// Instantiate the class and assign data to properties.
// Display the data back on console.

Student myStudent = new Student()
//myStudent.StudentFname = "John";    // this works, but also the below works and AI finds it "more concise" because it "uses the constructor to assign values to the properties in one line, instead of multiple lines."
//myStudent.StudentLname = "Doe";
//myStudent.StudentGrade = 'A';

{ StudentID = 12345, StudentFname = "John", StudentLname = "Doe", StudentGrade = 'A' };
myStudent.DisplayStudentInfo();



//============================================================
//============================================================ mode must precede type declarations... 
Point ReturnLeftMostPoint(Point Point1, Point Point2)
{
    if (Point1.xCoord < Point2.xCoord)
    {
        return Point1;
    }
    else
    {
        return Point2;
    }
    // if both points have the same X coordinate, return Point1
}
//-----------------------------------------------------------
struct Point
{
    public int xCoord;
    public int yCoord;
    public Point(int x, int y) // overloaded constructor to allow user to create a Point object with specific coordinates
    {
        xCoord = x;
        yCoord = y;
    }
}
//-----------------------------------------------------------
public class Student
{

    public int StudentID { get; set; }
    public string StudentFname { get; set; }
    public string StudentLname { get; set; }
    public char StudentGrade { get; set; }

    public Student()
    {
        StudentID = 0;
        StudentFname = "";
        StudentLname = "";
        StudentGrade = ' ';
    }
    public Student(int id, string fname, string lname, char grade)
    {
        StudentID = id;
        StudentFname = fname;
        StudentLname = lname;
        StudentGrade = grade;
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}");
        Console.WriteLine($"Student First Name: {StudentFname}");
        Console.WriteLine($"Student Last Name: {StudentLname}");
        Console.WriteLine($"Student Grade: {StudentGrade}");
    }
}
