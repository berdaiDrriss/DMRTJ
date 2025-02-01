using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMR_tJ
{
    public class EdiSegment
    {
        public string SegmentName { get; set; }
        public List<string> Elements { get; set; }

        public EdiSegment(string segmentName, params string[] elements)
        {
            SegmentName = segmentName;
            Elements = new List<string>(elements);
        }

        public override string ToString()
        {
            return SegmentName + "*" + string.Join("*", Elements) + "~";
        }
    }
}
