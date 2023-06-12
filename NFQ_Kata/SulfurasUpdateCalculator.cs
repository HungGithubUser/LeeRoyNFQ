namespace NFQ_Kata;

internal class SulfurasUpdateCalculator : IUpdateCalculator
{
    private const int LegendaryUnchangeableQuality = 80;
    private readonly int _currentItemSellIn;

    public SulfurasUpdateCalculator(int currentItemSellIn)
    {
        _currentItemSellIn = currentItemSellIn;
    }

    public int GetUpdatedQuality()
    {
        return LegendaryUnchangeableQuality;
    }

    public int GetUpdatedSellIn()
    {
        return _currentItemSellIn;
    }
}