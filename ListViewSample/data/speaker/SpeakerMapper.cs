using System.Linq;
using System.Collections.Generic;
using ListViewSample.domain.speaker;

namespace ListViewSample.data.speaker
{
    public class SpeakerMapper
    {
        public IList<Speaker> Transform(IList<SpeakerResponseEntity> entities)
        {
            return entities.Select(entity => new Speaker(entity.Name, entity.Title, entity.Avatar)).ToList();
        }
    }
}
