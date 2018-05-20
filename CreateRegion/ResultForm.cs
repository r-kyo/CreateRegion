using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateRegion {
    public partial class ResultForm : Form {
        public ResultForm(List<String> resultText) {
            InitializeComponent();

            ResultText.Text = String.Join("\r\n", resultText);
        }
    }
}
