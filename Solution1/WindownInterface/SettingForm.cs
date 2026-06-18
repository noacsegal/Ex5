namespace WindownInterface
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            toggleRow.Value = (int)toggleColumns.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toglleRow_ValueChanged(object sender, EventArgs e)
        {
            toggleRow.Value = (int)toggleColumns.Value;

        }

        private void toggleColumns_ValueChanged(object sender, EventArgs e)
        {
            toggleColumns.Value = (int)toggleRow.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPlayer2.Enabled = true;
                textBoxPlayer1.Text = "";
            }
            else
            {
                textBoxPlayer2.Enabled = false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            BoardForm gameBoard = new BoardForm(textBoxPlayer1.Text, textBoxPlayer2.Text, (int)toggleRow.Value);
            this.Hide();
            gameBoard.ShowDialog();
            this.Close();
        }
    }
}
