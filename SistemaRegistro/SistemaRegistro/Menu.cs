﻿using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SistemaRegistro
{
    public partial class Menu : Form
    {

        private Login logHandler;
        int t;
        public Menu(Login log, int tipo)
        {
            InitializeComponent();
            costomizeDesing();
            t = tipo;
            tipoUser();
            logHandler = log;

        }
        private void tipoUser()
        {
            //en caso de ser administrador
            if (t == 0)
            {
                panelLateral.Enabled = true;
                btnUsuarios.Visible = true;
                btnFormulario.Visible = true;
                btnEntradasSalidas.Visible = true;
                btnNavegacion.Visible = true;
                btnBitacora.Visible = true;
                labelPerfilU.Visible = false;
                labelPerfil.Text = "Administrador";

            }
            //en caso de ser capturador
            else if (t == 1)
            {
                panelLateral.Enabled = true;
                btnUsuarios.Visible = false;
                btnFormulario.Visible = true;
                btnEntradasSalidas.Visible = true;
                btnNavegacion.Visible = true;
                btnBitacora.Visible = false;
                labelPerfil.Visible = false;
                labelPerfilU.Text = "Usuario";
            }
        }

        private void costomizeDesing()
        {
            panelSubUsuarios.Visible = false;
            panelSubFormulario.Visible = false;
            panelSubEntradas.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubUsuarios.Visible == true)
                panelSubUsuarios.Visible = false;
            if (panelSubFormulario.Visible == true)
                panelSubFormulario.Visible = false;
            if (panelSubEntradas.Visible == true)
                panelSubEntradas.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubUsuarios);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            openContenedorForm(new RegistroUsuario());
            hideSubMenu();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            openContenedorForm(new ListarUsuario());
            hideSubMenu();
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubFormulario);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            openContenedorForm(new RegistroFormulario());
            hideSubMenu();
        }

        private void btnListaDatos_Click(object sender, EventArgs e)
        {
            openContenedorForm(new ListaFormulario());
            hideSubMenu();
        }

        private void btnEntradasSalidas_Click(object sender, EventArgs e)
        {

            showSubMenu(panelSubEntradas);
        }

        private void btnRegistroEntradas_Click(object sender, EventArgs e)
        {
            openContenedorForm(new RegistroEntradasSalidas());
            hideSubMenu();
        }

        private void btnListaEntradas_Click(object sender, EventArgs e)
        {
            openContenedorForm(new ListaEntradasSalidas());
            hideSubMenu();
        }

        private void btnNavegacion_Click(object sender, EventArgs e)
        {
            openContenedorForm(new NavegacionProcesos());
            hideSubMenu();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            openContenedorForm(new Bitacora());
            hideSubMenu();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resut = MessageBox.Show("¿Está seguro de cerrar sesión?", "Warning", MessageBoxButtons.YesNo);
            if (resut == DialogResult.Yes)
            {
                // log.logoutx(idper);
                //Login inicioSesion = new Login();
                //inicioSesion.Show();
                logHandler.Show();
                this.Hide();
            }
            else if (resut == DialogResult.No)
            {
                return;
            }
        }

        private Form activeForm = null;
        private void openContenedorForm(Form contnedorForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contnedorForm;
            contnedorForm.TopLevel = false;
            contnedorForm.FormBorderStyle = FormBorderStyle.None;
            contnedorForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(contnedorForm);
            panelContenedor.Tag = contnedorForm;
            contnedorForm.BringToFront();
            contnedorForm.Show();



        }

        //evento que asegura que al cerrar el form se cierre la aplicacion y se haga un logout al usuario
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //log.logoutx(idper);
            logHandler.Close();
        }
    }
}