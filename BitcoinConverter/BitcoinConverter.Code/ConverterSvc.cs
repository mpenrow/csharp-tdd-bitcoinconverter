namespace CloudAcademy.Bitcoin;
public class ConverterSvc
{
  public ConverterSvc()
  {

  }

  public int GetExchangeRate(string currency)
  {
    if (currency.Equals("USD"))
    {
      return 100;
    }
    else if (currency.Equals("GBP"))
    {
      return 200;
    }
    else if (currency.Equals("EUR"))
    {
      return 300;
    }
    return 0;
  }

  public int ConvertBitcoins(string currency, int coins)
  {
    var exchangeRate = GetExchangeRate(currency);
    return exchangeRate * coins;
  }
}
