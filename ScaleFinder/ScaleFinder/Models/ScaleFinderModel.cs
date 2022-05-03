using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ScaleFinder.Models
{
    internal class ScaleFinderModel
    {
        public List<Scale> Scales { get; private set; }

        public ScaleFinderModel()
        {
            Scales = GetTypicalScales();
        }

        public IEnumerable<Scale> GetFilteredScales(IEnumerable<Sound> sounds)
        { 
            return from scale in Scales
                   where sounds.All((sound) => scale.Sounds.Contains(sound))
                   select scale;
        }

        private static List<Scale> GetTypicalScales()
        {
            return new List<Scale>
            {
                // C scales
                new Scale("C major", ScaleType.Major, new List<Sound>
                {
                    Sound.C, Sound.D, Sound.E, Sound.F,Sound.G, Sound.A, Sound.B,
                }),
                new Scale("C minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.C, Sound.D, Sound.Dis, Sound.F,Sound.G, Sound.Gis, Sound.Ais,
                }),
                new Scale("C minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.C, Sound.D, Sound.Dis, Sound.F,Sound.G, Sound.Gis, Sound.B,
                }),
                new Scale("C minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.C, Sound.D, Sound.Dis, Sound.F,Sound.G, Sound.A, Sound.B,
                }),

                // C#/Db scales
                new Scale("Db major", ScaleType.Major, new List<Sound>
                {
                    Sound.Cis, Sound.Dis, Sound.F, Sound.Fis, Sound.Gis, Sound.Ais, Sound.C,
                }),
                new Scale("C# minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.Cis, Sound.Dis, Sound.E, Sound.Fis, Sound.Gis, Sound.A, Sound.B,
                }),
                new Scale("C# minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.Cis, Sound.Dis, Sound.E, Sound.Fis, Sound.Gis, Sound.A, Sound.C,
                }),
                new Scale("C# minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.Cis, Sound.Dis, Sound.E, Sound.Fis, Sound.Gis, Sound.Ais, Sound.C,
                }),

                // D scales
                new Scale("D major", ScaleType.Major, new List<Sound>
                {
                    Sound.D, Sound.E, Sound.Fis, Sound.G, Sound.A, Sound.B, Sound.Cis,
                }),
                new Scale("D minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.D, Sound.E, Sound.F, Sound.G, Sound.A, Sound.Ais, Sound.C,
                }),
                new Scale("D minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.D, Sound.E, Sound.F, Sound.G, Sound.A, Sound.Ais, Sound.Cis,
                }),
                new Scale("D minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.D, Sound.E, Sound.F, Sound.G, Sound.A, Sound.B, Sound.Cis,
                }),

                // D#/Eb scales
                new Scale("Eb major", ScaleType.Major, new List<Sound>
                {
                    Sound.Dis, Sound.F, Sound.G, Sound.Gis, Sound.Ais, Sound.C, Sound.D,
                }),
                new Scale("D# minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.Dis, Sound.F, Sound.Fis, Sound.Gis, Sound.Ais, Sound.B, Sound.Cis,
                }),
                new Scale("D# minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.Dis, Sound.F, Sound.Fis, Sound.Gis, Sound.Ais, Sound.B, Sound.D,
                }),
                new Scale("D# minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.Dis, Sound.F, Sound.Fis, Sound.Gis, Sound.Ais, Sound.C, Sound.D,
                }),

                // E scales
                new Scale("E major", ScaleType.Major, new List<Sound>
                {
                    Sound.E, Sound.Fis, Sound.Gis, Sound.A, Sound.B, Sound.Cis, Sound.Dis,
                }),
                new Scale("E minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.E, Sound.Fis, Sound.G, Sound.A, Sound.B, Sound.C, Sound.D,
                }),
                new Scale("E minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.E, Sound.Fis, Sound.G, Sound.A, Sound.B, Sound.C, Sound.Dis,
                }),
                new Scale("E minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.E, Sound.Fis, Sound.G, Sound.A, Sound.B, Sound.Cis, Sound.Dis,
                }),

                // F scales
                new Scale("F major", ScaleType.Major, new List<Sound>
                {
                    Sound.F, Sound.G, Sound.A, Sound.Ais, Sound.C, Sound.D, Sound.E,
                }),
                new Scale("F minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.F, Sound.G, Sound.Gis, Sound.Ais, Sound.C, Sound.Cis, Sound.Dis,
                }),
                new Scale("F minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.F, Sound.G, Sound.Gis, Sound.Ais, Sound.C, Sound.Cis, Sound.E,
                }),
                new Scale("F minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.F, Sound.G, Sound.Gis, Sound.Ais, Sound.C, Sound.D, Sound.E,
                }),

                // F#/Gb scales
                new Scale("Gb major", ScaleType.Major, new List<Sound>
                {
                    Sound.Fis, Sound.Gis, Sound.Ais, Sound.B, Sound.Cis, Sound.Dis, Sound.F,
                }),
                new Scale("F# minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.Fis, Sound.Gis, Sound.A, Sound.B, Sound.Cis, Sound.D, Sound.E,
                }),
                new Scale("F minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.Fis, Sound.Gis, Sound.A, Sound.B, Sound.Cis, Sound.D, Sound.F,
                }),
                new Scale("F minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.Fis, Sound.Gis, Sound.A, Sound.B, Sound.Cis, Sound.Dis, Sound.F,
                }),

                // G scales
                new Scale("G major", ScaleType.Major, new List<Sound>
                {
                    Sound.G, Sound.A, Sound.B, Sound.C, Sound.D, Sound.E, Sound.Fis,
                }),
                new Scale("G minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.G, Sound.A, Sound.Ais, Sound.C, Sound.D, Sound.Dis, Sound.F,
                }),
                new Scale("G minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.G, Sound.A, Sound.Ais, Sound.C, Sound.D, Sound.Dis, Sound.Fis,
                }),
                new Scale("G minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.G, Sound.A, Sound.Ais, Sound.C, Sound.D, Sound.E, Sound.Fis,
                }),

                // G#/Ab scales
                new Scale("Ab major", ScaleType.Major, new List<Sound>
                {
                    Sound.Gis, Sound.Ais, Sound.C, Sound.Cis, Sound.Dis, Sound.F, Sound.G,
                }),
                new Scale("G# minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.Gis, Sound.Ais, Sound.B, Sound.Cis, Sound.Dis, Sound.E, Sound.Fis,
                }),
                new Scale("G# minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.Gis, Sound.Ais, Sound.B, Sound.Cis, Sound.Dis, Sound.E, Sound.G,
                }),
                new Scale("G# minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.Gis, Sound.Ais, Sound.B, Sound.Cis, Sound.Dis, Sound.F, Sound.G,
                }),

                // A scales
                new Scale("A major", ScaleType.Major, new List<Sound>
                {
                    Sound.A, Sound.B, Sound.Cis, Sound.D, Sound.E, Sound.Fis, Sound.Gis,
                }),
                new Scale("A minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.A, Sound.B, Sound.C, Sound.D, Sound.E, Sound.F, Sound.G,
                }),
                new Scale("A minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.A, Sound.B, Sound.C, Sound.D, Sound.E, Sound.F, Sound.Gis,
                }),
                new Scale("A minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.A, Sound.B, Sound.C, Sound.D, Sound.E, Sound.Fis, Sound.Gis,
                }),

                // A#/Bb scales
                new Scale("Bb major", ScaleType.Major, new List<Sound>
                {
                    Sound.Ais, Sound.C, Sound.D, Sound.Dis, Sound.F, Sound.G, Sound.A,
                }),
                new Scale("Bb minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.Ais, Sound.C, Sound.Cis, Sound.Dis, Sound.F, Sound.Fis, Sound.Gis,
                }),
                new Scale("Bb minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.Ais, Sound.C, Sound.Cis, Sound.Dis, Sound.F, Sound.Fis, Sound.A,
                }),
                new Scale("Bb minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.Ais, Sound.C, Sound.Cis, Sound.Dis, Sound.F, Sound.G, Sound.A,
                }),

                // B scales
                new Scale("B major", ScaleType.Major, new List<Sound>
                {
                    Sound.B, Sound.Cis, Sound.Dis, Sound.E, Sound.Fis, Sound.Gis, Sound.Ais,
                }),
                new Scale("B minor natural", ScaleType.Minor, new List<Sound>
                {
                    Sound.B, Sound.Cis, Sound.D, Sound.E, Sound.Fis, Sound.G, Sound.A,
                }),
                new Scale("B minor harmonic", ScaleType.Minor, new List<Sound>
                {
                    Sound.B, Sound.Cis, Sound.D, Sound.E, Sound.Fis, Sound.G, Sound.Ais,
                }),
                new Scale("B minor melodic ascending", ScaleType.Minor, new List<Sound>
                {
                    Sound.B, Sound.Cis, Sound.D, Sound.E, Sound.Fis, Sound.Gis, Sound.Ais,
                }),
            };
        }
    }
}
