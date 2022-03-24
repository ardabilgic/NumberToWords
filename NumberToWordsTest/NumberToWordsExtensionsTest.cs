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
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(0), "s�f�r");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1), "bir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2), "iki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(9), "dokuz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(10), "on");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(11), "onbir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(94), "doksand�rt");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(100), "y�z");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(101), "y�zbir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(404), "d�rty�zd�rt");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(459), "d�rty�zellidokuz");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(802), "sekizy�ziki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(999), "dokuzy�zdoksandokuz");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1000), "bin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1802), "binsekizy�ziki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1995), "bindokuzy�zdoksanbe�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2022), "ikibinyirmiiki");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(14_800), "ond�rtbinsekizy�z");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(148_000), "y�zk�rksekizbin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(23_022), "yirmi��binyirmiiki");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(50_000), "ellibin");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(524_003), "be�y�zyirmid�rtbin��");            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_969_003), "birmilyondokuzy�zaltm��dokuzbin��");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(10_234_567), "onmilyonikiy�zotuzd�rtbinbe�y�zaltm��yedi");
            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(510_150_120), "be�y�zonmilyony�zellibiny�zyirmi");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(3_213_654_561), "��milyarikiy�zon��milyonalt�y�zellid�rtbinbe�y�zaltm��bir");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(65_111_101_501), "altm��be�milyary�zonbirmilyony�zbirbinbe�y�zbir");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2_645_913_931_103), "ikitrilyonalt�y�zk�rkbe�milyardokuzy�zon��milyondokuzy�zotuzbirbiny�z��");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(100_000_000_000_000), "y�ztrilyon");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_000), "birkatrilyon");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_001), "birkatrilyonbir");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(1_000_000_000_000_000_000), "birkentilyon");            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToWords(2_000_000_000_000_000_000), "ikikentilyon");

        }

        [TestMethod]
        public void Test_ConvertToTurkisLiras()
        {
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.25m), "yirmibe� Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.50m), "elli Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.99m), "doksandokuz Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.90m), "doksan Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(0.09m), "dokuz Kuru�");

            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(1.02m), "bir Lira ve iki Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(1.2m), "bir Lira ve yirmi Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.93m), "y�z Lira ve doksan�� Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.01m), "y�z Lira ve bir Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.10m), "y�z Lira ve on Kuru�");
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(100.1m), "y�z Lira ve on Kuru�");
            
            Assert.AreEqual(NumberToWordsExtensions.ConvertToTurkisLiras(598_143.72m), "be�y�zdoksansekizbiny�zk�rk�� Lira ve yetmi�iki Kuru�");

        }
    }
}
