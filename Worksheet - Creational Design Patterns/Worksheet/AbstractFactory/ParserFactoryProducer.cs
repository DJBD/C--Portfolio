namespace QuestionOne
{
    public static class ParserFactoryProducer
    {
        public static IAbstractParserFactory GetFactory(string nyFactory) => nyFactory switch
        {
            "NYCFactory" => new NYCParserFactory(),
            "LDNFactory" => new LDNParserFactory(),
            "SFFactory" => new SFParserFactory(),
        };
    }
}