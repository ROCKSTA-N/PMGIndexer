namespace PMGIndexer.Indexer
{
     public interface IDataIndexer
    {
        Task IndexEndpoints(List<string> endpoints);
    }
}