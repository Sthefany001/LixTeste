using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao_Prova
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void bt_Divisao_Click(object sender, EventArgs e)
        {
            Divisao dv = new Divisao();//criar uma instância
            dv.ShowDialog();//chamar e deixar visível
        }
    }
}
