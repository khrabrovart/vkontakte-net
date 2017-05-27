namespace Citrina.StandardApi.Core
{
    internal class SnakeCaseContractResolver : DelimiterContractResolver
    {
        public SnakeCaseContractResolver() : base('_')
        {
        }
    }
}
