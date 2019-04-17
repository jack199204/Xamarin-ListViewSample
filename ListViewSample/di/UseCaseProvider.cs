using ListViewSample.domain.speaker;

namespace ListViewSample.di
{
    public class UseCaseProvider
    {
        private readonly RepositoryProvider repositoryProvider;

        public UseCaseProvider(RepositoryProvider repositoryProvider)
        {
            this.repositoryProvider = repositoryProvider;
        }

        public GetSpeakerListUseCase GetSpeakerListUseCase()
        {
            return new GetSpeakerListUseCase(this.repositoryProvider.SpeakerRepository());
        }
    }
}
