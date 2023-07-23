using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JiroCourseMaker2 {
    public partial class Form1 : Form {

        private const string SettingFile = "Setting.xml";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void 出力先の次郎フォルダ指定ToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
