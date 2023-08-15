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
               classTextBoxLabel = new TextBox();
               classNameLabel = new Label();
               label1 = new Label();
               label2 = new Label();
               label3 = new Label();
               responseTextBoxLabel = new TextBox();
               collabTextBoxLabel = new TextBox();
               descriptionTextBoxLabel = new TextBox();
               newCardButton = new Button();
               saveCardButton = new Button();
               loadCardButton = new Button();
               deleteCardButton = new Button();
               dataGridViewCards = new DataGridView();
               ((System.ComponentModel.ISupportInitialize)dataGridViewCards).BeginInit();
               SuspendLayout();
               // 
               // classTextBoxLabel
               // 
               classTextBoxLabel.Location = new Point(117, 12);
               classTextBoxLabel.Name = "classTextBoxLabel";
               classTextBoxLabel.Size = new Size(305, 27);
               classTextBoxLabel.TabIndex = 0;
               // 
               // classNameLabel
               // 
               classNameLabel.AutoSize = true;
               classNameLabel.Location = new Point(25, 15);
               classNameLabel.Name = "classNameLabel";
               classNameLabel.Size = new Size(86, 20);
               classNameLabel.TabIndex = 1;
               classNameLabel.Text = "Class Name";
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.Location = new Point(25, 86);
               label1.Name = "label1";
               label1.Size = new Size(85, 20);
               label1.TabIndex = 2;
               label1.Text = "Description";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(5, 178);
               label2.Name = "label2";
               label2.Size = new Size(112, 20);
               label2.TabIndex = 4;
               label2.Text = "Responsibilities";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Location = new Point(11, 263);
               label3.Name = "label3";
               label3.Size = new Size(99, 20);
               label3.TabIndex = 5;
               label3.Text = "Collaborators";
               // 
               // responseTextBoxLabel
               // 
               responseTextBoxLabel.Location = new Point(117, 161);
               responseTextBoxLabel.Multiline = true;
               responseTextBoxLabel.Name = "responseTextBoxLabel";
               responseTextBoxLabel.Size = new Size(305, 58);
               responseTextBoxLabel.TabIndex = 6;
               // 
               // collabTextBoxLabel
               // 
               collabTextBoxLabel.Location = new Point(117, 242);
               collabTextBoxLabel.Multiline = true;
               collabTextBoxLabel.Name = "collabTextBoxLabel";
               collabTextBoxLabel.Size = new Size(305, 57);
               collabTextBoxLabel.TabIndex = 14;
               // 
               // descriptionTextBoxLabel
               // 
               descriptionTextBoxLabel.Location = new Point(117, 68);
               descriptionTextBoxLabel.Multiline = true;
               descriptionTextBoxLabel.Name = "descriptionTextBoxLabel";
               descriptionTextBoxLabel.Size = new Size(305, 64);
               descriptionTextBoxLabel.TabIndex = 16;
               // 
               // newCardButton
               // 
               newCardButton.Location = new Point(54, 467);
               newCardButton.Name = "newCardButton";
               newCardButton.Size = new Size(144, 49);
               newCardButton.TabIndex = 17;
               newCardButton.Text = "New Card";
               newCardButton.UseVisualStyleBackColor = true;
               newCardButton.Click += newCardButton_Click;
               // 
               // saveCardButton
               // 
               saveCardButton.Location = new Point(239, 467);
               saveCardButton.Name = "saveCardButton";
               saveCardButton.Size = new Size(144, 49);
               saveCardButton.TabIndex = 18;
               saveCardButton.Text = "Save Card";
               saveCardButton.UseVisualStyleBackColor = true;
               saveCardButton.Click += saveCardButton_Click;
               // 
               // loadCardButton
               // 
               loadCardButton.Location = new Point(427, 467);
               loadCardButton.Name = "loadCardButton";
               loadCardButton.Size = new Size(144, 49);
               loadCardButton.TabIndex = 19;
               loadCardButton.Text = "Read Card";
               loadCardButton.UseVisualStyleBackColor = true;
               loadCardButton.Click += loadCardButton_Click;
               // 
               // deleteCardButton
               // 
               deleteCardButton.Location = new Point(617, 467);
               deleteCardButton.Name = "deleteCardButton";
               deleteCardButton.Size = new Size(144, 49);
               deleteCardButton.TabIndex = 20;
               deleteCardButton.Text = "Delete Card";
               deleteCardButton.UseVisualStyleBackColor = true;
               // 
               // dataGridViewCards
               // 
               dataGridViewCards.AllowUserToAddRows = false;
               dataGridViewCards.AllowUserToDeleteRows = false;
               dataGridViewCards.AllowUserToResizeColumns = false;
               dataGridViewCards.AllowUserToResizeRows = false;
               dataGridViewCards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridViewCards.Location = new Point(494, 12);
               dataGridViewCards.Name = "dataGridViewCards";
               dataGridViewCards.ReadOnly = true;
               dataGridViewCards.RowHeadersVisible = false;
               dataGridViewCards.RowHeadersWidth = 51;
               dataGridViewCards.RowTemplate.Height = 29;
               dataGridViewCards.Size = new Size(458, 287);
               dataGridViewCards.TabIndex = 21;
               // 
               // CrcFormLabel
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(977, 543);
               Controls.Add(dataGridViewCards);
               Controls.Add(deleteCardButton);
               Controls.Add(loadCardButton);
               Controls.Add(saveCardButton);
               Controls.Add(newCardButton);
               Controls.Add(descriptionTextBoxLabel);
               Controls.Add(collabTextBoxLabel);
               Controls.Add(responseTextBoxLabel);
               Controls.Add(label3);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(classNameLabel);
               Controls.Add(classTextBoxLabel);
               Name = "CrcFormLabel";
               Text = "CRC Card Application";
               Load += Form1_Load;
               ((System.ComponentModel.ISupportInitialize)dataGridViewCards).EndInit();
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private TextBox classTextBoxLabel;
          private Label classNameLabel;
          private Label label1;
          private Label label2;
          private Label label3;
          private TextBox responseTextBoxLabel;
          private TextBox collabTextBoxLabel;
          private TextBox descriptionTextBoxLabel;
          private Button newCardButton;
          private Button saveCardButton;
          private Button loadCardButton;
          private Button deleteCardButton;
          private DataGridView dataGridViewCards;
     }
}