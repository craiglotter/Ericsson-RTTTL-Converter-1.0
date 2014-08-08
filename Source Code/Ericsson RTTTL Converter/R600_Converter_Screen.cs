using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Ericsson_RTTTL_Converter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox RTTTL_Code_Input;
		private System.Windows.Forms.Button Generate_Key_Sequence_Button;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.RTTTL_Code_Input = new System.Windows.Forms.TextBox();
			this.Generate_Key_Sequence_Button = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// RTTTL_Code_Input
			// 
			this.RTTTL_Code_Input.Location = new System.Drawing.Point(16, 8);
			this.RTTTL_Code_Input.Multiline = true;
			this.RTTTL_Code_Input.Name = "RTTTL_Code_Input";
			this.RTTTL_Code_Input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.RTTTL_Code_Input.Size = new System.Drawing.Size(320, 128);
			this.RTTTL_Code_Input.TabIndex = 0;
			this.RTTTL_Code_Input.Text = "";
			this.RTTTL_Code_Input.TextChanged += new System.EventHandler(this.RTTTL_Code_Input_TextChanged);
			// 
			// Generate_Key_Sequence_Button
			// 
			this.Generate_Key_Sequence_Button.BackColor = System.Drawing.Color.Gainsboro;
			this.Generate_Key_Sequence_Button.Enabled = false;
			this.Generate_Key_Sequence_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Generate_Key_Sequence_Button.Location = new System.Drawing.Point(264, 144);
			this.Generate_Key_Sequence_Button.Name = "Generate_Key_Sequence_Button";
			this.Generate_Key_Sequence_Button.Size = new System.Drawing.Size(75, 24);
			this.Generate_Key_Sequence_Button.TabIndex = 1;
			this.Generate_Key_Sequence_Button.Text = "Generate";
			this.toolTip1.SetToolTip(this.Generate_Key_Sequence_Button, "Generates the R600 key sequence from the inputted RTTTL code.");
			this.Generate_Key_Sequence_Button.Click += new System.EventHandler(this.Generate_Key_Sequence_Button_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Location = new System.Drawing.Point(17, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Clear Field";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.label1, "Clears the text field.");
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem1});
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem10,
																					  this.menuItem9});
			this.menuItem6.Text = "File";
			// 
			// menuItem7
			// 
			this.menuItem7.Enabled = false;
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Generate";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "Sample Code";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "-";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 3;
			this.menuItem9.Text = "Exit";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem5,
																					  this.menuItem4});
			this.menuItem1.Text = "Help";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Using the Program";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "RTTTL Specification";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 2;
			this.menuItem5.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 3;
			this.menuItem4.Text = "About";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Location = new System.Drawing.Point(128, 152);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(100, 16);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "View Log File";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabel1.Visible = false;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Location = new System.Drawing.Point(16, 144);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(80, 26);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(352, 203);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RTTTL_Code_Input);
			this.Controls.Add(this.Generate_Key_Sequence_Button);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(360, 237);
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(360, 237);
			this.Name = "Form1";
			this.Text = "Ericsson R600 RTTTL Converter 1.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		private int Character_Count(String Input, char Search_Char)
		{
			int counter = 0;
			while (Input.IndexOf(Search_Char,0,Input.Length) > 0)
			{
				counter++;
				Input = Input.Remove(Input.IndexOf(Search_Char,0,Input.Length),1);
			}
			return counter;
		}

		private String[] Process_RTTTL(String RTTTL_Code)
		{
			String[] Result = new String[3];
			if (Character_Count(RTTTL_Code,':') < 2)
			{
				Result[0] = "The RTTTL code inputted does not appear to be a valid code. Format should be <Song Title>:<Song Defaults>:<Song Note Commands>+";
				return Result;
			}

			String Song_Title, Song_Defaults, Song_Notes;
			Song_Title = "";
			Song_Defaults = "";
			Song_Notes = "";
			Song_Defaults = RTTTL_Code.Substring(RTTTL_Code.LastIndexOf(':',RTTTL_Code.LastIndexOf(':')-1),(RTTTL_Code.LastIndexOf(':')-RTTTL_Code.LastIndexOf(':',RTTTL_Code.LastIndexOf(':')-1))).Remove(0,1);
			Song_Notes = RTTTL_Code.Substring((RTTTL_Code.LastIndexOf(':')),(RTTTL_Code.Length - (RTTTL_Code.LastIndexOf(':')))).Remove(0,1);
			
			if (Song_Defaults.Length > 0)
			RTTTL_Code = RTTTL_Code.Replace(Song_Defaults,"");
			if (Song_Notes.Length > 0)
			RTTTL_Code = RTTTL_Code.Replace(Song_Notes,"");
			RTTTL_Code = RTTTL_Code.Replace(":","");
			
			Song_Title = RTTTL_Code;
			Result[0] = Song_Title;
			Result[1] = Song_Defaults;
			Result[2] = Song_Notes;
		return Result;
		}

		private int[] Process_Defaults(string Input)
		{
			int[] defaults = new int[3];
			//defaults[0] = duration
			//defaults[1] = scale
			//defaults[2] = beats per minute

			defaults[0] = -1;
			defaults[1] = -1;
			defaults[2] = -1;

			String[] breakup = Input.Split(',');
			for (int i=0;i < breakup.Length; i++)
			{
				if (breakup[i].StartsWith("d=") == true)
					defaults[0] = int.Parse(breakup[i].Substring(breakup[i].IndexOf('=')+1,breakup[i].Length-(breakup[i].IndexOf('=')+1)),System.Globalization.NumberStyles.Integer);
				if (breakup[i].StartsWith("o=") == true)
					defaults[1] = int.Parse(breakup[i].Substring(breakup[i].IndexOf('=')+1,breakup[i].Length-(breakup[i].IndexOf('=')+1)),System.Globalization.NumberStyles.Integer);
				if (breakup[i].StartsWith("b=") == true)
					defaults[2] = int.Parse(breakup[i].Substring(breakup[i].IndexOf('=')+1,breakup[i].Length-(breakup[i].IndexOf('=')+1)),System.Globalization.NumberStyles.Integer);
			}
			if (defaults[0] == -1)
				defaults[0] = 4;
			if (defaults[1] == -1)
				defaults[1] = 6;
			if (defaults[2] == -1)
				defaults[2] = 63;

			return defaults;

		}

		private string Process_R600_Keys(string Input, int[] Defaults)
		{
			Input = Input.ToLower();
			Input = Input.Replace(" ","");
//[<duration>] <note> [<scale>] [<special-duration>]
int duration,scale;
			String note = "";
				String sscale = "";
					String keys = "";
			String notesharp = "";
			

			String[] RTTTL_Notes = Input.Split(',');
			for (int i=0;i < RTTTL_Notes.Length; i++)
			{
				duration = Defaults[0];
				if (RTTTL_Notes[i].StartsWith("32") == true)
				{
					duration = 32;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,2);
				}
				if (RTTTL_Notes[i].StartsWith("16") == true)
				{
					duration = 16;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,2);
				}
				if (RTTTL_Notes[i].StartsWith("8") == true)
				{
					duration = 8;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("4") == true)
				{
					duration = 4;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("2") == true)
				{
					duration = 2;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("1") == true)
				{
					duration = 1;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				
				
				note = "";
				if (RTTTL_Notes[i].StartsWith("p") == true)
				{
					note = "*";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("b") == true)
				{
					note = "7";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("c") == true)
				{
					note = "1";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("d") == true)
				{
					note = "2";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("e") == true)
				{
					note = "3";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}				
				if (RTTTL_Notes[i].StartsWith("f") == true)
				{
					note = "4";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("g") == true)
				{
					note = "5";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("a") == true)
				{
					note = "6";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}

				notesharp = "";
				if (RTTTL_Notes[i].StartsWith("#") == true)
				{
					notesharp = " 0";
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}


				scale = Defaults[1];
				if (RTTTL_Notes[i].StartsWith("5") == true)
				{
					scale = 5;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("6") == true)
				{
					scale = 6;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("7") == true)
				{
					scale = 7;
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}
				if (RTTTL_Notes[i].StartsWith("8") == true)
				{
					scale = 8;
					//ericsson can't really handle this
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}

				if (RTTTL_Notes[i].StartsWith(".") == true)
				{
					//ericsson can't really handle this
					RTTTL_Notes[i] = RTTTL_Notes[i].Remove(0,1);
				}

				keys = keys;
				if (scale == 5)
					sscale = "";
				if (scale == 6)
					sscale = "0";
				if (scale == 7)
					sscale = "0 0";
				if (scale == 8)
					sscale = "0 0"; //ericsson can't do more than 7

				if (duration == 32)
					keys = keys + note + notesharp + " " + sscale;
				if (duration == 16)
					keys = keys + note + "H" + notesharp + " " + sscale;
				if (duration == 8)
					keys = keys + note + "H" + notesharp + " " + sscale + " " + note + notesharp + " " + sscale;
				if (duration == 4)
					keys = keys + note + "H" + notesharp + " " + sscale + " " + note + "H" + notesharp + " " + sscale;
				if (duration == 2)
					keys = keys + note + "H" + notesharp + " " + sscale + " " + note + "H" + notesharp + " " + sscale + " " + note + notesharp + " " + sscale;
				if (duration == 1)
					keys = keys + note + "H" + notesharp + " " + sscale + " " + note + "H" + notesharp + " " + sscale + " " + note + "H" + notesharp + " " + sscale;

				keys = keys + " ";
			}
