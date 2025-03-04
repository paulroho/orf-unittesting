namespace ORF.Upskilling.TimeBookings;

public record TimeBooking(DateTime Start, DateTime End, Break? Break);

public record Break(DateTime From, DateTime To);

public record TimeBookingWithValidation(TimeBooking TimeBooking, ValidationResult ValidationResult);

public record ValidationResult(bool IsValid, string ValidationError);

public record Bla(TimeBookingWithValidation TimeBooking);

public class TimeBookingValidator
{
    public IReadOnlyList<TimeBookingWithValidation> ValidateTimeBookings(IEnumerable<TimeBooking> timeBookings)
    {
        return [];
    }
}