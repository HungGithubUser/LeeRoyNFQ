namespace NFQ_Kata;

internal abstract class UpdateCalculatorTemplate : IUpdateCalculator
{
    private const int MaximumAllowedQuality = 50;
    private const int MinimumAllowedQuality = 0;
    protected readonly int CurrentItemQuality;
    protected readonly int CurrentItemSellIn;

    protected UpdateCalculatorTemplate(int currentItemSellIn, int currentItemQuality)
    {
        CurrentItemSellIn = currentItemSellIn;
        CurrentItemQuality = currentItemQuality;
    }

    public int GetUpdatedQuality()
    {
        return GetCorrectUpdatedQuality(CurrentItemQuality + GetQualityIncrementalUnit());
    }

    public int GetUpdatedSellIn()
    {
        return CurrentItemSellIn - 1;
    }

    protected abstract int GetQualityIncrementalUnit();

    private static int GetCorrectUpdatedQuality(int updatedQuality)
    {
        return updatedQuality >= MaximumAllowedQuality ? MaximumAllowedQuality :
            updatedQuality <= MinimumAllowedQuality ? MinimumAllowedQuality :
            updatedQuality;
    }
}