using System.Reflection.Emit;

class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(List<Product> products, Customer customer)
  {
    _products = products;
    _customer = customer;
  }

  public decimal CalculateTotal()
  {
    decimal productsTotal = 0;
    foreach (Product product in _products)
    {
      productsTotal += product.GetTotalCost();
    }

    decimal shipping = _customer.IsInUsa() ? 5.00m : 35.00m;

    return productsTotal + shipping;
  }

  public string PackingLabel()
  {
    string label = "";
    foreach (Product product in _products)
    {
      label += $"Product: {product.GetProduct()}\nProduct ID: {product.GetProductID()}\n";
    }

    return label;
  }

  public string ShippingLabel()
  {
    string label = $"Customer: {_customer.GetName()}\n";
    label += "Address:\n";
    label += _customer.GetAddress().GetFullAddress();
    return label;
  }
}