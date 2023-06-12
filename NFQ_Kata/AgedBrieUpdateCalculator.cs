namespace NFQ_Kata;

internal class AgedBrieUpdateCalculator : UpdateCalculatorTemplate
{
    protected override int GetQualityIncrementalUnit() => CurrentItemSellIn <= 0 ? 2 : 1;

    public AgedBrieUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }
}