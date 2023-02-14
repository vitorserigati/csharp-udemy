namespace InterfaceDemo.Services;

using InterfaceDemo.Entities;

public class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }
    private ITaxService _taxService;

    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        _taxService = taxService;
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void ProcessInvoice(CarRental carRental)
    {
        TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

        double basicPayment = 0.0;
        if (duration.TotalHours <= 12.0)
        {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
        }
        else
        {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = _taxService.Tax(basicPayment);
        carRental.Invoice = new Invoice(basicPayment, tax);
    }
}

