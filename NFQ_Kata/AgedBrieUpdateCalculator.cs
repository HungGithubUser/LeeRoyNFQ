namespace NFQ_Kata;

internal class AgedBrieUpdateCalculator : UpdateCalculatorTemplate
{
    public AgedBrieUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected override int GetQualityIncrementalUnit()
    {
        return CurrentItemSellIn <= 0 ? 2 : 1;
    }
}