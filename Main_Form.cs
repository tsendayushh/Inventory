using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treasurer_App
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void buttonAddThing_MouseClick(object sender, MouseEventArgs e)
        {
            AddThingForm addThingF = new AddThingForm();
            addThingF.Show(this);
        }
    }
}
