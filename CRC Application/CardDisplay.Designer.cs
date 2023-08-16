namespace CRC_Application
{
     partial class CardDisplay
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               classNameLabel = new Label();
               descriptionLabel = new Label();
               responsibilitiesLabel = new Label();
               collaboratorsLabel = new Label();
               classNameText = new Label();
               classDescriptionText = new Label();
               classResponsibilitiesText = new Label();
               classCollaboratorsText = new Label();
               formDivider1 = new Label();
               formDivider2 = new Label();
               label1 = new Label();
               SuspendLayout();
               // 
               // classNameLabel
               // 
               classNameLabel.AutoSize = true;
               classNameLabel.BackColor = SystemColors.Info;
               classNameLabel.Location = new Point(61, 45);
               classNameLabel.Name = "classNameLabel";
               classNameLabel.Size = new Size(52, 23);
               classNameLabel.TabIndex = 0;
               classNameLabel.Text = "Class:";
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.BackColor = SystemColors.Info;
               descriptionLabel.Location = new Point(61, 106);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new Size(100, 23);
               descriptionLabel.TabIndex = 1;
               descriptionLabel.Text = "Description:";
               // 
               // responsibilitiesLabel
               // 
               responsibilitiesLabel.AutoSize = true;
               responsibilitiesLabel.BackColor = SystemColors.Info;
               responsibilitiesLabel.Location = new Point(61, 200);
               responsibilitiesLabel.Name = "responsibilitiesLabel";
               responsibilitiesLabel.Size = new Size(129, 23);
               responsibilitiesLabel.TabIndex = 2;
               responsibilitiesLabel.Text = "Responsibilities:";
               // 
               // collaboratorsLabel
               // 
               collaboratorsLabel.AutoSize = true;
               collaboratorsLabel.BackColor = SystemColors.Info;
               collaboratorsLabel.Location = new Point(523, 200);
               collaboratorsLabel.Name = "collaboratorsLabel";
               collaboratorsLabel.Size = new Size(116, 23);
               collaboratorsLabel.TabIndex = 3;
               collaboratorsLabel.Text = "Collaborators:";
               // 
               // classNameText
               // 
               classNameText.AutoSize = true;
               classNameText.BackColor = SystemColors.Control;
               classNameText.Location = new Point(141, 46);
               classNameText.Name = "classNameText";
               classNameText.Size = new Size(0, 23);
               classNameText.TabIndex = 4;
               // 
               // classDescriptionText
               // 
               classDescriptionText.AutoSize = true;
               classDescriptionText.BackColor = SystemColors.Control;
               classDescriptionText.Location = new Point(165, 106);
               classDescriptionText.Name = "classDescriptionText";
               classDescriptionText.Size = new Size(0, 23);
               classDescriptionText.TabIndex = 5;
               // 
               // classResponsibilitiesText
               // 
               classResponsibilitiesText.AutoSize = true;
               classResponsibilitiesText.BackColor = SystemColors.Control;
               classResponsibilitiesText.Location = new Point(61, 243);
               classResponsibilitiesText.Name = "classResponsibilitiesText";
               classResponsibilitiesText.Size = new Size(0, 23);
               classResponsibilitiesText.TabIndex = 6;
               // 
               // classCollaboratorsText
               // 
               classCollaboratorsText.AutoSize = true;
               classCollaboratorsText.BackColor = SystemColors.Control;
               classCollaboratorsText.Location = new Point(523, 243);
               classCollaboratorsText.Name = "classCollaboratorsText";
               classCollaboratorsText.Size = new Size(0, 23);
               classCollaboratorsText.TabIndex = 7;
               // 
               // formDivider1
               // 
               formDivider1.BackColor = SystemColors.ButtonFace;
               formDivider1.BorderStyle = BorderStyle.Fixed3D;
               formDivider1.Location = new Point(-3, 85);
               formDivider1.Name = "formDivider1";
               formDivider1.Size = new Size(918, 2);
               formDivider1.TabIndex = 8;
               // 
               // formDivider2
               // 
               formDivider2.BackColor = SystemColors.ButtonFace;
               formDivider2.BorderStyle = BorderStyle.Fixed3D;
               formDivider2.Location = new Point(-3, 180);
               formDivider2.Name = "formDivider2";
               formDivider2.Size = new Size(918, 2);
               formDivider2.TabIndex = 9;
               // 
               // label1
               // 
               label1.BorderStyle = BorderStyle.Fixed3D;
               label1.Location = new Point(417, 180);
               label1.Name = "label1";
               label1.Size = new Size(2, 330);
               label1.TabIndex = 10;
               // 
               // CardDisplay
               // 
               AutoScaleDimensions = new SizeF(9F, 23F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(900, 518);
               Controls.Add(label1);
               Controls.Add(formDivider2);
               Controls.Add(formDivider1);
               Controls.Add(classCollaboratorsText);
               Controls.Add(classResponsibilitiesText);
               Controls.Add(classDescriptionText);
               Controls.Add(classNameText);
               Controls.Add(collaboratorsLabel);
               Controls.Add(responsibilitiesLabel);
               Controls.Add(descriptionLabel);
               Controls.Add(classNameLabel);
               Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
               Name = "CardDisplay";
               Text = "Card Display";
               Load += Form2_Load;
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label classNameLabel;
          private Label descriptionLabel;
          private Label responsibilitiesLabel;
          private Label collaboratorsLabel;
          private Label classNameText;
          private Label classDescriptionText;
          private Label classResponsibilitiesText;
          private Label classCollaboratorsText;
          private Label formDivider1;
          private Label formDivider2;
          private Label label1;
     }
}