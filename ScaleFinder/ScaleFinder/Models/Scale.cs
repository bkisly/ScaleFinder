using System;
using System.Collections.Generic;
using System.Text;

namespace ScaleFinder.Models
{
    public enum Sound
    {
        C,
        Cis,
        D,
        Dis,
        E,
        F,
        Fis,
        G,
        Gis,
        A,
        Ais,
        B
    }

    public enum ScaleType
    {
        Major,
        Minor,
    }

    public class Scale
    {
        public string Name { get; private set; }
        public ScaleType ScaleType { get; private set; }
        public List<Sound> Sounds { get; private set; }

        public Scale(string name, ScaleType scaleType, IEnumerable<Sound> sounds)
        {
            Name = name;
            ScaleType = scaleType;
            Sounds = new List<Sound>(sounds);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
