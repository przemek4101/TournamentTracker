using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CreateTeamForm
            // 
            this.ClientSize = new System.Drawing.Size(454, 328);
            this.Name = "CreateTeamForm";
            this.ResumeLayout(false);

        }
    }
}
