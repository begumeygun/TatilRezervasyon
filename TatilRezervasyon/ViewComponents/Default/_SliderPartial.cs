using Microsoft.AspNetCore.Mvc;

namespace TatilRezervasyon.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
