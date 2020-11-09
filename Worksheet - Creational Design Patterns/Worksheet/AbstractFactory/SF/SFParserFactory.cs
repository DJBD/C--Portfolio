namespace QuestionOne
{
    internal class SFParserFactory : IAbstractParserFactory
    {

        public IXMLParser GetParserInstance(string parserType)
        {
            string nitem = parserType;
            switch (nitem)
            {
                case "SFORDER":
                    System.Console.WriteLine("SF Parsing order XML...");
                    return new SFOrderXMLParser();

                case "SFERROR":
                    System.Console.WriteLine("SF Parsing error XML...");
                    return new SFErrorXMLParser();

                case "SFFEEDBACK":
                    System.Console.WriteLine("SF Parsing Feedback XML...");
                    return new SFFeedbackXMLParser();

                case "SFRESPONSE":
                    System.Console.WriteLine("SF Parsing Response XML... ");
                    return new SFResponseXMLParser();

                default:
                    System.Console.WriteLine("No match found");
                    break;
            };
            return null;
        }
    }
}