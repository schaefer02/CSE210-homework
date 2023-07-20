
public class Order
{
    private List<Product> _product;
    private float _totalCost;
    private float _shippingCost;
    private Customer _customer;

    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        if (customer.GetIsFromUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
        _product = product;
        CalculateTotalCost();
    }
    private void CalculateTotalCost()
    {
        _totalCost = _shippingCost;
        foreach(Product product in _product)
        {
            _totalCost += product.GetTotalPrice();
        }

    }
    public float GetTotalCost()
    {
        return _totalCost;
    }
    public string GetShippingLabel()
    {
        return $"Customer Name: {_customer.GetName()}\n Customer Address:\n{_customer.GetAddress().GetFormattedAddress()}\n";
    }
    public string GetPackingLable()
    {
        string packingLable = "";
        int xyz = 1;
        foreach (Product product in _product)
        {
            packingLable += $"Product {xyz}:" +
            $"Product Name: {product.GetPoductName()}\n" +
            $"Product ID: {product.GetProductID()}\n" +
            $"Product Price: {product.GetSinglePrice()}\n" +
            $"Product Amount: {product.GetAmount()}\n" ;
            xyz += 1;
            
        }
        return packingLable;
    }
}