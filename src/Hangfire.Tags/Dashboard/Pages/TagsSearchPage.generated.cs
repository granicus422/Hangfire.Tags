﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Tags.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using Hangfire.Tags;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using Hangfire.Tags.Dashboard.Monitoring;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
    using Hangfire.Tags.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class TagsSearchPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");










            
            #line 10 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
  
    Layout = new LayoutPage("Tags");

    var options = TagsOptions.Options;
    var tagsListStyle = options.TagsListStyle;

    var allTags = new List<TagDto>();

    using (var tagStorage = new TagsStorage(Storage))
    {
        var monitor = tagStorage.GetMonitoringApi();
        // Show a page with all tags
        allTags = monitor.SearchWeightedTags().ToList();
    }



            
            #line default
            #line hidden
WriteLiteral("<script>\r\n        function go(tag) {\r\n            var baseUrl = \"");


            
            #line 28 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                      Write(Url.To("/tags/search/"));

            
            #line default
            #line hidden
WriteLiteral("\";\r\n            window.location = baseUrl + tag;\r\n        }\r\n</script>\r\n<div clas" +
"s=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 34 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n\r\n        <h1 class=\"page-header\">Tags " +
"search</h1>\r\n\r\n");


            
            #line 40 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
          

            if (!allTags.Any())
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"tags\">\r\n                    There are no tags found y" +
"et.\r\n                </div>\r\n");


            
            #line 47 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"tags row\">\r\n\r\n");


            
            #line 52 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                     if (tagsListStyle == TagsListStyle.LinkButton)
                    {
                        foreach (var t in allTags)
                        {
                            var intValue = (int)Math.Round(t.Percentage);

            
            #line default
            #line hidden
WriteLiteral("                            <a href=\"");


            
            #line 57 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                Write(Url.To("/tags/search/" + @t.Tag));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"");


            
            #line 57 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                                                        Write(intValue);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 57 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                                                                   Write(t.Tag);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");


            
            #line 58 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                        }
                    }
                    else if (tagsListStyle == TagsListStyle.Dropdown)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div class=\"col-md-12\">\r\n                            <dat" +
"alist id=\"hangfireTagsList\">\r\n");


            
            #line 64 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                 foreach (var t in allTags)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <option value=\"");


            
            #line 66 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                              Write(t.Tag);

            
            #line default
            #line hidden
WriteLiteral("\"></option>\r\n");


            
            #line 67 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral(@"                            </datalist>
                            <div class=""col-md-10"">
                                <input class=""form-control"" id=""selectedTag"" list=""hangfireTagsList"" autocomplete=""off"" placeholder=""Select a tag"" />
                            </div>
                            <div class=""col-md-2"">
                                <button id=""btn_go"" class=""btn"" onclick=""go(document.getElementById('selectedTag').value)"">Go</button>
                            </div>
                        </div>
");


            
            #line 76 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                    }
                    else
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <b>Not supported Tags List Style. Check TagsOptions</b>\r\n" +
"");


            
            #line 80 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n");


            
            #line 82 "..\..\Dashboard\Pages\TagsSearchPage.cshtml"
            }

        

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
