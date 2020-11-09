using System;

namespace Composite
{
    public static class TestCompositePattern
    {
        public static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement();
            parentTag.StartTag = "<html>";
            parentTag.EndTag = "</html>";

            HtmlTag p1 = new HtmlParentElement();
            p1.StartTag = "<body>";
            p1.EndTag = "</body>";
            parentTag.AddChildTag(p1);

            HtmlTag child1 = new HtmlElement(); //leaf
            child1.StartTag = "<P>";
            child1.EndTag = "</P>";
            child1.TagBody = "Testing html tag library";
            p1.AddChildTag(child1);

            child1 = new HtmlElement(); //leaf
            child1.StartTag = "<P>";
            child1.EndTag = "</P>";
            child1.TagBody = "Paragraph 2";
            p1.AddChildTag(child1);
            
            parentTag.GenerateHtml();
        }
    }
}