using ListViewSample.data.speaker;
using ListViewSample.domain.speaker;

namespace ListViewSample.di
{
    public class RepositoryProvider
    {
        public ISpeakerRepository SpeakerRepository()
        {
            return new SpeakerRepository();
        }
    }
}
