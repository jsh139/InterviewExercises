namespace Patterns.Support
{
    public interface ISearchResults
    {
        bool CanSatisfyRequest(ISearchRequest request);
    }
}
