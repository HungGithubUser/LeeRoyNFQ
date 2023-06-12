namespace NFQ_Kata;

internal class ConjuredUpdateCalculator : UpdateCalculatorTemplate
{
    public ConjuredUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn, currentItemQuality)
    {
    }

    protected override int GetQualityIncrementalUnit() => CurrentItemSellIn <= 0 ? -4 : -2;
}