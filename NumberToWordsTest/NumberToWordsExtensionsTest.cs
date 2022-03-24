using NumberToWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberToWordsTest
{
    [TestClass]
    public class NumberToWordsExtensionsTest
    {
        [TestMethod]
        public void Test_ConvertToWords()
        {
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(0), "sýfýr");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1), "bir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2), "iki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(9), "dokuz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(10), "on");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(11), "onbir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(94), "doksandört");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(100), "yüz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(101), "yüzbir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(404), "dörtyüzdört");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(459), "dörtyüzellidokuz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(802), "sekizyüziki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(999), "dokuzyüzdoksandokuz");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1000), "bin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1802), "binsekizyüziki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1995), "bindokuzyüzdoksanbeþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2022), "ikibinyirmiiki");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(14_800), "ondörtbinsekizyüz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(148_000), "yüzkýrksekizbin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(23_022), "yirmiüçbinyirmiiki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(50_000), "ellibin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(524_003), "beþyüzyirmidörtbinüç");            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_969_003), "birmilyondokuzyüzaltmýþdokuzbinüç");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(10_234_567), "onmilyonikiyüzotuzdörtbinbeþyüzaltmýþyedi");
            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(510_150_120), "beþyüzonmilyonyüzellibinyüzyirmi");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(3_213_654_561), "üçmilyarikiyüzonüçmilyonaltýyüzellidörtbinbeþyüzaltmýþbir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(65_111_101_501), "altmýþbeþmilyaryüzonbirmilyonyüzbirbinbeþyüzbir");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2_645_913_931_103), "ikitrilyonaltýyüzkýrkbeþmilyardokuzyüzonüçmilyondokuzyüzotuzbirbinyüzüç");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(100_000_000_000_000), "yüztrilyon");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_000), "birkatrilyon");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_001), "birkatrilyonbir");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_000_000), "birkentilyon");            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2_000_000_000_000_000_000), "ikikentilyon");

        }

        [TestMethod]
        public void Test_ConvertToTurkisLiras()
        {
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.25m), "yirmibeþ Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.50m), "elli Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.99m), "doksandokuz Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.90m), "doksan Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.09m), "dokuz Kuruþ");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(1.02m), "bir Lira ve iki Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(1.2m), "bir Lira ve yirmi Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.93m), "yüz Lira ve doksanüç Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.01m), "yüz Lira ve bir Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.10m), "yüz Lira ve on Kuruþ");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.1m), "yüz Lira ve on Kuruþ");
            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(598_143.72m), "beþyüzdoksansekizbinyüzkýrküç Lira ve yetmiþiki Kuruþ");

        }
    }
}
