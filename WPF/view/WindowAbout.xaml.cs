using System;
using System.Windows;
using System.Reflection;

namespace SJB.ZAR.WPF.View
  {
  public partial class WindowAbout : Window
    {
    String appname = Assembly.GetExecutingAssembly().GetName().Name;
    String appversion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public WindowAbout()
      {
      InitializeComponent();

            this.Title = "About...";
            this.ShowInTaskbar = false;
            this.ResizeMode = ResizeMode.NoResize;
            this.Height = 240;
            this.Width = 240;

            lblApp.Content = appname;
            lblVer.Content = "v" + appversion;
      }

    private void Button_OK_Click(object sender, RoutedEventArgs e)
      {
      this.Close();
      }
    }
  }