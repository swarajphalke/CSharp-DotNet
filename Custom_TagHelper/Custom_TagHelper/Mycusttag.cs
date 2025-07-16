using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace Custom_TagHelper
{
    [HtmlTargetElement("Demo")]
    public class MyCustTag : TagHelper
    {
        public string Name { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustomTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<span>Hi ! {0}</span>", this.Name);

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
