using Perfumes.App.Liquids;
using Perfumes.App.Utility;

List<OdorousLiquids> liquids = new()
{
    //new AirFreshenerLiquid("lmao", "Blah bulah llaaah", 30, 20, 50),
    // new Perfume ...
    // new Fragrance ...
    new Perfume("Testus test", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 200, 20, 100, 20, (decimal)2131.232)
};

foreach (var liquid in liquids)
{
    
    liquid.DisplayInfo();
}
AdviceGenerator.GiveRandomAdvice();
    









