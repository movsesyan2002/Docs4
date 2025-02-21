// Task 2: Flight Reservation System
// Task: Create a class FlightTicket with:
// Fields: passengerName, flightNumber, and seatNumber.
// Add a constructor to initialize these fields.
// In Main(), create a few tickets and print the details.


class FlightTicket
{
    private string passengerName;
    private int flightNumber;
    private int seatNumber;

    public FlightTicket(string passengerName, int flightNumber, int seatNumber)
    {
        this.passengerName = passengerName;
        this.flightNumber = flightNumber;
        this.seatNumber = seatNumber;
    }

    public string PassengerName
    {
        get {return passengerName;}
        set {passengerName = value;}
    }

    public int FlightNumber
    {
        get {return flightNumber;}
        set {flightNumber = value;}
    }

    public int SeatNumber
    {
        get {return seatNumber;}
        set {seatNumber = value;}
    }

    public void Showdetails()
    {
        Console.WriteLine($"Passenger details are\nPassenger name{this.PassengerName}\nPassenger flight number{this.FlightNumber}\nPassenger seat number is{this.SeatNumber}\n");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        FlightTicket FlightTicket = new FlightTicket("John",102,10);
        FlightTicket FlightTicket1 = new FlightTicket("Maria",224,11);
        FlightTicket FlightTicket2 = new FlightTicket("Jennifer",343,9);

        FlightTicket.Showdetails();
        FlightTicket1.Showdetails();
        FlightTicket2.Showdetails();
    }
}