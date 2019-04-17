using System.Collections.Generic;
using ListViewSample.domain.speaker;

namespace ListViewSample.data.speaker
{
    public class SpeakerMapper
    {
        public IList<Speaker> Transform(IList<SpeakerResponseEntity> entities)
        {
            var speakerList = new List<Speaker>();
            foreach (SpeakerResponseEntity entity in entities)
            {
                speakerList.Add(new Speaker(entity.Name, entity.Description, entity.Avatar));
            }

            return speakerList;
        }
    }
}
