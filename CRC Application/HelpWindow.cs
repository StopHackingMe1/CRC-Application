using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC_Application
{
     public partial class HelpWindow : Form
     {
          public HelpWindow()
          {
               InitializeComponent();
          }

          private void HelpWindow_FormClosing(object sender, FormClosingEventArgs e)
          {
               Application.Exit(); //Terminates the application after pressing the exit button
          }
     }
}
