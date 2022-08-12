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

  public async Task<double> GetExchangeRate(string currency)
  {
    var response = await this.client.GetStringAsync(BITCOIN_CURRENTPRICE_URL);

    if (currency.Equals("USD"))
    {
      var jsonDoc = JsonDocument.Parse(Encoding.ASCII.GetBytes(response));
      var rate = jsonDoc.RootElement.GetProperty("bpi").GetProperty(currency).GetProperty("rate");
      return Double.Parse(rate.GetString());
    }
    else if (currency.Equals("GBP"))
    {
      var jsonDoc = JsonDocument.Parse(Encoding.ASCII.GetBytes(response));
      var rate = jsonDoc.RootElement.GetProperty("bpi").GetProperty(currency).GetProperty("rate");
      return Double.Parse(rate.GetString());
    }
    else if (currency.Equals("EUR"))
    {
      var jsonDoc = JsonDocument.Parse(Encoding.ASCII.GetBytes(response));
      var rate = jsonDoc.RootElement.GetProperty("bpi").GetProperty(currency).GetProperty("rate");
      return Double.Parse(rate.GetString());
    }
    return 0;
  }

  public async Task<double> ConvertBitcoins(string currency, int coins)
  {
    var exchangeRate = await GetExchangeRate(currency);
    return exchangeRate * coins;
  }
}
