using CloudAcademy.Bitcoin;

var converter = new ConverterSvc();

while (true)
{
  try
  {
    Console.Write("Coins: ");
    var coins = Double.Parse(Console.ReadLine());
    Console.Write("Currency (USD, GBP, or EUR): ");
    var currency = (ConverterSvc.Currency)Enum.Parse(typeof(ConverterSvc.Currency), Console.ReadLine(), true);

    var amount = await converter.ConvertBitcoins(currency, coins);

    Console.WriteLine("{0} Bitcoins = {1} {2}", coins, amount, currency);
  }
  catch
  {
    //swallow
  }
}
