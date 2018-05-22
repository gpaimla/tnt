using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App7.ViewModels
{
	public class UsefulViewModel : BaseViewModel
	{
		public UsefulViewModel ()
		{
			Title = "Kasulikud lingid";

			OpenWebSiseveeb = new Command(() => Device.OpenUri(new Uri("https://tpt.siseveeb.ee/")));
			OpenWebSookla = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/kool/sookla/")));
			OpenWebToetused = new Command(() => Device.OpenUri(new Uri("https://www.tptlive.ee/oppetoo/oppekorralduseeskiri/")));
			OpenWebSisekord = new Command(() => Device.OpenUri(new Uri("https://tptliveee-my.sharepoint.com/personal/info_tptlive_ee/_layouts/15/guestaccess.aspx?guestaccesstoken=0GQHb1buAehZFWPOP2qc4hZVDgeKBgB%2fhIrdg8w6RP0%3d&docid=0c329114c31c84b739172cfb0cb8eea52")));

		}

		public ICommand OpenWebSiseveeb { get; }
		public ICommand OpenWebSookla { get; }
		public ICommand OpenWebToetused { get; }
		public ICommand OpenWebSisekord { get; }
	}
}