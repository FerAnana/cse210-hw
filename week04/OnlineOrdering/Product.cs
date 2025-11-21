class Product
{
  private string _productName;
  private string _productId;
  private decimal _price;
  private int _quantity;

  public Product(string productName, string productId, decimal price, int quantity)
  {
    _productName = productName;
    _productId = productId;
    _price = price;
    _quantity = quantity;
  }

  public string GetProduct()
  {
    return _productName;
  }

  public string GetProductID()
  {
    return _productId;
  }

  public decimal GetTotalCost()
  {
    return _price * _quantity;
  }
}
