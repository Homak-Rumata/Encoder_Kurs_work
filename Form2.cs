using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тестовое_окно
{
    public partial class MainForm : Form
    {

        LoginForm ParentForm;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Form RelForm)
        {
            InitializeComponent();
            
        }

        public void Start ()
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        public void Showing (LoginForm LogF)
        {
            LogF.Hide();
            ParentForm = LogF;
            this.Show();
        }
    }
}
