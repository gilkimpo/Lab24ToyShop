#pragma checksum "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372f0a67d8dec1f1e6165e566e2d83521153aae6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\_ViewImports.cshtml"
using ToyShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\_ViewImports.cshtml"
using ToyShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372f0a67d8dec1f1e6165e566e2d83521153aae6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d830a5a13d4c542add181a94c36155cc1fc54282", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDBContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome To The Toy Shop</h1>\r\n\r\n\r\n</div>\r\n<li class=\"nav-item\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372f0a67d8dec1f1e6165e566e2d83521153aae65240", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</li>\r\n<li class=\"nav-item\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372f0a67d8dec1f1e6165e566e2d83521153aae66926", async() => {
                WriteLiteral("Login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</li>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
 if (HttpContextAccessor.HttpContext.Session.GetString("session_username") != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        Logged in username from Session is: ");
#nullable restore
#line 23 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
                                       Write(HttpContextAccessor.HttpContext.Session.GetString("session_username"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 24 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
           
}

else
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>
        <text>You are not logged in.</text>
        <br />
        <br />
        <text>To LOGIN</text><a href=https://localhost:5001/Home/Login> click here.</a>
        <br />
        <text>To REGISTER</text><a href=https://localhost:5001/Home/Register> click here. </a>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </h2>
");
#nullable restore
#line 45 "C:\Users\gilki\source\repos\ToyShop\ToyShop\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372f0a67d8dec1f1e6165e566e2d83521153aae610018", async() => {
                WriteLiteral(@"
        <style>
            body {
                background-image: url(data:image/webp;base64,UklGRn4QAABXRUJQVlA4IHIQAABQSgCdASqqAKoAPk0ijUUioiESSW7EKATEtIBsZlObmf8r4j+W7z/7becz5JYkHyH7o/g/7d+5Hx47c/iN/c+oF+K/zH/Gf1z9x+HNAF+ff2v/Qfml/cPii+p/4Xo78z3uAfqv/n/zW/uHzz/yvDt+/f672A/5z/V/+R/jPxz+RX/W/0H5l+4/6Q/6f+S/y/yGfy/+tf8H+7do79vfZL/ZL/6mjzJz/IDv0mAImQHfpL+n1OKNK0xEEgTCdU7r/FLgAuCNvfyP35yJd6ZONhTMwia0kSECQlfqv2kxKKVBRidk1xltRtElrSHoh4exrJ1kqRCdGVm37sCfuvEfYWgR6MA/DFwgoZhkKW7QchQobJhtUujKQtnH27GmUBPkpNff59inbynqAxsh2FPH5dswFlO5ekHaJfnBz3aFMSBO+7JykYnDef014fjVwZi5wjgESPRuxn6OhZCENVyejC0YXFP7YtP0IrkogYgB6qJPK3TPyI1o824cwb4Wi0zB0DOVTudj/7XR86h6JvEEAM1rpV7PF/m58OdwcYwV8tFuBHXm6/4miIJrSanouvmw8sjd5GryeceubTpoAe5jLVdDuCbAF8MHzpuEVc3UVtVAqloZ++7W/jh7mEvvPpUfe4Maxy5tagMdcVXHZYqr2+lMmQGtX/e2Z2pdl+t7mE30cwwNUQEq7bzD+xNM7rol97UEBmHG82wJc8mbyPsMImwLqlUURh2V3rc4p19tLOegKOKG01fDCf52oFBmZ4ANSDf5nNTQgKoPLq87UafC+vvtXph6BOmPbQv5ezAA/v/IokPaCj4sJ/8gx62xMUX7jF6O4h32Rjb5FRV9jWEwM4R8dN6OqEaYIAglJ7t1/+Lq2h8JjvzorqYu1R0gXkCGl+BB");
                WriteLiteral(@"3nMYk8y2qL/48RFcmXeA5FhjoP1MPILkXViXEc+xTfzqdwvLQ5m0FPyIwIHL+lf/xCu3DfTVe8iEMV65UK7ruAa1yvXu7GdA2cDH6DvGIKlFmAom5ngvyBw4UjaRzNUrTLgJQ8kNE5WXtcvCbmUXOwzbch9uNPwg/wKAYkByyYQVtUB8SUozOORc3oYQzjVAP6WM3s0RHxS5GxxUGTXWVs4lFydU7VNi4bRyAb/E3bniiUGeCNY7z2LYcPlvbXbWzs4uZlVIo8xCRQo9JIxOhwp1+ZCW0FyDqra/2eDspJWu+jlCIUGpOlfv/mFN8nXZ8plPiCTX3cTDpZ6KTKcGAUWjSL8VbwNWx25dDvVopt2MSPBlz+JgvaGlJvukcBKjXh7UZPxsnwjSxE7Z38j2l8TH6brbiZ9LBxXiZyrjmh+dtbKhp+rHt33hFXfY3TR8twH7xl3x1Cceif64yMMzQBcZZ0tAZhX4vE8lnLC0UDqEquwvQbpAvzgi2tjiTAJwwrhFox+IQhS3wfy+zMal6xKRWID1qjIf2MgTYs9i9+QuPrLBT9Bngj5oIuM1u6C2nIokQ09s8VnvKgMUs0rkqWbI8gcQV3XkspLMdb8eDIj9DzPInX3wqRt8DONNK0eDcab4qgK7zChre6vOR19uIikhx+theOCN89OEATSPO1Rp7mXAIK1FNv1RjdTmAHFAY9ZX3bYgsNnW0RLXpBKs7jY/aQ91dj7lK7japcvwF6iVHwMOsf6YFvc2KfESNJnZbO7kTfJmTbDFNWqrLYQ3KMAvVgxYfHmyPAoQPvVud0pWhzzaBwKngKm0cvMJtz4nnllAa/eGsLWOo7GLcahGqclXs+xQjbqaKZOQw2dZ1mnOrXjMWM+ozDAlZjBwAikHV4RR5HUAfYx/yEeIGXwThycXyyAfznAKDaeu0H8lB5wD2up7Mg0ubtzAUE8pfXqMLsDkIjn+ECWTdt81piCwTgbxqTREhB2UYPpK8e3DX4yig3Y6vOqCPZ2sZkrcTMHB");
                WriteLiteral(@"TwPyfIiNh95BxTE88OMCS/bRqQVao5snfxLViAf9oK0v/Y6bRaBkFSxQ4WKoJ9DeHc36oZGLz/Dfq38wiCxZAOzKiTLDLe3QWfsV/U/2/YXspP/SF5nRnG6mLqCUQdFHIGYHKIhudbIh+zCk5P0fFlCO218/KoO7gBVK2Hd5QZ0+bybMwFkgyb3xfj+Y6IMNySy20N/NAqD7ub7khWm9bYZWxY15P9+sKSi4BLVyCT5puYZXYx3JhScMR3MT4bs/MkNo6n2l1PnnvTmUYqpUhEVCRvfl/k7oLj4aTydc/D/93cigeMPK61K0zUd4kpBx8EHtoFZuNIxKddH4PEBYH+iRKd+pDYi33Vb4mjw+dw2B2FJe3jSlAQvWuxZ+/Dt4qdc7b+jTV2t7nj1gB0F4WIvpncHs6g8cqYMkZU7JeMnxJs4ZQjIfgdUgqZKv6ceDjPP8f/w+2Gi6j8S3xYzbSumWZYDQFRXBpPPHUr3kNE+tgi0N4k9IAV3J2WftvJRR3+NOZfgNIA/GKxyWBunfWJcvwTaGd5b0h7mHJoZvn6nOrSetZY8895wbi6XyQCnQAW48LtPyl2BPtkA1XhAh/QIUauZ468ILb+iKHUagR20BLjFim9HKXGIyAz9buBn3/qxMgInyMW55FNSbxuMBs4/4y3PwnOemV/kpqrY27wduZcdXBJ6rjx/9QC3jhcZSn8JceaM/m3Zf7v0RyHC1jL/S634gyO0/PWyb5y3aomkghDgcW1U3NEp/WxmzfFTMT7ASdiBXbqf2zCtxzntzm+4D2W/O9hdkOGEtLoj0iXTW0rcNSNjxAxcqUWs0idBqQWHbzSRU01D62LO06o4tpbihnpuOKFtaQEubuCcU1wb5BMl02O5iHAgb9vx425vFKz4rDYBIbUt+IB3O1GHkagr+pghaqb1CShf+GmNWod1RVghgnOdR9ndg13VacvnteOlBQBM9D5P4OROUL6eLXWEh3UXhbTSRlasKuw1LmaTWH27EyY385+wihxbZN+4/");
                WriteLiteral(@"MGyVfHpmV+poBrVnOIp02TbUnBNkQKb5pAsYjGE3WNwDqGlAZHjF/R8xUjq30vaLmFwSedAqTVochBcBE6Uw6J05VYphqC8ryc7oScu806qSMS/hdNWyDK9aEoEkOnApL7PUAtjey4/fdOFgF9Ah9Uh9lWtJ7q/UMhKo+IyUm9ZgXxyTJnFVN9joH9h0woOoc2uX6Yjd8OxluT3B+bAPs/BsV2G5nl0j8CuROHZjkXad4vNMpzxqAd6e+JisHXNaW641kZ1TrfpuOaK+tVhFHhlYuPWvTXPlS526sXJ9MhWvYQlIoRr0PXM+ARYI6RCBpGC7DtLqrqLHYifVNUnU/3mhiDrgMwbrbggb46j+nyczw2iMqzuUhos6rT2k8AnCDgnEUfvqIIvdrYTOmH40d/bWmTfC5sAJ/A+XZtGbmEf2Qc961wfn9jNhbebqdS1nb2uZpM4ANlwWP0yOwZNBKw78bDbIE1VZtK1Q0OsXu8go000MTA+f/hjFpHA6tZhI/qo0Yu/800cuv2PHf2TdtTz9d2FZeA0k6FvMMT3bX5WBiTOJKBlfUL8vRXAXim06JgVYZC3wOvbMgRIqnWQ5zUBatSn8NL/FYPoTh95hiKh3DGasRF2k9grmyAYbPlgWLRUoelgOiJGNjBcl/x634g7b4CfTnFuViOSHZM0ePwJ+PPK34DiN3zeM4k4y6ghFJr6G82RTFJpr2SJi9L7Vqd6jTg+H3095/8AFk6DQyn4LbVRniBcxpQ0jDEEhaLNFh8iUu8JTWkIJmtl5mMw2S0smCsMubR1GwyX2Vd2V8l0fBf6u/rCXCM8pTYy71df7Ov8tA1Z/x3SLmr0NzPFTCeTLo+n2gVZjoFXq2UjBYTSo4H+28ZWI/8+5ecLbhxpSgCrdIApzJB6DFbhsgN9IA/8SjIlkzj57tB4fbiwwiEv224frYl99j+oGSy0n/VwzYjC/cAzxkWTvw5WBWOxkF16XRq38w8zM7o3xF94aj+fy+RSJ/8WCpH5uNiQvw898");
                WriteLiteral(@"kLpeUPXEU9O186RWzuUaaAdPIRVHYNmJNt3vJ6Bn5s8+854kdRWgU5Y2/Ch4gjJjm9VYzUYGX5MtKKKYLT5QVnfLlmlyEd2MYgHe+41kfxCI3hPQeYilA+3NqtIuiW6L+whcQTEH27lYH7zNbROJ9xg33LlHqSafC8b14sfF/5Fkv4olvhQ3fNrKQcQXGd15txiayyS7LwT/UXhBOzJICJcX99yBuKzpR1kwvz1aowBQdksIpaxkzk3aynwryGg7bzwXWW9dLdPgcokuNc/uvvtV9E/vGdVLkHylZCbwgNkjA3hy1kCM0k2mZ1BP5mJA9SumNIW84Sa1lkJrOU1opD9VRk1gKQYY7YUJjpCeKU1s5DjWmjzgYOmGAi/tIyOfXgUisDu/GhZc7YDm/09wWe/XcUVxeFOIfhNR6xXt142dg5gVeUTZAzTz4huciZeD9hxAxdg5KRnXB789a4S67hJtlTm6L6+B3pE3/Wv9vUntEQAB4v6lJeMN/tw/zEvtsjg5/UeB0XcBsYuw22GGxuBdOUuXw5nC/cnJ5Tcv3Ct8F2dfPVUV85ibZ1Ra48MkR6QNN+jF74CG71grd0rhc7VGvZvU3FatD61kmDOFgdKyCnQPfLhmEX/Y1SsTcW0obEmae+zRgW4J+/Y2sYeWhjsENMnmu6yP/XJcwaXQHrpW4UHYqw4f05KF05Jdk4TY+F1Q2YoXdvcHcuH8MwoXzuyPdpYeFD2t0Jbw2n1mKyahtoNXXcbsgRcSolhI/tJA9yeo/CNVH0bHz7EcKjfVPro4O725CsOYi7bZsgA+eBQ7MraqJfdnXUnXfBA0VAbhIndEUmESQ9/xXEYYiJMhiLenhTcCZKHfynyl5iSu+kCkmJcXC6sCWfUOPoybrMw9dMUNUWnzwcahtoP2KZd6CTjvTqZqg8BBORz3nM3ZoNXCUdbhe06FCG8Le7eFz46jypvdaykYnAxMGNLJhRFR44wao0MLjnOQDG+Oe52PWuOg8zMkBl3RZCVENITSqtUe");
                WriteLiteral(@"JM66/e74l+bNK04Tpo+gQeLS9GlXaPJWMdsKlJvXf47OCAjkXheVF+frY3VAApzHP+F9C6kNFfsFle+0mtzzOm3j+KpVXffzAPcyzMxCCz2gnPteulRexqF4ADLtdL3fsUrsYWi3xvX3OtPuDkTTHNQ+mcePs+3H/crgQyvh6PqPFwAyfo7KzQzqgEFsZwfKsrLy0KsdtDEbcN3YhsmbjjGhTUiPfHnvoMnnaf7EIWY5cDqIpYMQqc6S2TmSsHLuSjIc8//93J33TsukqbBNWyP837CA4/IpJagVa++/G8k4VgwGTt25MLszIvx5lY2Bf4+9ycQcWt+jIj45LsMTIq8L6dSXKASk/s+68InXjfziXp7PxWti/6mF0K9YNUCMzuRwpr3bfwrAimbCXuB77GZL+Kh9hs5HzUZULq1yVBwuIb+e4SVTywgi652wYvTcPXqujecH3dvXBnykhmZzRnQX36vy6O/zaxc0GeoKOwVFYJC4v4XyDjonWLflmFbBfucQxWo9Nn1ynku8r4ktw7sulS0V9pxUyhwZmBSClq+rLT5/5rI12+2ExkLvDYqRB/mDRLEqcm0ldKfshpMeA91WVynYYZ6thlJCPaHQwAAA);
                background-repeat: no-repeat;
                background-position: center;
                background-position: bottom;
                background-size: 470px;
                background-color: slategray;
            }
        </style>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDBContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
