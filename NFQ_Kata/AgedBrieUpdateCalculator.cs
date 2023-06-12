namespace NFQ_Kata;

internal class AgedBrieUpdateCalculator : UpdateCalculatorTemplate
{
    public AgedBrieUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected internal override int GetQualityIncrementalUnit()
    {
        return -new NormalUpdateCalculator(CurrentItemSellIn, CurrentItemQuality).GetQualityIncrementalUnit();
    }
}