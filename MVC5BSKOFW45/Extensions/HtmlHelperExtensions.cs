using Newtonsoft.Json;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using MVC5BSKOFW45.ViewModels;


public static class HtmlHelperExtensions
{
    public static HtmlString HtmlConvertToJson(this HtmlHelper htmlHelper, object model)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented
        };

        return new HtmlString(JsonConvert.SerializeObject(model, settings));
    }

}
