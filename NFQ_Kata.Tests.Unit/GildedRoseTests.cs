namespace NFQ_Kata.Tests.Unit;

[TestClass]
public class GildedRoseTests
{
    [TestMethod]
    public void ShouldCalculateAgedBrieItemCorrectly()
    {
        var agedBrieItem = new Item
        {
            Name = "Aged Brie", SellIn = 2, Quality = 0
        };

        var list = new List<Item>
        {
            agedBrieItem
        };

        var sut = new GildedRose(list);
        sut.UpdateQuality();
        Assert.AreEqual(1, agedBrieItem.SellIn);
        Assert.AreEqual(1, agedBrieItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(0, agedBrieItem.SellIn);
        Assert.AreEqual(2, agedBrieItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-1, agedBrieItem.SellIn);
        Assert.AreEqual(4, agedBrieItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-2, agedBrieItem.SellIn);
        Assert.AreEqual(6, agedBrieItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-3, agedBrieItem.SellIn);
        Assert.AreEqual(8, agedBrieItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-4, agedBrieItem.SellIn);
        Assert.AreEqual(10, agedBrieItem.Quality);
    }

    [TestMethod]
    public void ShouldCalculateSulfurasItemCorrectly()
    {
        var sulfurasItem = new Item
        {
            Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80
        };
        var list = new List<Item>
        {
            sulfurasItem
        };
        var sut = new GildedRose(list);
        sut.UpdateQuality();
        Assert.AreEqual(0, sulfurasItem.SellIn);
        Assert.AreEqual(80, sulfurasItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(0, sulfurasItem.SellIn);
        Assert.AreEqual(80, sulfurasItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(0, sulfurasItem.SellIn);
        Assert.AreEqual(80, sulfurasItem.Quality);
    }

    [TestMethod]
    public void ShouldCalculateConjuredItemCorrectly()
    {
        var conjuredItem = new Item
        {
            Name = "Conjured Mana Cake", SellIn = 3, Quality = 6
        };
        var list = new List<Item>
        {
            conjuredItem
        };
        var sut = new GildedRose(list);
        sut.UpdateQuality();
        Assert.AreEqual(2, conjuredItem.SellIn);
        Assert.AreEqual(4, conjuredItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(1, conjuredItem.SellIn);
        Assert.AreEqual(2, conjuredItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(0, conjuredItem.SellIn);
        Assert.AreEqual(0, conjuredItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-1, conjuredItem.SellIn);
        Assert.AreEqual(0, conjuredItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-2, conjuredItem.SellIn);
        Assert.AreEqual(0, conjuredItem.Quality);
        conjuredItem.Quality = 10;
        sut.UpdateQuality();
        Assert.AreEqual(-3, conjuredItem.SellIn);
        Assert.AreEqual(6, conjuredItem.Quality);
    }

    [TestMethod]
    public void ShouldCalculateBackStageItemCorrectly()
    {

        var backStageItem1 = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 12,
            Quality = 23
        };
        var backStageItem2 = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 5,
            Quality = 49
        };
        var list = new List<Item>
        {
            backStageItem1,
            backStageItem2
        };
        var sut = new GildedRose(list);
        sut.UpdateQuality();
        Assert.AreEqual(11, backStageItem1.SellIn);
        Assert.AreEqual(24, backStageItem1.Quality);
        Assert.AreEqual(4, backStageItem2.SellIn);
        Assert.AreEqual(50, backStageItem2.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(10, backStageItem1.SellIn);
        Assert.AreEqual(25, backStageItem1.Quality);
        Assert.AreEqual(3, backStageItem2.SellIn);
        Assert.AreEqual(50, backStageItem2.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(9, backStageItem1.SellIn);
        Assert.AreEqual(27, backStageItem1.Quality);
        Assert.AreEqual(2, backStageItem2.SellIn);
        Assert.AreEqual(50, backStageItem2.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(8, backStageItem1.SellIn);
        Assert.AreEqual(29, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(7, backStageItem1.SellIn);
        Assert.AreEqual(31, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(6, backStageItem1.SellIn);
        Assert.AreEqual(33, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(5, backStageItem1.SellIn);
        Assert.AreEqual(35, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(4, backStageItem1.SellIn);
        Assert.AreEqual(38, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(3, backStageItem1.SellIn);
        Assert.AreEqual(41, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(2, backStageItem1.SellIn);
        Assert.AreEqual(44, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(1, backStageItem1.SellIn);
        Assert.AreEqual(47, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(0, backStageItem1.SellIn);
        Assert.AreEqual(50, backStageItem1.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-1, backStageItem1.SellIn);
        Assert.AreEqual(0, backStageItem1.Quality);
    }

    [TestMethod]
    public void ShouldCalculateNormalItemCorrectly()
    {
        var normalItem = new Item
        {
            Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20,
        };
        var list = new List<Item>
        {
            normalItem
        };
        var sut = new GildedRose(list);
        sut.UpdateQuality();
        Assert.AreEqual(9, normalItem.SellIn);
        Assert.AreEqual(19, normalItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(8, normalItem.SellIn);
        Assert.AreEqual(18, normalItem.Quality);
        normalItem.SellIn = 1;
        normalItem.Quality = 4;
        sut.UpdateQuality();
        Assert.AreEqual(0, normalItem.SellIn);
        Assert.AreEqual(3, normalItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-1, normalItem.SellIn);
        Assert.AreEqual(1, normalItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-2, normalItem.SellIn);
        Assert.AreEqual(0, normalItem.Quality);
        sut.UpdateQuality();
        Assert.AreEqual(-3, normalItem.SellIn);
        Assert.AreEqual(0, normalItem.Quality);
    }
}