keys = keys.Replace("  "," ");
			keys = keys.Replace(" ","  ");
			return keys;			
		}



		private string Generate_R600_Key_Sequence(string RTTTL_Code_Input)
		{
			String result = "";
			try
			{
				
				if (RTTTL_Code_Input.Length > 0)
				{
					String[] breakup = Process_RTTTL(RTTTL_Code_Input);
					
		
					String Song_Title, Song_Defaults, Song_Notes;
					if (breakup.Length < 3)
					{
						if (breakup.Length == 1)
						{
							return breakup[0];
						}
						else
							return "The RTTTL code inputted does not appear to be a valid code. Format should be <Song Title>:<Song Defaults>:<Song Note Commands>+";
					}
			
					Song_Title = breakup[0];
					Song_Defaults = breakup[1];
					Song_Notes = breakup[2];

					int[] Defaults = Process_Defaults(Song_Defaults);

					result = Process_R600_Keys(Song_Notes,Defaults);
				    
			
				}
				else
				{
					result = "";
				}
				
			}
				
			catch (System.NullReferenceException e) {
				result = "Conversion Failed. Invalid RTTTL code suspected.";
         }
			catch (Exception ee) 
			{
				result = "Conversion Failed. The error trapped was: " + ee.Message;
    
			}

			FileInfo f;
			f = new FileInfo(Application.ExecutablePath);
			StreamWriter filewriter;
					
			filewriter = new StreamWriter(f.DirectoryName + "\\logfile.htm", false, System.Text.Encoding.ASCII);
                
			filewriter.WriteLine("<html>");
			filewriter.WriteLine("<body bgproperties=\"fixed\" background=\"Images/Background_Image_Log_File.jpg\">");
			filewriter.WriteLine("<h1>Ericsson RTTTL Converter 1.0 Log File</h1>");
			filewriter.WriteLine("<h3>Process Started: " + DateTime.Now + "</h3>");
			filewriter.WriteLine("<table width=\"70%\"><tr><td>");
			filewriter.WriteLine("<p>RTTTL Code Input:</p>");
			filewriter.WriteLine("<ul><li>");
			filewriter.WriteLine(RTTTL_Code_Input);
			filewriter.WriteLine("</li></ul>");
			filewriter.WriteLine("<p>Generated Key Sequence:</p>");
			filewriter.WriteLine("<ul><li>");
			filewriter.WriteLine(result);
			filewriter.WriteLine("</li></ul>");
			filewriter.WriteLine("</td></tr></table>");
			filewriter.WriteLine("</body></html>");
			filewriter.Close();

return result;

		}

		private void Generate_Key_Sequence_Button_Click(object sender, System.EventArgs e)
		{
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;
			RTTTL_Code_Input.Text = Generate_R600_Key_Sequence(RTTTL_Code_Input.Text);
			if (RTTTL_Code_Input.Text.Length > 0)
				linkLabel1.Visible = true;
			else
				linkLabel1.Visible = false;
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
					

		}

		private void label1_Click(object sender, System.EventArgs e)
		{
			RTTTL_Code_Input.Clear();
			RTTTL_Code_Input.Focus();
			linkLabel1.Visible = false;
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;	
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
		Application.Exit();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			RTTTL_Code_Input.Clear();
			RTTTL_Code_Input.Focus();
			linkLabel1.Visible = false;
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;
			RTTTL_Code_Input.Text = "Papa Roach - Blood Brothers :d=8,o=7,b=160:d,d,f,d,e,c,p,4d,f,d,c,c,c,d,c,d,d,f,d,e,c,p,4d,f,d,c,a6,a6,a#6,a";
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				FileInfo f;
				f = new FileInfo(Application.ExecutablePath);
				System.Diagnostics.Process.Start(f.DirectoryName + "\\logfile.htm");
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message,"Ericsson RTTTL Converter 1.0",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
			
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;
			RTTTL_Code_Input.Text = Generate_R600_Key_Sequence(RTTTL_Code_Input.Text);
			if (RTTTL_Code_Input.Text.Length > 0)
				linkLabel1.Visible = true;
			else
				linkLabel1.Visible = false;
			menuItem7.Enabled = false;
			Generate_Key_Sequence_Button.Enabled = false;		
		}

		private void RTTTL_Code_Input_TextChanged(object sender, System.EventArgs e)
		{
			menuItem7.Enabled = true;
		Generate_Key_Sequence_Button.Enabled = true;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			try
			{
				About newabout = new About();
				newabout.Show();
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message,"Ericsson RTTTL Converter 1.0",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			try
			{
				Specification newspecification = new Specification();
				newspecification.Show();
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message,"Ericsson RTTTL Converter 1.0",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			try
			{
				Help newhelp = new Help();
				newhelp.Show();
			}
			catch(Exception ee)
			{
				MessageBox.Show(ee.Message,"Ericsson RTTTL Converter 1.0",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
			}		
		}

		
          


		
          
	
        

	}
}
