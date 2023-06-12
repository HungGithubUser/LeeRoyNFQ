namespace NFQ_Kata;

internal class SulfurasUpdateCalculator : IUpdateCalculator
{
    private readonly int _currentItemSellIn;

    private const int LegendaryUnchangeableQuality = 80;

    public int GetUpdatedQuality() => LegendaryUnchangeableQuality;

    public int GetUpdatedSellIn() => _currentItemSellIn;

    public SulfurasUpdateCalculator(int currentItemSellIn)
    {
        _currentItemSellIn = currentItemSellIn;
    }
}