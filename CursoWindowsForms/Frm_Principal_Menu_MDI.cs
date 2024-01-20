using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_MDI : Form
    {
        public Frm_Principal_Menu_MDI()
        {
            InitializeComponent();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF frm_ValidaCPF = new Frm_ValidaCPF();
            frm_ValidaCPF.ShowDialog();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey frm_DemonstracaoKey = new Frm_DemonstracaoKey();
            frm_DemonstracaoKey.MdiParent = this;
            frm_DemonstracaoKey.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld frm_HelloWorld = new Frm_HelloWorld();
            frm_HelloWorld.MdiParent = this;
            frm_HelloWorld.Show();

        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Mascara frm_Mascara = new Frm_Mascara();
            frm_Mascara.MdiParent = this;
            frm_Mascara.Show();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 frm_ValidaCPF2 = new Frm_ValidaCPF2();
            frm_ValidaCPF2.MdiParent = this;
            frm_ValidaCPF2.Show();
        }
        
        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha frm_ValidaSenha = new Frm_ValidaSenha();
            frm_ValidaSenha.MdiParent = this;
            frm_ValidaSenha.Show();
        }

        

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void cascaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //você aponta o mdi, pega essa propriedade LayoutMid e depois coloca o tipo do layout
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);

        }
    }
}
