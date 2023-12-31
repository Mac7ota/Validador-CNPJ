using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnValidaCnpj_Click(object sender, EventArgs e)
        {
            Validacao valid = new Validacao();
            mtbCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; //Retira caracteres especiais menos espaçamento 
            string cnpj = mtbCnpj.Text;
            valid.validarCnpj(cnpj);
            bool verFal = valid.validarCnpj(cnpj);
            if (verFal)
            {
                MessageBox.Show("CNPJ VÁLIDO");
            }
            else
            {
                MessageBox.Show("CNPJ INVÁLIDO");
            }
        }
    }
}
