#pragma checksum "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b42e8500f1d3b70083f3e123af8f0fe27cd7c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Event_Views_Shared_Components_EventsComponent_Default), @"mvc.1.0.view", @"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml", typeof(AspNetCore.Areas_Event_Views_Shared_Components_EventsComponent_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
using Eventures.Areas.Event.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b42e8500f1d3b70083f3e123af8f0fe27cd7c2a", @"/Areas/Event/Views/Shared/Components/EventsComponent/Default.cshtml")]
    public class Areas_Event_Views_Shared_Components_EventsComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Eventures.Areas.Event.ViewModels.EventureEventViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
 foreach (var eventureEvent in Model)
{

#line default
#line hidden
            BeginContext(169, 35, true);
            WriteLiteral("    <div class=\"row\">\r\n        <h3>");
            EndContext();
            BeginContext(205, 18, false);
#line 9 "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
       Write(eventureEvent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(223, 19, true);
            WriteLiteral("</h3>\r\n        <h3>");
            EndContext();
            BeginContext(243, 19, false);
#line 10 "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
       Write(eventureEvent.Place);

#line default
#line hidden
            EndContext();
            BeginContext(262, 19, true);
            WriteLiteral("</h3>\r\n    </div>\r\n");
            EndContext();
#line 12 "D:\MVCFrameworks\Eventures\Eventures\Areas\Event\Views\Shared\Components\EventsComponent\Default.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Eventures.Areas.Event.ViewModels.EventureEventViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591