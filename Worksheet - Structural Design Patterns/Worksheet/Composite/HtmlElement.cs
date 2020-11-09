using System;

namespace Composite
{
    //this is the "simple" leaf
    
    public class HtmlElement: HtmlTag
    {

        public override void GenerateHtml()
        {
            Console.WriteLine($"{StartTag}{TagBody}{EndTag}");
        }
        
        
    }
} 