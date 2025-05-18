using System;

// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;
    int currentAssignments = 0;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;
    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        currentAssignments += 1;
        if (currentAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    string currentStudentLetterGrade = "?";

    switch (currentStudentGrade)
    {
        case decimal grade when (grade >= 0 && grade < 60):
            currentStudentLetterGrade = "F"; 
            break;
        case decimal grade when (grade >= 60 && grade < 83): 
            currentStudentLetterGrade = "D-";
            break;
        case decimal grade when (grade >= 63 && grade < 67):
            currentStudentLetterGrade = "D";
            break;
        case decimal grade when (grade >= 67 && grade < 70):
            currentStudentLetterGrade = "D+";
            break;
        case decimal grade when (grade >= 70 && grade < 73):
            currentStudentLetterGrade = "C-";
            break;
        case decimal grade when (grade >= 73 && grade < 77):
            currentStudentLetterGrade = "C";
            break;
        case decimal grade when (grade >= 77 && grade < 80):
            currentStudentLetterGrade = "C+";
            break;
        case decimal grade when (grade >= 80 && grade < 83):
            currentStudentLetterGrade = "B-";
            break;
        case decimal grade when (grade >= 83 && grade <= 87):
            currentStudentLetterGrade = "B";
            break;
        case decimal grade when (grade >= 87 && grade < 90):
            currentStudentLetterGrade = "B+";
            break;
        case decimal grade when (grade >= 90 && grade < 93):
            currentStudentLetterGrade = "A-";
            break;
        case decimal grade when (grade >= 93 && grade < 97):
            currentStudentLetterGrade = "A";
            break;
        case decimal grade when (grade >= 97 && grade <= 100):
            currentStudentLetterGrade = "A+";
            break;
    }

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}