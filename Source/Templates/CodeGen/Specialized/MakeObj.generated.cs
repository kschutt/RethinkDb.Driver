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

namespace Templates.CodeGen.Specialized
{
    using System;
    
    #line 2 "..\..\CodeGen\Specialized\MakeObj.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\Specialized\MakeObj.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "..\..\CodeGen\Specialized\MakeObj.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\Specialized\MakeObj.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\Specialized\MakeObj.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class MakeObj : AstSubclassTemplate
    {
#line hidden

        #line 14 "..\..\CodeGen\Specialized\MakeObj.cshtml"

    

        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






WriteLiteral("\r\n");


WriteLiteral("\r\n");


            
            #line 10 "..\..\CodeGen\Specialized\MakeObj.cshtml"
  
    this.Layout = UseParentLayout(this);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n");


DefineSection("SpecialMethods", () => {

WriteLiteral("\r\n    public static MakeObj FromMap(Dictionary<string, ReqlAst> map){\r\n        re" +
"turn new MakeObj(OptArgs.FromMap(map));\r\n    }\r\n");


});

WriteLiteral("\r\n\r\n\r\n");


        }
    }
}
#pragma warning restore 1591
