namespace NFQ_Kata;

internal class BackStageUpdateCalculator : UpdateCalculatorTemplate
{
    protected override int GetQualityIncrementalUnit() =>
        CurrentItemSellIn switch
        {
            > 10 => 1,
            <= 10 and > 5 => 2,
            <= 5 and > 0 => 3,
            _ => -CurrentItemQuality
        };

    public BackStageUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }
}