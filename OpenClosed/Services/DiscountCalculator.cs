using SolidPrincipleProject.SingleResponsibility.Models;


namespace SolidPrincipleProject.OpenClosed.Services;

public abstract class DiscountCalculator
{
    public abstract decimal DiscountCalculate(Book book);
}