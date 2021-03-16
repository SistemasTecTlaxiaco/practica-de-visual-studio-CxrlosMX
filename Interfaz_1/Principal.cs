using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            costunizeDesing();
        }
        private void costunizeDesing() {
            PanelSlider_menu.Visible = false;
            subMenu_medios.Visible = false;

  
        }
        private void hideSubMenu() { 
        
        }

    }
}
