using Xunit;

namespace Zadanie1Selenium
{
    public class Medicalalgorithimcs_TEST2 : DefaultTest
    { 

        [Fact]
        public void Medicalgorithmics_SUCCESS2()
        {
            MediViewMain mainView = new MediViewMain();

            //zweryfikuj, że strona się załadowała
            mainView.WaitToLoad();
            //wyszukaj "Pocket ECG CRS"
            mainView.Search("Pocket ECG CRS");

            //Licz ilość wyników
            var elemCount = mainView.CountSearch();
            Assert.Equal(10, elemCount);
            //sprawdz czy istnieje PocketECG CRS – telerehabilitacja kardiologiczna
            var ifExists = mainView.CheckIfExists("PocketECG CRS – telerehabilitacja kardiologiczna");
            Assert.True(ifExists);
            //sprawdz czy sa dokladnie dwie strony
            var pageCounter = mainView.CountPages();
            Assert.Equal(2, pageCounter);
            
        }

    }
}
