
public class Product
{
    private string _name;
    private string _productID;
    private float _singlePrice;
    private float _totalPrice;
    private int _amount;

    public Product(string name, string productID, float singlePrice, int amount)
    {
        _name = name;
        _productID = productID;
        _singlePrice = singlePrice;
        _amount = amount;
        FindTotalPrice();

    }
    private void FindTotalPrice()
    {
        _totalPrice = _singlePrice * _amount;
    }
    public string GetPoductName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public float GetSinglePrice()
    {
        return _singlePrice;
    }
    public float GetTotalPrice()
    {
        return _totalPrice;
    }
    public int GetAmount()
    {
        return _amount;
    }

}