using OpenQA.Selenium;

namespace Zadanie1Selenium
{
    public class MediViewMain
    {
        private By MediaPack() => By.XPath("//body//a//img[@src='https://www.medicalgorithmics.pl/wp-content/uploads/2018/08/newssroom-media.png']");

        private By MediKontakt() => By.XPath("//body//a[@class='mega-menu-link' and contains(text(),'Kontakt')]");

        private By MediLogotypy() => By.XPath("//body//img[@title='icon-strategia-margins']");

        private By MediPics() => By.XPath("//body//img");

        private By MediWiecej() => By.XPath("(//body//div[contains(text(),'WIĘCEJ')])[1]");

        private By SearchButton() => By.XPath("//body//a[@class='search_button search_slides_from_header_bottom normal']");

        private By SearchInput() => By.XPath("//body//input[@placeholder='Szukaj:']");

        private By SearchElems() => By.XPath("//body//h3");

        private By SearchElem(string szukany) => By.XPath($"//body//h3//a[contains(text(),'{szukany}')]");

        private By NumberOfSites() => By.XPath("//body//div[@class = 'pagination']//li[not(a//i)]");

        public void ClickMedia() => MediaPack().Click();

        public void WaitToLoad() => MediWiecej().WaitToBeClickable();

        public void ClickKontakt() => MediKontakt().Click();

        public void ClickLogotypy() => MediLogotypy().Click();

        public string GetMediKontaktColor() => MediKontakt().GetColor();

        public void MoveToKontakt() => MediKontakt().MoveTo();

        public void Search(string search)
        {
            SearchButton().Click();
            SearchInput().SetText(search);
        }

        public int CountSearch() => SearchElems().CountElements();

        public bool CheckIfExists(string szukany) => SearchElem(szukany).CheckIfExists();

        public int CountPages() => NumberOfSites().CountElements();
    }
}
