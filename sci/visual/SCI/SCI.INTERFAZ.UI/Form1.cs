using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI.INTERFAZ.UI
{
    public partial class FormPrincipal : Form
    {
        private Form activeForm = null;

        public FormPrincipal()
        {
            InitializeComponent();
            customizeDising();
        }

        private void customizeDising()
        {
            panelCatalogoSubMenu.Visible = true;
            panelViajesSubMenu.Visible = false;
            panelReportesSubMenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelCatalogoSubMenu.Visible == true)
                panelCatalogoSubMenu.Visible = false;
            if (panelViajesSubMenu.Visible == true)
                panelViajesSubMenu.Visible = false;
            if (panelReportesSubMenu.Visible == true)
                panelReportesSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCatalogoSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormUnidades());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormOperadores());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Codigo
            //hideSubmenu();
        }

        
        private void openDashBoardForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDashBoard.Controls.Add(childForm);
            panelDashBoard.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
