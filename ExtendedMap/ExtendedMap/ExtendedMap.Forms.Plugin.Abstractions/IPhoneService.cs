﻿using System.Threading.Tasks;

namespace ExtendedMap.Forms.Plugin.Abstractions
{
	public interface IPhoneService
	{
		void OpenBrowser (string url);

		/// <summary>
		/// Opens native dialog to dial the specified number.
		/// </summary>
		/// <param name="number">Number to dial.</param>
		void DialNumber (string number);

		void SendSMS (string to, string body);

		void ShareText (string text);

		void LaunchMap (string address);

		void LaunchNavigationAsync (NavigationModel navigationModel);
	}
}

