namespace QuestionOne
{
    internal class NYCParserFactory : IAbstractParserFactory
    {

        public IXMLParser GetParserInstance(string parserType)
        {
            string nitem = parserType;
            switch (nitem)
            {
                case "NYCORDER":
                    System.Console.WriteLine("NY Parsing order XML...");
                    return new NYCOrderXMLParser();

                case "NYCERROR":
                    System.Console.WriteLine("NY Parsing error XML...");
                    return new NYCErrorXMLParser();

                case "NYCFEEDBACK":
                    System.Console.WriteLine("NY Parsing Feedback XML...");
                    return new NYCFeedbackXMLParser();

                case "NYCRESPONSE":
                    System.Console.WriteLine("NY Parsing Response XML... ");
                    return new NYCResponseXMLParser();

                default:
                    System.Console.WriteLine("No match found");
                    break;
            };
            return null;
        }

    }

   
    
}