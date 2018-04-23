using System.Windows;

namespace CreatingCheckedComboBoxEdit {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            comboBoxEdit1.ItemsSource = Stuff.GetStuff();
            comboBoxEdit2.ItemsSource = Stuff.GetStuff();
        }
    }
}
