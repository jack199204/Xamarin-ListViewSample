using System.Linq;
using System.Collections.Generic;
using ListViewSample.domain.speaker;

namespace ListViewSample.presentation.speaker
{
    public class SpeakerListViewEntityMapper
    {
        public IList<SpeakerListViewEntity> Transform(IList<Speaker> entities)
        {
            return entities.Select(entity => new SpeakerListViewEntity(entity.Name, entity.Title, entity.AvatarUrl)).ToList();
        }
    }
}
