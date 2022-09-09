using Microsoft.AspNetCore.Mvc;

namespace AspNetViewComponentExample.Pages.Shared.Components.YoutubeVideo
{
    public class YoutubeVideoViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            string videoId, string cssClass = "")
        {
            var arguments = this.ViewComponentContext;

            var model = new YoutubeVideoViewModel
            {
                VideoId = videoId,
                Class = cssClass,
            };
            return View("YoutubeVideo", model);
        }
    }
}
