
namespace ListViewSample.presentation.speaker
{
    public class SpeakerListViewEntity
    {
        public string Name { get; }
        public string Title { get; }
        public string AvatarUrl { get; }

        public SpeakerListViewEntity(string name, string title, string avatarUrl)
        {
            this.Name = name;
            this.Title = title;
            this.AvatarUrl = avatarUrl;
        }
    }
}
