#pragma checksum "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "620b25e97296e4e946a116fdb8abfa735dfe4de8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_CreateMatches), @"mvc.1.0.view", @"/Views/Application/CreateMatches.cshtml")]
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
#nullable restore
#line 1 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\_ViewImports.cshtml"
using Pare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\_ViewImports.cshtml"
using Pare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620b25e97296e4e946a116fdb8abfa735dfe4de8", @"/Views/Application/CreateMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62262097ad5527c4d294841d7047f5d2c4c53ed1", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_CreateMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateQuery>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("access()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "620b25e97296e4e946a116fdb8abfa735dfe4de83539", async() => {
                WriteLiteral(@"<script type=""text/javascript"">
	// TOUCH-EVENTS SINGLE-FINGER SWIPE-SENSING JAVASCRIPT
	// Courtesy of PADILICIOUS.COM and MACOSXAUTOMATION.COM
	
	// this script can be used with one or more page elements to perform actions based on them being swiped with a single finger

	var triggerElementID = null; // this variable is used to identity the triggering element
	var fingerCount = 0;
	var startX = 0;
	var startY = 0;
	var curX = 0;
	var curY = 0;
	var deltaX = 0;
	var deltaY = 0;
	var horzDiff = 0;
	var vertDiff = 0;
	var minLength = 72; // the shortest distance the user may swipe
	var swipeLength = 0;
	var swipeAngle = null;
	var swipeDirection = null;
	
	// The 4 Touch Event Handlers
	
	// NOTE: the touchStart handler should also receive the ID of the triggering element
	// make sure its ID is passed in the event call placed in the element declaration, like:
	// <div id=""picture-frame"" ontouchstart=""touchStart(event,'picture-frame');""  ontouchend=""touchEnd(event);"" ontouchmove=""touch");
                WriteLiteral(@"Move(event);"" ontouchcancel=""touchCancel(event);"">

	function touchStart(event,passedName) {
		// disable the standard ability to select the touched object
		event.preventDefault();
		// get the total number of fingers touching the screen
		fingerCount = event.touches.length;
		// since we're looking for a swipe (single finger) and not a gesture (multiple fingers),
		// check that only one finger was used
		if ( fingerCount == 1 ) {
			// get the coordinates of the touch
			startX = event.touches[0].pageX;
			startY = event.touches[0].pageY;
			// store the triggering element ID
			triggerElementID = passedName;
		} else {
			// more than one finger touched so cancel
			touchCancel(event);
		}
	}

	function touchMove(event) {
		event.preventDefault();
		if ( event.touches.length == 1 ) {
			curX = event.touches[0].pageX;
			curY = event.touches[0].pageY;
		} else {
			touchCancel(event);
		}
	}
	
	function touchEnd(event) {
		event.preventDefault();
		// check to see if more t");
                WriteLiteral(@"han one finger was used and that there is an ending coordinate
		if ( fingerCount == 1 && curX != 0 ) {
			// use the Distance Formula to determine the length of the swipe
			swipeLength = Math.round(Math.sqrt(Math.pow(curX - startX,2) + Math.pow(curY - startY,2)));
			// if the user swiped more than the minimum length, perform the appropriate action
			if ( swipeLength >= minLength ) {
				caluculateAngle();
				determineSwipeDirection();
				processingRoutine();
				touchCancel(event); // reset the variables
			} else {
				touchCancel(event);
			}	
		} else {
			touchCancel(event);
		}
	}

	function touchCancel(event) {
		// reset the variables back to default values
		fingerCount = 0;
		startX = 0;
		startY = 0;
		curX = 0;
		curY = 0;
		deltaX = 0;
		deltaY = 0;
		horzDiff = 0;
		vertDiff = 0;
		swipeLength = 0;
		swipeAngle = null;
		swipeDirection = null;
		triggerElementID = null;
	}
	
	function caluculateAngle() {
		var X = startX-curX;
		var Y = curY-startY;
		v");
                WriteLiteral(@"ar Z = Math.round(Math.sqrt(Math.pow(X,2)+Math.pow(Y,2))); //the distance - rounded - in pixels
		var r = Math.atan2(Y,X); //angle in radians (Cartesian system)
		swipeAngle = Math.round(r*180/Math.PI); //angle in degrees
		if ( swipeAngle < 0 ) { swipeAngle =  360 - Math.abs(swipeAngle); }
	}
	
	function determineSwipeDirection() {
		if ( (swipeAngle <= 45) && (swipeAngle >= 0) ) {
			swipeDirection = 'left';
		} else if ( (swipeAngle <= 360) && (swipeAngle >= 315) ) {
			swipeDirection = 'left';
		} else if ( (swipeAngle >= 135) && (swipeAngle <= 225) ) {
			swipeDirection = 'right';
		} else if ( (swipeAngle > 45) && (swipeAngle < 135) ) {
			swipeDirection = 'down';
		} else {
			swipeDirection = 'up';
		}
	}
    function keyEv(event) {
        var x = event.which || event.keyCode;
        console.log(x);
    }	
	function processingRoutine() {
		var swipedElement = document.getElementById(triggerElementID);
		if ( swipeDirection == 'left' ) {
                 var url =document.ge");
                WriteLiteral(@"tElementById(""no"").outerHTML.split(""\"""")[3].replaceAll(""amp;"","""");
                document.getElementById('imag').classList.add(""rotate2"");
                // do something with the url client side variable, for example redirect
                  window.location.href = url;           
			// REPLACE WITH YOUR ROUTINES
		} else if ( swipeDirection == 'right' ) {
            //right = good 
                document.getElementById('imag').classList.add(""rotate"");
                var url =document.getElementById(""yes"").outerHTML.split(""\"""")[3].replaceAll(""amp;"","""");
                window.location.href = url;
		} 
	}
document.onkeydown = function() {
    switch (window.event.keyCode) {
        case 37:
            var url =document.getElementById(""no"").outerHTML.split(""\"""")[3].replaceAll(""amp;"","""");
            document.getElementById('imag').classList.add(""rotate2"");
            window.location.href = url;  
        console.log(""left"");
         break;
        case 39:
");
                WriteLiteral(@"             document.getElementById('imag').classList.add(""rotate"");
             var url =document.getElementById(""yes"").outerHTML.split(""\"""")[3].replaceAll(""amp;"","""");
                window.location.href = url;
         break;
    }
};

</script>
<style>
        .rotate {
        animation: rotation 2s infinite linear;
        }

        ");
                WriteLiteral("@keyframes rotation {\r\n            from {\r\n                transform: rotate(0deg);\r\n            }\r\n            to {\r\n");
                WriteLiteral("                transform:matrix(0.81,0.59,-0.59,0.81,200,-200);\r\n");
                WriteLiteral("\r\n            }\r\n        }\r\n        .rotate2 {\r\n        animation: rotation2 2s infinite linear;\r\n        }\r\n\r\n        ");
                WriteLiteral("@keyframes rotation2 {\r\n            from {\r\n                transform: rotate(0deg);\r\n            }\r\n            to {\r\n");
                WriteLiteral(@"                transform:matrix(0.34,-0.22,0.22,0.34,-200,-200);

            }
        }

    #yes{
        visibility: hidden;
    }
    #no{
        visibility: hidden;
    }
    img{
        display: block;
        margin-left: auto;
        margin-right: auto;
        max-width: 100%;
        height: auto;
      }
      
</style>
<script>
function access() {
	console.log(""helo"");
   var iframe = document.getElementById(""nice"");
   var innerDoc = iframe.contentWindow.document.getElementsByTagName(""H1"")[0];
   console.log(innerDoc);
}
</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    \r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "620b25e97296e4e946a116fdb8abfa735dfe4de811464", async() => {
                WriteLiteral(@"
<div id=my_msg>

    <div id=""swipeBox"" onkeydown=""swipeBox"" ontouchstart=""touchStart(event,'swipeBox');"" ontouchend=""touchEnd(event);"" ontouchmove=""touchMove(event);"" ontouchcancel=""touchCancel(event);"" style=""position:relative;width:100%;height:100%;"">
    <div onload=""init()"">
    <h1 data-role=""page"" id=""pageone"">");
#nullable restore
#line 222 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
                                 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h2>");
#nullable restore
#line 223 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n    <img");
                BeginWriteAttribute("src", " src=", 7408, "", 7413, 0);
                EndWriteAttribute();
                WriteLiteral(" ");
#nullable restore
#line 225 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
         Write(ViewBag.ImageUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(" alt=\"Italian Trulli\" id = imag >\r\n\t<p>");
#nullable restore
#line 226 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
  Write(ViewBag.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t<p>");
#nullable restore
#line 227 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
  Write(ViewBag.Menu);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n\t<iframe id = \"nice\" class=\"embed-responsive-item\"");
                BeginWriteAttribute("src", "  src=", 7569, "", 7588, 1);
#nullable restore
#line 228 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
WriteAttributeValue("", 7575, ViewBag.Menu, 7575, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"400\" height=\"400\"></iframe>\r\n\t<iframe class=\"embed-responsive-item\"");
                BeginWriteAttribute("src", "  src=", 7663, "", 7687, 1);
#nullable restore
#line 229 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
WriteAttributeValue("", 7669, ViewBag.menuPhoto, 7669, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"400\" height=\"400\"></iframe>\r\n\r\n   <div id = \"yes\"> ");
#nullable restore
#line 231 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
               Write(Html.ActionLink("yes!!", "CreateMatches", new { sessionId = ViewBag.sessionId, index = ViewBag.index, name = ViewBag.name,score = 1, enough = ViewBag.Enough }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n   <div id = \"no\"> ");
#nullable restore
#line 232 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Application\CreateMatches.cshtml"
              Write(Html.ActionLink("No Thanks", "CreateMatches", new { sessionId = ViewBag.sessionId, index = ViewBag.index, name = ViewBag.name,score = 0, enough = ViewBag.Enough}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n    </div>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateQuery> Html { get; private set; }
    }
}
#pragma warning restore 1591
