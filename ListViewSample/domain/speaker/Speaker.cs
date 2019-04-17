
namespace ListViewSample.domain.speaker
{
    public class Speaker
    {
        public string Name { get; }
        public string Title { get; }
        public string AvatarUrl { get; }

        public Speaker(string name, string title, string avatarUrl)
        {
            this.Name = name;
            this.Title = title;
            this.AvatarUrl = avatarUrl;
        }
    }
}
