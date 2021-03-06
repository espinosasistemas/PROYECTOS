﻿using SCI.COMMON.Entidades;
using SCI.COMMON.Interfaces;
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
        usuario user;
        
        public FormPrincipal(usuario u)
        {
            InitializeComponent();
            customizeDising();
            user = u;
        }

        private void customizeDising()
        {
            panelCatalogoSubMenu.Visible = true;
            panelViajesSubMenu.Visible = true;
            panelFacturaSubMenu.Visible = true;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema de Control de Servicios Corporativos Integrales. - Bienvenido " + user.NombreCompleto;
        }

        private void hideSubmenu()
        {
            if (panelCatalogoSubMenu.Visible == true)
                panelCatalogoSubMenu.Visible = false;
            if (panelViajesSubMenu.Visible == true)
                panelViajesSubMenu.Visible = false;
            if (panelFacturaSubMenu.Visible == true)
                panelFacturaSubMenu.Visible = false;
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
            //showSubMenu(panelCatalogoSubMenu);
        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelViajesSubMenu);
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelFacturaSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormUnidades(user));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormOperadores(user));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormClientes(user));
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormRutas(user));
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormOtros(user));
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormViajes(user));
        }
        private void btnCasetas_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormCasetas(user));
        }

        private void btnGasolineria_Click(object sender, EventArgs e)
        {
            openDashBoardForm(new FormGasolinerias(user));
        }

        private void btnFactura_Click_1(object sender, EventArgs e)
        {
            openDashBoardForm(new FormFacturas(user));
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

        

        

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
