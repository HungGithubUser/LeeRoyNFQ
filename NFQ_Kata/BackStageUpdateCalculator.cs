namespace NFQ_Kata;

internal class BackStageUpdateCalculator : UpdateCalculatorTemplate
{
    public BackStageUpdateCalculator(int currentItemSellIn, int currentItemQuality) : base(currentItemSellIn,
        currentItemQuality)
    {
    }

    protected internal override int GetQualityIncrementalUnit()
    {
        return CurrentItemSellIn switch
        {
            > 10 => 1,
            <= 10 and > 5 => 2,
            <= 5 and > 0 => 3,
            _ => -CurrentItemQuality
        };
    }
}