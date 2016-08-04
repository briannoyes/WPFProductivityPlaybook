using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace BlendBehaviorsDemo
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<IconInfo> _icons;

        public MainWindowViewModel()
        {
            IconSelectedCommand = new DelegateCommand<IconInfo>(OnIconSelected);
        }

        public ObservableCollection<IconInfo> Icons
        {
            get { return _icons; }
            set { SetProperty(ref _icons, value); }
        }

        public DelegateCommand<IconInfo> IconSelectedCommand { get; set; }

        public void Initialize()
        {
            Icons = new ObservableCollection<IconInfo>(IconService.GetIcons());
        }

        private void OnIconSelected(IconInfo iconInfo)
        {
            MessageBox.Show("Icon selected: " + iconInfo.Name + "!");
        }
    }
}
