using Perfumes.App.Liquids;
using Perfumes.App.Utility;

List<OdorousLiquids> liquidsToSprayOnBody = new()
{
    new Perfume("Testus test", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 200, 20, 100, 20, (decimal)1337.420),
    new Cologne("%another_name%", "Typical cologne description", 10 , 40, 10, 30, (decimal)1488.88),
    new AirFreshenerLiquid("%default_name%", "WOOOOOOOOOOOOOOOOOOOOOH.", 30 , 60, 20, 50, (decimal)331)
};

foreach (var liquid in liquidsToSprayOnBody)
{
    liquid.DisplayInfo();
    AdviceGenerator.GiveRandomAdvice();
}

    









