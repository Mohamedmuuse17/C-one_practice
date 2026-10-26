package HospitalPackage;

// Superclass: stores patient information
class Patient {
    protected String Name;
    protected double ConsultFee;

    // Constructor initializes patient details
    public Patient(String Name, double ConsultFee) {
        this.Name = Name;
        this.ConsultFee = ConsultFee;
    }

    // Displays patient information
    public void Display() {
        System.out.println("Name: " + Name);
        System.out.println("Consult Fee: $" + ConsultFee);
    }
}

// Subclass: for outpatient patients
class Outpatient extends Patient {
    double LabCharge;

    // Constructor calls the superclass constructor
    public Outpatient(String Name, double ConsultFee, double LabCharge) {
        super(Name, ConsultFee);
        this.LabCharge = LabCharge;
    }

    // Calculates the outpatient bill
    public double CalculateBill() {
        return LabCharge + ConsultFee;
    }

    // Displays outpatient information and total bill
    @Override
    public void Display() {
        super.Display();
        System.out.println("Lab Charge: $" + LabCharge);
        System.out.println("Total Bill: $" + CalculateBill());
    }
}

// Subclass: for inpatient patients
class Inpatient extends Patient {
    double RoomCharge;
    int NumberOfDays;

    // Constructor initializes room charge and days
    public Inpatient(String Name, double ConsultFee,
                     double RoomCharge, int NumberOfDays) {
        super(Name, ConsultFee);
        this.RoomCharge = RoomCharge;
        this.NumberOfDays = NumberOfDays;
    }

    // Calculates the inpatient bill
    public double CalculateBill() {
        return (NumberOfDays * RoomCharge) + ConsultFee;
    }

    // Displays inpatient information and total bill
    @Override
    public void Display() {
        super.Display();
        System.out.println("Room Charge: $" + RoomCharge);
        System.out.println("Number Of Days: " + NumberOfDays);
        System.out.println("Total Bill: $" + CalculateBill());
    }
}

// Main class
public class HospitalPackage {
    public static void main(String[] args) {

        // Create outpatient object
        Outpatient out = new Outpatient("Ahmed", 20, 15);

        System.out.println("=== OUTPATIENT ===");
        out.Display();

        System.out.println();

        // Create inpatient object
        Inpatient in = new Inpatient("Ali", 20, 50, 3);

        System.out.println("=== INPATIENT ===");
        in.Display();
    }
}