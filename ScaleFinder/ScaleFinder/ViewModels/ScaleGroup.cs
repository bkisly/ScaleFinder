using System;
using System.Collections.Generic;
using System.Text;
using ScaleFinder.Models;

namespace ScaleFinder.ViewModels
{
    internal class ScaleGroup : List<Scale>
    {
        public ScaleType ScaleType { get; private set; } 

        public ScaleGroup(ScaleType scaleType) : base()
        {
            ScaleType = scaleType;
        }

        public ScaleGroup(ScaleType scaleType, IEnumerable<Scale> initialItems) : base(initialItems)
        {
            ScaleType = scaleType;
        }

        public override string ToString()
        {
            return $"{ScaleType} scales";
        }
    }
}
