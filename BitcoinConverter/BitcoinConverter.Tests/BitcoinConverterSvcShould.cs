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

  [Theory]
  [InlineData("USD", 1, 100)]
  [InlineData("USD", 2, 200)]
  [InlineData("GBP", 1, 200)]
  [InlineData("GBP", 2, 400)]
  [InlineData("EUR", 1, 300)]
  [InlineData("EUR", 2, 600)]
  public void ConvertBitcoins_BitcoinsToCurrency_ReturnsCurrency(string currency, int coins, int expected)
  {
    //arrange
    var converterSvc = new ConverterSvc();

    //act
    var dollars = converterSvc.ConvertBitcoins(currency, coins);

    //assert
    Assert.Equal(expected, dollars);
  }
}