/*
 * Created by SharpDevelop.
 * User: Ramazan TÜFEKÇİ
 * Web Site:www.ramazantufekci.com
 * Date: 1/26/2016
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Text;

namespace outlookAyar
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		UnicodeEncoding df = new UnicodeEncoding();
		void Button1Click(object sender, EventArgs e)
		{
			RegistryKey pRegKey = Registry.CurrentUser;
			string profilyolu="SOFTWARE\\Microsoft\\Office\\15.0\\Outlook\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676";
			string profil2007 = "Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows Messaging Subsystem\\Profiles\\Outlook\\9375CFF0413111d3B88A00104B2A6676";
			if ((pRegKey = pRegKey.OpenSubKey(profil2007,true))!=null) {
				foreach (string element in pRegKey.GetSubKeyNames()) {
					RegistryKey pRegKey5=pRegKey.OpenSubKey(element,true);
					if (pRegKey5.GetValue("POP3 Server")!=null) {
						pRegKey5.SetValue("POP3 Server",df.GetBytes("outlook.office365.com"),RegistryValueKind.Binary);
						pRegKey5.SetValue("POP3 Port",995,RegistryValueKind.DWord);
						pRegKey5.SetValue("POP3 Use SSL",1,RegistryValueKind.DWord);
						pRegKey5.SetValue("SMTP Server",df.GetBytes("smtp.office365.com"),RegistryValueKind.Binary);
						pRegKey5.SetValue("SMTP Port",587,RegistryValueKind.DWord);
						pRegKey5.SetValue("SMTP Secure Connection",1,RegistryValueKind.DWord);
						DialogResult cikis = new DialogResult();
						cikis = MessageBox.Show("Ayarlar Yapılmıştır. Outlook programını kapatıp tekrar açınız.", "Uyarı", MessageBoxButtons.OK);
						
							if (cikis==DialogResult.OK) {
								Application.Exit();
							}

					}else
					{
						pRegKey5.Flush();
					}
					
				}
			}else
			{
				RegistryKey pRegKey2 = Registry.CurrentUser;
				pRegKey2 = pRegKey2.OpenSubKey(profilyolu,true);
				foreach (string element in pRegKey2.GetSubKeyNames()) {
					RegistryKey pRegKey3=pRegKey2.OpenSubKey(element,true);
					if (pRegKey3.GetValue("POP3 Server")!=null) {
						pRegKey3.SetValue("POP3 Server",df.GetBytes("outlook.office365.com"),RegistryValueKind.Binary);
						pRegKey3.SetValue("POP3 Port",995,RegistryValueKind.DWord);
						pRegKey3.SetValue("POP3 Use SSL",1,RegistryValueKind.DWord);
						pRegKey3.SetValue("SMTP Server",df.GetBytes("smtp.office365.com"),RegistryValueKind.Binary);
						pRegKey3.SetValue("SMTP Port",587,RegistryValueKind.DWord);
						pRegKey3.SetValue("SMTP Secure Connection",1,RegistryValueKind.DWord);
						DialogResult cikis1 = new DialogResult();
						cikis1 = MessageBox.Show("Ayarlar Yapılmıştır. Outlook programını kapatıp tekrar açınız.", "Uyarı", MessageBoxButtons.OK);

						if (cikis1==DialogResult.OK) {
								Application.Exit();
						}
		
					}
					else
					{
						pRegKey3.Flush();
					}
					
				}
			}
		}
	}
}
