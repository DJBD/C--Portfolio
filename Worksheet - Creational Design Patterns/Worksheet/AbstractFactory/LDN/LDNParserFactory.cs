namespace QuestionOne
{
    internal class LDNParserFactory : IAbstractParserFactory
    {

        public IXMLParser GetParserInstance(string parserType)
        {
            string nitem = parserType;
            switch (nitem)
            {
                case "LDNORDER":
                    System.Console.WriteLine("LDN Parsing order XML...");
                    return new LDNOrderXMLParser();

                case "LDNERROR":
                    System.Console.WriteLine("LDN Parsing error XML...");
                    return new LDNErrorXMLParser();

                case "LDNFEEDBACK":
                    System.Console.WriteLine("LDN Parsing Feedback XML...");
                    return new LDNFeedbackXMLParser();

                case "LDNRESPONSE":
                    System.Console.WriteLine("LDN Parsing Response XML... ");
                    return new LDNResponseXMLParser();

                default:
                    System.Console.WriteLine("No match found");
                    break;
            };
            return null;
        }

    }
}