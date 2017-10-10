using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace livechartstest
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{

		public ChartViewModel CMVTabHo { get; set; }
		public ChartViewModel CMVTabHe { get; set; }
		public ChartViewModel CMVRight { get; set; }

		public MainWindow()
		{
			InitializeComponent();

			CMVTabHo = new ChartViewModel();
			CMVTabHe = new ChartViewModel();
			CMVRight = new ChartViewModel();
			DataContext = this;

		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			CMVRight = CMVTabHo = CMVTabHe;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMVTabHo"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMVRight"));

			//If you use this instead of the code above, the AxisX = null errror will popup
			//CMVTabHo = CMVTabHe = CMVRight;
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMVTabHo"));
			//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CMVTabHe"));

		}
	}

	public class DateModel
	{
		public System.DateTime DateTime { get; set; }
		public double Value { get; set; }
	}
}
