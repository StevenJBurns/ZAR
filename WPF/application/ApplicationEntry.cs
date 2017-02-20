using System;

namespace ZAR
	{
	public class ApplicationEntry
		{
		[STAThread]
		public static void Main(String[] args)
			{
			ApplicationSingleInstance singleinstanceapp = new ApplicationSingleInstance();
			singleinstanceapp.Run(args);
			}
		}
	}