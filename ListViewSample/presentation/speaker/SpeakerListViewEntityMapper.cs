using System.Collections.Generic;
using ListViewSample.domain.speaker;

namespace ListViewSample.presentation.speaker
{
    public class SpeakerListViewEntityMapper
    {
        public IList<SpeakerListViewEntity> Transform(IList<Speaker> entities)
        {
            var speakerList = new List<SpeakerListViewEntity>();
            foreach (Speaker entity in entities)
            {
                speakerList.Add(new SpeakerListViewEntity(entity.Name, entity.Title, entity.AvatarUrl));
            }

            return speakerList;
        }
    }
}
