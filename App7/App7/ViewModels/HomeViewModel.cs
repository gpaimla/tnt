using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App7.ViewModels
{
	public class HomeViewModel : BaseViewModel
	{
		private string imageurisource;
		public string ImageUriSource
		{
			get { return imageurisource; }
			set { SetProperty(ref imageurisource, value); }
		}
		public HomeViewModel ()
		{
			Title = "Tallinna polütehnikum";
			imageurisource = "https://www.tptlive.ee/wp-content/uploads/2014/07/tpt_logo2.png";
		}
	}
}