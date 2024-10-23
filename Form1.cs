namespace notepad
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
            path = null;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                rtb_body.LoadFile(openFD.FileName);
                path = openFD.FileName;
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path != null)
            {

                rtb_body.SaveFile(path);
                rtb_body.Clear();
                path = null;
            }
            else
            {
                if (SaveFD.ShowDialog() == DialogResult.OK)
                {
                    rtb_body.SaveFile(SaveFD.FileName);
                    rtb_body.Clear();

                }
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveFD.ShowDialog() == DialogResult.OK)
            {
                rtb_body.SaveFile(SaveFD.FileName);
                rtb_body.Clear();
                path = null;

            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_body.Text != "")
            {
                if (MessageBox.Show("Do you want to save", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else
                {
                    rtb_body.Clear();
                    path = null;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb_body.Text != "")
            {
                if (MessageBox.Show("Do you want to save", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionFont = fontD.Font;
                }
                rtb_body.Font = fontD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionColor = colorD.Color;
                }
                else
                {
                    rtb_body.ForeColor = colorD.Color;
                }
            }

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                if (rtb_body.SelectedText != "")
                {
                    rtb_body.SelectionBackColor = colorD.Color;
                }
                else
                {
                    rtb_body.BackColor = colorD.Color;
                }
            }
        }
    }
}
