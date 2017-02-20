using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//using ZAR.Properties;

namespace ZAR.View
	{
	public partial class WindowMain : Window
		{
		public WindowMain()
			{
			InitializeComponent();
			InitializeSettings();
			}

		public WindowMain(String windowtitle)
			{
			InitializeComponent();
			InitializeSettings();

			this.Title = windowtitle;
			}

		private void InitializeSettings()
			{

			}

		private void ShowOptionsWindow(object sender, RoutedEventArgs e)
			{
			WindowOptions winOptions = new WindowOptions
				{
				WindowStartupLocation = WindowStartupLocation.CenterOwner,
				Background = this.Background,
				Icon = this.Icon,
				Owner = this
				};
			
			winOptions.ShowDialog();
			}

		private void ShowAboutWindow(object sender, RoutedEventArgs e)
			{
			WindowAbout winAbout = new WindowAbout
				{
				WindowStartupLocation = WindowStartupLocation.CenterOwner,
				Background = this.Background,
				Icon = this.Icon,
				Owner = this
				};
			
			winAbout.ShowDialog();
			}

		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
			{
			base.OnClosing(e);
			}
		}
	}
