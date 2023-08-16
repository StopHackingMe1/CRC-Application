namespace CRC_Application
{
     partial class HelpWindow
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
               components = new System.ComponentModel.Container();
               contextMenuStrip1 = new ContextMenuStrip(components);
               label1 = new Label();
               label2 = new Label();
               label3 = new Label();
               label4 = new Label();
               fontDialog1 = new FontDialog();
               label5 = new Label();
               SuspendLayout();
               // 
               // contextMenuStrip1
               // 
               contextMenuStrip1.ImageScalingSize = new Size(20, 20);
               contextMenuStrip1.Name = "contextMenuStrip1";
               contextMenuStrip1.Size = new Size(61, 4);
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.BackColor = SystemColors.Info;
               label1.ForeColor = SystemColors.ControlText;
               label1.Location = new Point(58, 39);
               label1.Name = "label1";
               label1.Size = new Size(513, 20);
               label1.TabIndex = 1;
               label1.Text = "To add a new card, fill in the required fields and click the \"Save Card\" button";
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.BackColor = SystemColors.Info;
               label2.Location = new Point(58, 89);
               label2.Name = "label2";
               label2.Size = new Size(545, 40);
               label2.TabIndex = 2;
               label2.Text = "To delete a card, make sure the card you want to delete is selected within the list \r\nview. Then click the \"Delete\" button\r\n";
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.BackColor = SystemColors.Info;
               label3.Location = new Point(58, 167);
               label3.Name = "label3";
               label3.Size = new Size(470, 20);
               label3.TabIndex = 3;
               label3.Text = "Click the \"Clear Form\" button to clear information from the text boxes";
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.BackColor = SystemColors.Info;
               label4.Location = new Point(58, 225);
               label4.Name = "label4";
               label4.Size = new Size(513, 40);
               label4.TabIndex = 4;
               label4.Text = "To read a card, select from the list of cards and click the \"Read Card\" button.\r\nThis will open a new window with your class card's information.";
               // 
               // label5
               // 
               label5.AutoSize = true;
               label5.BackColor = SystemColors.Info;
               label5.Location = new Point(58, 290);
               label5.Name = "label5";
               label5.Size = new Size(515, 40);
               label5.TabIndex = 5;
               label5.Text = "To save all cards, click the \"User\" menu and select \"Save all Cards\". Next time\r\nthe application opens, your cards list will still be there.\r\n";
               // 
               // HelpWindow
               // 
               AutoScaleDimensions = new SizeF(8F, 20F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(655, 369);
               Controls.Add(label5);
               Controls.Add(label4);
               Controls.Add(label3);
               Controls.Add(label2);
               Controls.Add(label1);
               Name = "HelpWindow";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "HelpWindow";
               ResumeLayout(false);
               PerformLayout();
          }

          #endregion

          private ContextMenuStrip contextMenuStrip1;
          private Label label1;
          private Label label2;
          private Label label3;
          private Label label4;
          private FontDialog fontDialog1;
          private Label label5;
     }
}