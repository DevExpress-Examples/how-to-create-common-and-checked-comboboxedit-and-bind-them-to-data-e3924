Imports Microsoft.VisualBasic
Imports System.Windows

Namespace CreatingCheckedComboBoxEdit

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			comboBoxEdit1.ItemsSource = Stuff.GetStuff()
			comboBoxEdit2.ItemsSource = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
