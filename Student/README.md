# Student — Student Grades

Create a class named Student that represents a student and their grades.

## Requirements

- The student has a student ID, a full name, and a collection of grades.
- The constructor initializes the student ID and full name.
- Each student starts with no grades.
- A method AddGrade(grade) adds a valid grade.
- Grades must be integers between 5 and 10, inclusive.
- Grades must not be modified directly from outside the class.
- For an invalid grade, display an appropriate message
  and leave the collection unchanged.
- A method GetAverage() returns the average of all grades.
- If the student has no grades, GetAverage() returns 0.
- A method HasPassed() returns true if the student has at least
  one grade and all grades are 6 or higher; otherwise, it returns false.
- A method PrintInfo() displays the student ID, full name,
  all grades, the average to two decimal places, and the passing status.

## Testing

In Main:
1. Create two students.
2. Display the details of a student with no grades.
3. Add several valid grades to both students.
4. Include a grade of 5 for one student.
5. Attempt to add invalid grades, such as 4 and 11.
6. Display both students' details and verify their averages
   and passing statuses.