namespace CRC_Application
{
     partial class Form2
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
               label1 = new Label();
               classNameText = new Label();
               classDescriptionText = new Label();
               classResponsibilitiesText = new Label();
               classCollaboratorsText = new Label();
               SuspendLayout();
               // 
               // classNameLabel
               // 
               classNameLabel.AutoSize = true;
               classNameLabel.Location = new Point(54, 39);
               classNameLabel.Name = "classNameLabel";
               classNameLabel.Size = new Size(45, 20);
               classNameLabel.TabIndex = 0;
               classNameLabel.Text = "Class:";
               // 
               // descriptionLabel
               // 
               descriptionLabel.AutoSize = true;
               descriptionLabel.Location = new Point(54, 92);
               descriptionLabel.Name = "descriptionLabel";
               descriptionLabel.Size = new Size(88, 20);
               descriptionLabel.TabIndex = 1;
               descriptionLabel.Text = "Description:";
               // 
               // responsibilitiesLabel
               // 
               responsibilitiesLabel.AutoSize = true;
               responsibilitiesLabel.Location = new Point(54, 174);
               responsibilitiesLabel.Name = "responsibilitiesLabel";
               responsibilitiesLabel.Size = new Size(115, 20);
               responsibilitiesLabel.TabIndex = 2;
               responsibilitiesLabel.Text = "Responsibilities:";
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(465, 174);
               label1.Name = "label1";
               label1.Size = new Size(102, 20);
               label1.TabIndex = 3;
               label1.Text = "Collaborators:";
               // 
               // classNameText
               // 
               classNameText.AutoSize = true;
               classNameText.Location = new Point(125, 40);
               classNameText.Name = "classNameText";
               classNameText.Size = new Size(0, 20);
               classNameText.TabIndex = 4;
               // 
               // classDescriptionText
               // 
               classDescriptionText.AutoSize = true;
               classDescriptionText.Location = new Point(147, 92);
               classDescriptionText.Name = "classDescriptionText";
               classDescriptionText.Size = new Size(0, 20);
               classDescriptionText.TabIndex = 5;
               // 
               // classResponsibilitiesText
               // 
               classResponsibilitiesText.AutoSize = true;
               classResponsibilitiesText.Location = new Point(54, 211);
               classResponsibilitiesText.Name = "classResponsibilitiesText";
               classResponsibilitiesText.Size = new Size(0, 20);
               classResponsibilitiesText.TabIndex = 6;
               // 
               // classCollaboratorsText
               // 
               classCollaboratorsText.AutoSize = true;
               classCollaboratorsText.Location = new Point(465, 211);
               classCollaboratorsText.Name = "classCollaboratorsText";
               classCollaboratorsText.Size = new Size(0, 20);
               classCollaboratorsText.TabIndex = 7;
               // 
               // Form2
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(800, 450);
               Controls.Add(classCollaboratorsText);
               Controls.Add(classResponsibilitiesText);
               Controls.Add(classDescriptionText);
               Controls.Add(classNameText);
               Controls.Add(label1);
               Controls.Add(responsibilitiesLabel);
               Controls.Add(descriptionLabel);
               Controls.Add(classNameLabel);
               Name = "Form2";
               Text = "Form2";
               Load += Form2_Load;
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private Label classNameLabel;
          private Label descriptionLabel;
          private Label responsibilitiesLabel;
          private Label label1;
          private Label classNameText;
          private Label classDescriptionText;
          private Label classResponsibilitiesText;
          private Label classCollaboratorsText;
     }
}