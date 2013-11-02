using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Peeksoft.Win.TabControl.ViewModels
{
    public class Tab : BaseViewModel
    {
        public Tab(string name, FrameworkElement content)
        {
            Name = name;
            _content = content;
        }

        public string Name
        {
            get;
            private set;
        }

        private FrameworkElement _content;
        public FrameworkElement Content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }
    }
}
