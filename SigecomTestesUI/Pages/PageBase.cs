using OpenQA.Selenium.Appium.Windows;

namespace SigecomTestesUI.Pages
{
    public class PageBase
    {
        protected readonly ManipuladorService _manipuladorService;

        public PageBase(WindowsDriver<WindowsElement> driver)
        {
            _manipuladorService = new ManipuladorService(driver);
        }
    }
}