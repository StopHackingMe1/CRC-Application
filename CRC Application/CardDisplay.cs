﻿using System;
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
     public partial class CardDisplay : Form
     {
          public string className { get; set; }
          public string description { get; set; }
          public string responsibilities { get; set; }
          public string collaborators { get; set; }

          public CardDisplay()
          {
               InitializeComponent();
          }

          private void Form2_Load(object sender, EventArgs e)
          {
               //This is responsible for taking user input for CRC cards and displaying them to the form
               classNameText.Text = className;
               classDescriptionText.Text = description;
               classResponsibilitiesText.Text = responsibilities;
               classCollaboratorsText.Text = collaborators;

          }
     }
}
