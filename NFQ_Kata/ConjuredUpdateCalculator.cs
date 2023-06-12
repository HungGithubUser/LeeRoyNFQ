namespace NFQ_Kata;

internal class ConjuredUpdateCalculator : NormalUpdateCalculator
{
    public ConjuredUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected override int GetQualityIncrementalUnit()
    {
        return base.GetQualityIncrementalUnit() * 2;
    }
}