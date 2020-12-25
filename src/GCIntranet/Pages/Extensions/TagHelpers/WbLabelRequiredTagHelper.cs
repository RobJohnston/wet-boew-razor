using System;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GCIntranet.Pages.Extensions.TagHelpers
{
    /// <summary>
    /// Extend the label tag helper to write labels the WET-BOEW way.
    /// </summary>
    /// <example>
    /// https://wet-boew.github.io/wet-boew/demos/formvalid/formvalid-en.html.
    /// </example>
    [HtmlTargetElement("label", Attributes = AspForAttributeName)]
    public class WbLabelRequiredTagHelper : LabelTagHelper
    {
        private const string AspForAttributeName = "asp-for";
        private readonly string languageCode;

        public WbLabelRequiredTagHelper(IHtmlGenerator generator)
            : base(generator)
        {
            languageCode = Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            await base.ProcessAsync(context, output);

            if (For.Metadata.IsRequired)
            {
                // Add the "required" class to the label.
                output.AddClass("required", HtmlEncoder.Default);

                // Set the span tag around the original content of the label.
                var content = output.Content.GetContent(NullHtmlEncoder.Default);
                var spanTag = new TagBuilder("span");
                spanTag.AddCssClass("field-name");
                spanTag.InnerHtml.SetContent(content);
                output.Content.SetHtmlContent(spanTag);

                // Translate the "required" text, if necessary.
                var requiredText = languageCode == "fra" ? "(obligatoire)" : "(required)";

                // Append the strong after the span.
                output.Content.Append(" ");
                var strongTag = new TagBuilder("strong");
                strongTag.AddCssClass("required");
                strongTag.InnerHtml.Append(requiredText);
                output.Content.AppendHtml(strongTag);
            }
        }
    }
}
