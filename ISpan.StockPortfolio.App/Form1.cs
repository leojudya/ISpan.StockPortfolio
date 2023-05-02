using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ISpan.StockPortfolio.DataAccessLayer;

namespace ISpan.StockPortfolio.App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var user = new UserRepository().Get("atuny0@sohu.com");
            Console.WriteLine(user);
        }
	}
}
