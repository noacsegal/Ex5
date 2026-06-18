using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindownInterface
{
    public partial class BoardForm : Form
    {
        private string m_Player1Name;
        private string m_Player2Name;
        private int m_BoardSize;

        public BoardForm(string i_Player1Name, string i_Player2Name, int i_BoardSize)
        {
            InitializeComponent();
            m_Player1Name = i_Player1Name;
            m_Player2Name = i_Player2Name;
            m_BoardSize = i_BoardSize;
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
