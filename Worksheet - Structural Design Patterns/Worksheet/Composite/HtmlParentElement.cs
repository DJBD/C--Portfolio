using System;
using System.Collections.Generic;

namespace Composite
{
    
    //this is the "complex" child
    public class HtmlParentElement: HtmlTag
    {

        protected List<HtmlTag> _children = new List<HtmlTag>();

        public override void AddChildTag(HtmlTag htmlTag)
        {
            this._children.Add(htmlTag);
        }
        
        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            this._children.Remove(htmlTag);
        }

        public override void GenerateHtml()
        {
            Console.WriteLine($"{StartTag}");
            
            foreach (HtmlTag component in this._children)
            {
                component.GenerateHtml();
            }

            Console.WriteLine($"{EndTag}");

        }
    }
}