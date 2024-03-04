using OpenQA.Selenium.Appium.Windows;

namespace SigecomTestesUI
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