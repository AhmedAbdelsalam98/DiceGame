using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmedAbdelsalamAssgt
{
    public partial class InputBox : Form
    {
        public string sFieldValue
        {
            get
            {
                return txbxValue.Text;
            }
        }
        public InputBox()
        {
            InitializeComponent();
        }

        public InputBox(string title, string lbl)
        {
            InitializeComponent();
            this.Text = title;
            lblName.Text = lbl;
        }
    }
}
