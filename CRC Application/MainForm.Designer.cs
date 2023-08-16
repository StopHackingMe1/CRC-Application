namespace CRC_Application
{
     partial class CrcFormLabel
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
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
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               classTextBox = new TextBox();
               classNameLabel = new Label();
               label1 = new Label();
               label2 = new Label();
               label3 = new Label();
               responseTextBox = new TextBox();
               collabTextBox = new TextBox();
               descriptionTextBox = new TextBox();
               clearFormButton = new Button();
               saveCardButton = new Button();
               loadCardButton = new Button();
               deleteCardButton = new Button();
               dataGridViewCards = new DataGridView();
               menuStrip1 = new MenuStrip();
               userToolStripMenuItem = new ToolStripMenuItem();
               helpToolStripMenuItem = new ToolStripMenuItem();
               saveToolStripMenuItem = new ToolStripMenuItem();
               ((System.ComponentModel.ISupportInitialize)dataGridViewCards).BeginInit();
               menuStrip1.SuspendLayout();
               SuspendLayout();
               // 
               // classTextBox
               // 
               classTextBox.Location = new Point(12, 83);
               classTextBox.Name = "classTextBox";
               classTextBox.Size = new Size(305, 27);
               classTextBox.TabIndex = 0;
               // 
               // classNameLabel
               // 
               classNameLabel.AutoSize = true;
               classNameLabel.BackColor = Color.Gainsboro;
               classNameLabel.Location = new Point(12, 60);
               classNameLabel.Name = "classNameLabel";
               classNameLabel.Size = new Size(86, 20);
               classNameLabel.TabIndex = 1;
               classNameLabel.Text = "Class Name";
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = Color.Gainsboro;
               label1.Location = new Point(13, 134);
               label1.Name = "label1";
               label1.Size = new Size(85, 20);
               label1.TabIndex = 2;
               label1.Text = "Description";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.BackColor = Color.Gainsboro;
               label2.Location = new Point(13, 239);
               label2.Name = "label2";
               label2.Size = new Size(112, 20);
               label2.TabIndex = 4;
               label2.Text = "Responsibilities";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.BackColor = Color.Gainsboro;
               label3.Location = new Point(13, 344);
               label3.Name = "label3";
               label3.Size = new Size(99, 20);
               label3.TabIndex = 5;
               label3.Text = "Collaborators";
               // 
               // responseTextBox
               // 
               responseTextBox.BackColor = SystemColors.Window;
               responseTextBox.Location = new Point(13, 262);
               responseTextBox.Multiline = true;
               responseTextBox.Name = "responseTextBox";
               responseTextBox.Size = new Size(305, 58);
               responseTextBox.TabIndex = 6;
               // 
               // collabTextBox
               // 
               collabTextBox.BackColor = SystemColors.HighlightText;
               collabTextBox.Location = new Point(12, 367);
               collabTextBox.Multiline = true;
               collabTextBox.Name = "collabTextBox";
               collabTextBox.Size = new Size(305, 57);
               collabTextBox.TabIndex = 14;
               // 
               // descriptionTextBox
               // 
               descriptionTextBox.Location = new Point(12, 157);
               descriptionTextBox.Multiline = true;
               descriptionTextBox.Name = "descriptionTextBox";
               descriptionTextBox.Size = new Size(305, 60);
               descriptionTextBox.TabIndex = 16;
               // 
               // clearFormButton
               // 
               clearFormButton.Location = new Point(585, 467);
               clearFormButton.Name = "clearFormButton";
               clearFormButton.Size = new Size(144, 49);
               clearFormButton.TabIndex = 17;
               clearFormButton.Text = "Clear Form";
               clearFormButton.UseVisualStyleBackColor = true;
               clearFormButton.Click += newCardButton_Click;
               // 
               // saveCardButton
               // 
               saveCardButton.BackColor = Color.OliveDrab;
               saveCardButton.Location = new Point(13, 467);
               saveCardButton.Name = "saveCardButton";
               saveCardButton.Size = new Size(144, 49);
               saveCardButton.TabIndex = 18;
               saveCardButton.Text = "Save Card";
               saveCardButton.UseVisualStyleBackColor = false;
               saveCardButton.Click += saveCardButton_Click;
               // 
               // loadCardButton
               // 
               loadCardButton.BackColor = Color.SandyBrown;
               loadCardButton.Location = new Point(215, 467);
               loadCardButton.Name = "loadCardButton";
               loadCardButton.Size = new Size(144, 49);
               loadCardButton.TabIndex = 19;
               loadCardButton.Text = "Read Card";
               loadCardButton.UseVisualStyleBackColor = false;
               loadCardButton.Click += loadCardButton_Click;
               // 
               // deleteCardButton
               // 
               deleteCardButton.BackColor = Color.IndianRed;
               deleteCardButton.Location = new Point(405, 467);
               deleteCardButton.Name = "deleteCardButton";
               deleteCardButton.Size = new Size(144, 49);
               deleteCardButton.TabIndex = 20;
               deleteCardButton.Text = "Delete Card";
               deleteCardButton.UseVisualStyleBackColor = false;
               deleteCardButton.Click += deleteCardButton_Click;
               // 
               // dataGridViewCards
               // 
               dataGridViewCards.AllowUserToAddRows = false;
               dataGridViewCards.AllowUserToDeleteRows = false;
               dataGridViewCards.AllowUserToResizeColumns = false;
               dataGridViewCards.AllowUserToResizeRows = false;
               dataGridViewCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridViewCards.Location = new Point(498, 86);
               dataGridViewCards.Name = "dataGridViewCards";
               dataGridViewCards.ReadOnly = true;
               dataGridViewCards.RowHeadersVisible = false;
               dataGridViewCards.RowHeadersWidth = 51;
               dataGridViewCards.RowTemplate.Height = 29;
               dataGridViewCards.Size = new Size(458, 287);
               dataGridViewCards.TabIndex = 21;
               // 
               // menuStrip1
               // 
               menuStrip1.BackColor = Color.Gainsboro;
               menuStrip1.ImageScalingSize = new Size(20, 20);
               menuStrip1.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem });
               menuStrip1.Location = new Point(0, 0);
               menuStrip1.Name = "menuStrip1";
               menuStrip1.Size = new Size(977, 28);
               menuStrip1.TabIndex = 22;
               menuStrip1.Text = "menuStrip1";
               // 
               // userToolStripMenuItem
               // 
               userToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { helpToolStripMenuItem, saveToolStripMenuItem });
               userToolStripMenuItem.Name = "userToolStripMenuItem";
               userToolStripMenuItem.Size = new Size(52, 24);
               userToolStripMenuItem.Text = "User";
               // 
               // helpToolStripMenuItem
               // 
               helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               helpToolStripMenuItem.Size = new Size(224, 26);
               helpToolStripMenuItem.Text = "Help";
               helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
               // 
               // saveToolStripMenuItem
               // 
               saveToolStripMenuItem.Name = "saveToolStripMenuItem";
               saveToolStripMenuItem.Size = new Size(224, 26);
               saveToolStripMenuItem.Text = "Save All Cards";
               saveToolStripMenuItem.Click += saveAllToolStripMenuItem_Click;
               // 
               // CrcFormLabel
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               BackColor = Color.WhiteSmoke;
               ClientSize = new Size(977, 543);
               Controls.Add(dataGridViewCards);
               Controls.Add(deleteCardButton);
               Controls.Add(loadCardButton);
               Controls.Add(saveCardButton);
               Controls.Add(clearFormButton);
               Controls.Add(descriptionTextBox);
               Controls.Add(collabTextBox);
               Controls.Add(responseTextBox);
               Controls.Add(label3);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(classNameLabel);
               Controls.Add(classTextBox);
               Controls.Add(menuStrip1);
               MainMenuStrip = menuStrip1;
               Name = "CrcFormLabel";
               Text = "CRC Card Application";
               Load += Form1_Load;
               ((System.ComponentModel.ISupportInitialize)dataGridViewCards).EndInit();
               menuStrip1.ResumeLayout(false);
               menuStrip1.PerformLayout();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private TextBox classTextBox;
          private Label classNameLabel;
          private Label label1;
          private Label label2;
          private Label label3;
          private TextBox responseTextBox;
          private TextBox collabTextBox;
          private TextBox descriptionTextBox;
          private Button clearFormButton;
          private Button saveCardButton;
          private Button loadCardButton;
          private Button deleteCardButton;
          private DataGridView dataGridViewCards;
          private MenuStrip menuStrip1;
          private ToolStripMenuItem userToolStripMenuItem;
          private ToolStripMenuItem helpToolStripMenuItem;
          private ToolStripMenuItem saveToolStripMenuItem;
     }
}