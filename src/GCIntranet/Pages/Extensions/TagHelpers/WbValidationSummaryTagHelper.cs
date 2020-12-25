using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading;

namespace GCIntranet.Pages.Extensions.TagHelpers
{
    /// <summary>
    ///  Extend the validation summary tag helper to write the summary container the WET-BOEW way.
    /// </summary>
    [HtmlTargetElement("div", Attributes = AspValidationSummaryAttributeName)]
    public class WbValidationSummaryTagHelper : ValidationSummaryTagHelper
    {
        private const string AspValidationSummaryAttributeName = "asp-validation-summary";
        private readonly string languageCode;

        public WbValidationSummaryTagHelper(IHtmlGenerator generator)
            : base(generator)
        {
            languageCode = Thread.CurrentThread.CurrentUICulture.ThreeLetterISOLanguageName;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var postContent = output.PostContent;
            var pattern = @"<li>(.*)</li>";

            if (!postContent.IsEmptyOrWhiteSpace)
            {
                output.AddClass("alert", HtmlEncoder.Default);
                output.AddClass("alert-danger", HtmlEncoder.Default);

                var matches = Regex.Matches(postContent.GetContent(), pattern);
                var errorCount = matches.Count;

                // Translate the "h2" text, if necessary.
                var prefix = languageCode == "fra" ? "Le formulaire n'a pu être soumis car" : "The form could not be submitted because";
                var suffix = languageCode == "fra" ? "erreurs ont été trouvées." : "errors were found.";

                if (errorCount == 1)
                {
                    suffix = languageCode == "fra" ? "erreur a été trouvée" : "error was found.";
                }

                output.PreContent.AppendHtml($"<h2>{prefix} {errorCount} {suffix}</h2>");
            }
        }
    }
}
