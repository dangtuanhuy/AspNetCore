// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
    public class TestComponent<TItem1, TItem2> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
global::System.Object TItem1 = null;
        }
        ))();
        ((System.Action)(() => {
global::System.Object TItem2 = null;
        }
        ))();
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
#line 6 "x:\dir\subdir\Test\TestComponent.cshtml"
 foreach (var item2 in Items2)
{
    

#line default
#line hidden
#line 9 "x:\dir\subdir\Test\TestComponent.cshtml"
__o = ChildContent(item2);

#line default
#line hidden
#line 10 "x:\dir\subdir\Test\TestComponent.cshtml"
        
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 12 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    [Parameter] TItem1 Item1 { get; set; }
    [Parameter] List<TItem2> Items2 { get; set; }
    [Parameter] RenderFragment<TItem2> ChildContent { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
