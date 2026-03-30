// --- 1. DATA SECTION (This fixes the "does not exist" errors) ---
int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10]; // Placeholder for the loop
string currentStudentLetterGrade = "";

// --- 2. THE LOGIC SECTION ---
foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;
    int gradedAssignments = 0;

    // 🔁 loop through scores
    foreach (int score in studentScores)
    {
        gradedAssignments++;

        if (gradedAssignments <= examAssignments)
            sumExamScores += score;
        else
            sumExtraCreditScores += score;
    }

    // --- CALCULATIONS ---
    decimal examScore = (decimal)sumExamScores / examAssignments;
    decimal extraCreditPoints = (decimal)(sumExtraCreditScores * 0.10m) / examAssignments;
    decimal currentStudentGrade = ((decimal)sumExamScores + (sumExtraCreditScores * 0.10m)) / examAssignments;

    // Determine Letter Grade
    if (currentStudentGrade >= 97) currentStudentLetterGrade = "A+";
    else if (currentStudentGrade >= 93) currentStudentLetterGrade = "A";
    else if (currentStudentGrade >= 90) currentStudentLetterGrade = "A-";
    else if (currentStudentGrade >= 87) currentStudentLetterGrade = "B+";
    else if (currentStudentGrade >= 83) currentStudentLetterGrade = "B";
    else if (currentStudentGrade >= 80) currentStudentLetterGrade = "B-";
    else if (currentStudentGrade >= 77) currentStudentLetterGrade = "C+";
    else if (currentStudentGrade >= 73) currentStudentLetterGrade = "C";
    else if (currentStudentGrade >= 70) currentStudentLetterGrade = "C-";
    else if (currentStudentGrade >= 67) currentStudentLetterGrade = "D+";
    else if (currentStudentGrade >= 63) currentStudentLetterGrade = "D";
    else if (currentStudentGrade >= 60) currentStudentLetterGrade = "D-";
    else currentStudentLetterGrade = "F";

    // ✅ Output for current student
    Console.WriteLine($"{currentStudent}\t\t{examScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{sumExtraCreditScores} ({extraCreditPoints} pts)");
}

// --- 3. FINAL PAUSE ---
if (System.Diagnostics.Debugger.IsAttached)
{
    Console.WriteLine("\nPress the Enter key to continue");
    Console.ReadLine();
}