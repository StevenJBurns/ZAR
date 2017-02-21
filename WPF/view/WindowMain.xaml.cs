using System;
using System.Windows;
//using ZAR.Properties;

namespace SJB.ZAR.WPF.View
  {
  public partial class WindowMain : Window
    {
    public WindowMain()
      {
      InitializeComponent();
      InitializeSettings();

            this.Title = "ZAR";
            this.Height = 600;
            this.Width = 800;
            this.MinHeight = 300;
            this.MinWidth = 400;
            this.ResizeMode = ResizeMode.CanResizeWithGrip;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
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
