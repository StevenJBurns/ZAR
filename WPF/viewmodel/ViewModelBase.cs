using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace SJB.ZAR.WPF.ViewModel
	{
	public class ViewModelBase : INotifyPropertyChanged
		{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string name)
			{
			PropertyChangedEventHandler handler = PropertyChanged;
			
			if (handler != null)
				{handler(this, new PropertyChangedEventArgs(name));}
			}
		}
	}
