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
  public void GetExchangeRate_EUR_ReturnsEURExcangeRate()
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var exchangeRate = converterSvc.GetExchangeRate("EUR");

    //assert
    var expected = 300;
    Assert.Equal(expected, exchangeRate);
  }
}