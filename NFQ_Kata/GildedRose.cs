namespace NFQ_Kata;

public class GildedRose
{
    private const string SulfurasItemName = "Sulfuras, Hand of Ragnaros";
    private const string BackstageItemName = "Backstage passes to a TAFKAL80ETC concert";
    private const string AgedBrieItemName = "Aged Brie";
    private const string ConjuredItemName = "Conjured Mana Cake";
    private readonly IList<Item> _items;

    public GildedRose(IList<Item> items) => _items = items;

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            UpdateSingleItem(item);
        }
    }

    private static void UpdateSingleItem(Item item)
    {
        var updateCalculator = GetUpdateCalculator(item);
        item.Quality = updateCalculator.GetUpdatedQuality();
        item.SellIn = updateCalculator.GetUpdatedSellIn();
    }

    private static IUpdateCalculator GetUpdateCalculator(Item item) =>
        item.Name switch
        {
            SulfurasItemName => new SulfurasUpdateCalculator(item.SellIn),
            BackstageItemName => new BackStageUpdateCalculator(item.SellIn, item.Quality),
            AgedBrieItemName => new AgedBrieUpdateCalculator(item.SellIn, item.Quality),
            ConjuredItemName => new ConjuredUpdateCalculator(item.SellIn, item.Quality),
            _ => new NormalUpdateCalculator(item.SellIn, item.Quality)
        };
}