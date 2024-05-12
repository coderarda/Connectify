using Avalonia.Controls;
using Connectify.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connectify.ViewModels {
    internal class SidebarViewModel : ViewModelBase {
        public SidebarViewModel() {

        }

        public List<ListItem>? Items { get; }
    }
}
