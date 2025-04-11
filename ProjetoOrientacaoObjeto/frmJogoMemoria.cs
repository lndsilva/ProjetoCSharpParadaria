using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoOrientacaoObjeto
{
    public partial class frmJogoMemoria : Form
    {

        Random rdm = new Random();

        List<string> icons = new List<string>()
        {

        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"

        };

        public frmJogoMemoria()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        public void AssignIconsToSquares()
        {
            foreach (Control control in tlbJogoMemoria.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null) { 
                    int randomNumber = rdm.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    //iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }
    }
}
