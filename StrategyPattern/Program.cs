using StrategyPattern;
using StrategyPattern.DiscountStrategy;

var dataReader = new CustomerDataReader();
var customers = dataReader.GetCustomers();

while (true)
{
    Console.WriteLine($"Customers List : [1:Sulaiman Ibrahem Ismaeel] [2:Ibraheem Sulaiman Ismaeel]");
    Console.WriteLine("select Cutomer Id");
    var customerId = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Item Quantity :");
    var quantity = int.Parse(Console.ReadLine());
    Console.WriteLine("enter Unit Price :");
    var unitePrice = double.Parse(Console.ReadLine());
    var customer = customers.First(c => c.Id == customerId);
    ICustomerDiscountStrategy customerDiscountStrategy;
    if (customer.Category == CustomerCategory.New)
    {
        customerDiscountStrategy = new NewCustomerDiscountStrategy();
    }
    else if (customer.Category == CustomerCategory.Silver)
    {
        customerDiscountStrategy = new SilverCustomerDiscountStrategy();
    }
    else
    {
        customerDiscountStrategy = new GoldCustomerDiscountStrategy();
    }
    InvoiceManager invoiceManager = new InvoiceManager();
    invoiceManager.SetStrategy(customerDiscountStrategy);
   var invoice= invoiceManager.CreateInvoice(customer, quantity, unitePrice);
    Console.WriteLine($"Invoice Created for Customer :{customer.Name} and Net Price is: {invoice.NetPrice}");
    Console.WriteLine("press any key to crate anothoer Invoice");
    Console.ReadKey();
    Console.WriteLine("-----------------------------------------------------");
}