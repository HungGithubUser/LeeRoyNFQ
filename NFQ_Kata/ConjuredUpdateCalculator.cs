namespace NFQ_Kata;

internal class ConjuredUpdateCalculator : UpdateCalculatorTemplate
{
    public ConjuredUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected internal override int GetQualityIncrementalUnit()
    {
        return new NormalUpdateCalculator(CurrentItemSellIn, CurrentItemQuality).GetQualityIncrementalUnit() * 2;
    }
}