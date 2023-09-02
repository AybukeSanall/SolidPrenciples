using SolidPrincipleProject.SingleResponsibility.Models;

namespace SolidPrincipleProject.OpenClosed.Services;

public class PrintedBookDiscountCalculator : DiscountCalculator
{
    public override decimal DiscountCalculate(Book book)
    {
        if (!book.IsEBook)
            return book.Price * 0.05m;
        return 0m;
    }
}