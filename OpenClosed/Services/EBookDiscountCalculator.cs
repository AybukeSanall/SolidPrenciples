using SolidPrincipleProject.SingleResponsibility.Models;

namespace SolidPrincipleProject.OpenClosed.Services;

public class EBookDiscountCalculator : DiscountCalculator
{
    public override decimal DiscountCalculate(Book book)
    {
        if (book.IsEBook)
            return book.Price * 0.10m;
        return 0m;
    }
}