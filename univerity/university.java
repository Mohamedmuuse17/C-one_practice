
import java.util.Scanner;

// Custom Exception Class
class univesity extends Exception {

    public univesity(String message) {
        super(message);
    }
}

// Main Class
 class ExamRegistration {

    // Method to validate student registration
    public static void validateRegistration(
            String studentID,
            int age,
            int examMark,
            int numberOfSubjects)
            throws univesity {

        if (studentID == null || studentID.trim().isEmpty()) {
            throw new univesity(
                    "Student ID cannot be empty.");
        }

        if (age < 18) {
            throw new univesity(
                    "Student age must be at least 18.");
        }

        if (examMark < 0 || examMark > 100) {
            throw new univesity(
                    "Exam mark must be between 0 and 100.");
        }

        if (numberOfSubjects < 1 || numberOfSubjects > 5) {
            throw new univesity(
                    "Students can register for 1 to 5 subjects only.");
        }
    }

    // Main Method
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        System.out.println("===== EXAM REGISTRATION SYSTEM =====");

        try {
            // Collect student information
            System.out.print("Enter Student ID: ");
            String studentID = input.nextLine();

            System.out.print("Enter Student Name: ");
            String studentName = input.nextLine();

            System.out.print("Enter Age: ");
            int age = Integer.parseInt(input.nextLine());

            System.out.print("Enter Exam Mark: ");
            int examMark = Integer.parseInt(input.nextLine());

            System.out.print("Enter Number of Subjects: ");
            int numberOfSubjects =
                    Integer.parseInt(input.nextLine());

            // Validate registration
            validateRegistration(
                    studentID,
                    age,
                    examMark,
                    numberOfSubjects
            );

            // Display successful registration
            System.out.println("\nRegistration Successful!");
            System.out.println("Student ID: " + studentID);
            System.out.println("Student Name: " + studentName);
            System.out.println("Age: " + age);
            System.out.println("Exam Mark: " + examMark);
            System.out.println(
                    "Registered Subjects: " + numberOfSubjects);

        } catch (univesity e) {

            System.out.println("\nRegistration Failed!");
            System.out.println("Error: " + e.getMessage());

        } catch (NumberFormatException e) {

            System.out.println("\nRegistration Failed!");
            System.out.println(
                    "Error: Please enter valid numbers for age, mark, and subjects.");

        } finally {

            System.out.println("\nRegistration attempt completed.");
            input.close();
        }
    }
}
