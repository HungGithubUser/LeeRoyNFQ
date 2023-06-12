namespace NFQ_Kata;

internal class NormalUpdateCalculator : UpdateCalculatorTemplate
{
    public NormalUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected override int GetQualityIncrementalUnit() => CurrentItemSellIn <= 0 ? -2 : -1;
}