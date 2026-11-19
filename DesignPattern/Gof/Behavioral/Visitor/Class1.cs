namespace DesignPattern.Gof.Behavioral.Visitor;

public interface IPayment
{
    void Accept(IProductVisitor visitor);
}

public class CashPayment : IPayment
{
    public void Accept(IProductVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class CryptoPayment : IPayment
{
    public void Accept(IProductVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public interface IProductVisitor
{
    void Visit(CashPayment payment);
    void Visit(CryptoPayment payment);
}


public class PaymentReportVisitor : IProductVisitor
{
    public void Visit(CashPayment payment)
    {
        Console.WriteLine("PaymentReportVisitor - CashPayment");
    }

    public void Visit(CryptoPayment payment)
    {
        Console.WriteLine("PaymentReportVisitor - CryptoPayment");
    }
}

public class PaymentAuditVisitor : IProductVisitor
{
    public void Visit(CashPayment payment)
    {
        Console.WriteLine("PaymentAuditVisitor - CashPayment");
    }

    public void Visit(CryptoPayment payment)
    {
        Console.WriteLine("PaymentAuditVisitor - CryptoPayment");
    }
}


public class Call
{
    void Caller()
    {
        IPayment[] products =
        {
            new CashPayment(),
            new CryptoPayment(),
        };

        IProductVisitor taxVisitor = new PaymentAuditVisitor();
        IProductVisitor reportVisitor = new PaymentReportVisitor();

        foreach (var product in products)
        {
            product.Accept(taxVisitor);
        }

        Console.WriteLine("-------------");
        foreach (var product in products)
        {
            product.Accept(reportVisitor);
        }
    }
}

