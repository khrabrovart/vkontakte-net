namespace Citrina.Json.ContractResolvers
{
    internal class SnakeCaseContractResolver : DelimiterContractResolver
    {
        public SnakeCaseContractResolver() : base('_')
        {
        }
    }
}
