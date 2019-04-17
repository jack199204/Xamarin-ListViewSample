
namespace ListViewSample.di
{
    public class ProviderFactory
    {
        public RepositoryProvider CreateRepositoryProvider()
        {
            return new RepositoryProvider();
        }

        public UseCaseProvider CreateUseCaseProvider()
        {
            return new UseCaseProvider(this.CreateRepositoryProvider());
        }
    }
}
