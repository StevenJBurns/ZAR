using System;
using System.Windows;
using Microsoft.VisualBasic.ApplicationServices;

namespace ZAR
	{
	public class ApplicationSingleInstance : WindowsFormsApplicationBase
		{
		private Application app;

		public ApplicationSingleInstance()
			{ this.IsSingleInstance = true; }

		protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
			{
			app = new Application();
			app.Run(new View.WindowMain("ZAR"));
			return false;
			}
		
		protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
			{
				if (app.MainWindow.WindowState == System.Windows.WindowState.Minimized)
					app.MainWindow.WindowState = System.Windows.WindowState.Normal;

			eventArgs.BringToForeground = true;
			app.MainWindow.Activate();
			}
		}
	}