using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace GCIntranet.Pages.Extensions.TagHelpers
{
    /// <summary>
    ///  Extend the validation message tag helper to write errors the WET-BOEW way.
    /// </summary>
    [HtmlTargetElement("span", Attributes = AspValidationForAttributeName)]
    public class WbValidationMessageTagHelper : ValidationMessageTagHelper
    {
        private const string AspValidationForAttributeName = "asp-validation-for";

        public WbValidationMessageTagHelper(IHtmlGenerator generator)
            : base(generator)
        {
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);

            // Set a span tag around the original content.
            var content = output.Content.GetContent(NullHtmlEncoder.Default);
            var spanTag = new TagBuilder("span");
            spanTag.AddCssClass("label");
            spanTag.AddCssClass("label-danger");
            spanTag.InnerHtml.SetContent(content);
            output.Content.SetHtmlContent(spanTag);
        }
    }
}
