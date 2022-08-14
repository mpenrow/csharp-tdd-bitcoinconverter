using System.Text;
using System.Text.Json;

namespace CloudAcademy.Bitcoin;
public class ConverterSvc
{
  private const string BITCOIN_CURRENTPRICE_URL = "https://api.coindesk.com/v1/bpi/currentprice.json";

  private HttpClient client;

  public ConverterSvc() : this(new HttpClient())
  {
  }

  public ConverterSvc(HttpClient httpClient)
  {
    this.client = httpClient;
  }

  public enum Currency
  {
    USD,
    GBP,
    EUR
  }

  public async Task<double> GetExchangeRate(Currency currency)
  {
    double rate = 0;

    try
    {
      var response = await this.client.GetStringAsync(BITCOIN_CURRENTPRICE_URL);
      var jsonDoc = JsonDocument.Parse(Encoding.ASCII.GetBytes(response));
      var rateStr = jsonDoc.RootElement.GetProperty("bpi").GetProperty(currency.ToString()).GetProperty("rate").GetString();

      if (rateStr is not null)
      {
        rate = Double.Parse(rateStr);
      }
      else
      {
        rate = -1;
      }
    }
    catch
    {
      rate = -1;
    }

    return Math.Round(rate, 4);
  }

  public async Task<double> ConvertBitcoins(Currency currency, double coins)
  {
    if (coins < 0)
    {
      throw new ArgumentException("Number of coins should be positive");
    }

    var exchangeRate = await GetExchangeRate(currency);

    if (exchangeRate < 0)
    {
      return -1;
    }

    return Math.Round(exchangeRate * coins, 4);
  }
}
