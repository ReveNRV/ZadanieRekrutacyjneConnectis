using System.IO;
using System.Threading;
using Xunit;

namespace Zadanie1Selenium
{
    public class Medicalalgorithimcs_TEST : DefaultTest
    {
        static void Main(string[] Args)
        {

        }

        [Fact]
        public void Medicalgorithmics_SUCCESS1()
        {

            MediViewMain mainView = new MediViewMain();
            //zweryfikuj, że Zakładka Kontakt zmienia kolor czcionki po najechaniu
            var color = mainView.GetMediKontaktColor();
            mainView.MoveToKontakt();
            var color2 = mainView.GetMediKontaktColor();
            Assert.NotEqual(color, color2);

            mainView.ClickKontakt();
            mainView.ClickMedia();
            mainView.ClickLogotypy();

            //zaczekaj aż pobierze
            Thread.Sleep(3000);

            //zweryfikuj, że plik pobrał się poprawnie na lokalny komputer zakładając, że zawsze pobierany jest do folderu "Downloads"
            Assert.True(File.Exists(@"C:\Users\Mleko\Downloads\logotypy.zip"));


        }

    }
}

