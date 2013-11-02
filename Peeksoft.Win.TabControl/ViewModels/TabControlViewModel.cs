using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peeksoft.Win.TabControl.ViewModels
{
    public class TabControlViewModel : BaseViewModel
    {
        public TabControlViewModel()
        {
            _tabs = new ObservableCollection<Tab>();
        }

        private ObservableCollection<Tab> _tabs;
        public ObservableCollection<Tab> Tabs
        {
            get
            {
                return _tabs;
            }

            set
            {
                _tabs = value;
                OnPropertyChanged("Tabs");
            }
        }
    }
}
