using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScaleFinder.Models;
using System.Collections.ObjectModel;

namespace ScaleFinder.ViewModels
{
    internal class ScaleFinderViewModel
    {
        private readonly ScaleFinderModel _model;

        public ObservableCollection<ScaleGroup> FilteredScales { get; private set; }
        public ObservableCollection<Sound> SelectedSounds { get; private set; }

        public ScaleFinderViewModel()
        {
            _model = new ScaleFinderModel();
            FilteredScales = new ObservableCollection<ScaleGroup>();
            SelectedSounds = new ObservableCollection<Sound>();
        }

        public void UpdateScales()
        {
            IEnumerable<Scale> scales = _model.GetFilteredScales(SelectedSounds);
            var scaleGroups = from Scale scale in scales
                              group scale by scale.ScaleType into scaleGroup
                              orderby scaleGroup.Key
                              select scaleGroup;

            FilteredScales.Clear();
            foreach(var scaleGroup in scaleGroups)
            {
                FilteredScales.Add(new ScaleGroup(scaleGroup.Key, scaleGroup.AsEnumerable()));
            }
        }
    }
}
