namespace CloudAcademy.Bitcoin.Tests;

public class BitcoinConverterSvcShould
{
  [Fact]
  public void GetExchangeRate_USD_ReturnsUSDExchangeRate()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangeRate = converterSvc.GetExchangeRate("USD");

    //assert
    var expected = 100;
    Assert.Equal(expected, exchangeRate);
  }

  [Fact]
  public void GetExchangeRate_GBP_ReturnsGBPExchangeRate()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangeRate = converterSvc.GetExchangeRate("GBP");

    //assert
    var expected = 200;
    Assert.Equal(expected, exchangeRate);
  }

  [Fact]
  public void GetExchangeRate_EUR_ReturnsEURExchangeRate()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangeRate = converterSvc.GetExchangeRate("EUR");

    //assert
    var expected = 300;
    Assert.Equal(expected, exchangeRate);
  }

  [Fact]
  public void ConvertBitcoins_1BitcoinToUSD_ReturnsUSDDollars()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangedValue = converterSvc.ConvertBitcoins("USD", 1);

    //assert
    var expected = 100;
    Assert.Equal(expected, exchangedValue);
  }

  [Fact]
  public void ConvertBitcoins_1BitcoinToGBP_ReturnsGBPPounds()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangedValue = converterSvc.ConvertBitcoins("GBP", 1);

    //assert
    var expected = 200;
    Assert.Equal(expected, exchangedValue);
  }

  [Fact]
  public void ConvertBitcoins_1BitcoinToEUR_ReturnsEUREuros()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangedValue = converterSvc.ConvertBitcoins("EUR", 1);

    //assert
    var expected = 300;
    Assert.Equal(expected, exchangedValue);
  }
}