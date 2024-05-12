using Avalonia;
using Avalonia.Controls;

namespace Connectify.Controls {
    public partial class ListItem : UserControl {
        public ListItem() {
            InitializeComponent();
        }

        public static readonly DirectProperty<ListItem, string> TitleProp = AvaloniaProperty.RegisterDirect<ListItem, string>(
            "Title",
            (val) => val.Title,
            (o, v) => {
                o.Title = v;
                o.textBlock.Text = v;
            }
        );

        private string _title = string.Empty;

        public string Title { get { return _title; } set { SetAndRaise(TitleProp, ref _title, value); } }
    }
}
