using System.Data;

namespace CRC_Application
{
     public partial class CrcFormLabel : Form
     {
          DataTable table;
          public CrcFormLabel()
          {
               InitializeComponent();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               table = new DataTable();
               table.Columns.Add("Cards List", typeof(string));
               table.Columns.Add("Description", typeof(string));
               table.Columns.Add("Responsibilities", typeof(string));
               table.Columns.Add("Collaboraters", typeof(string));

               dataGridViewCards.DataSource = table;
               dataGridViewCards.Columns["Description"].Visible = false;
               dataGridViewCards.Columns["Responsibilities"].Visible = false;
               dataGridViewCards.Columns["Collaboraters"].Visible = false;
               dataGridViewCards.Columns["Cards List"].Width = 458;
          }

          private void newCardButton_Click(object sender, EventArgs e)
          {
               classTextBox.Clear();
               descriptionTextBox.Clear();
               responseTextBox.Clear();
               collabTextBox.Clear();
          }

          private void saveCardButton_Click(object sender, EventArgs e)
          {
               if (classTextBox.Text != "")
               {
                    table.Rows.Add(classTextBox.Text, descriptionTextBox.Text, responseTextBox.Text, collabTextBox.Text);
                    clearFormButton.PerformClick();
               }
               else
               {
                    MessageBox.Show("Class name cannot be empty", "Empty Class Field");
               }


          }

          private void loadCardButton_Click(object sender, EventArgs e)
          {
               CardDisplay displayCard = new CardDisplay();



              

               if (dataGridViewCards.Rows.Count == 0)
               {
                    MessageBox.Show("There are no cards to read", "No cards available for reading");
               }
               else
               {
                    int index = dataGridViewCards.CurrentCell.RowIndex;
                    displayCard.className = table.Rows[index].ItemArray[0].ToString();
                    displayCard.description = table.Rows[index].ItemArray[1].ToString();
                    displayCard.responsibilities = table.Rows[index].ItemArray[2].ToString();
                    displayCard.collaborators = table.Rows[index].ItemArray[3].ToString();
                    displayCard.Show();
               }

              

              
          }

          private void helpToolStripMenuItem_Click(object sender, EventArgs e)
          {
               this.Hide(); //Hides the main form
               HelpWindow userHelp = new HelpWindow();
               userHelp.Show();

          }

          private void deleteCardButton_Click(object sender, EventArgs e)
          {
               
               if (dataGridViewCards.Rows.Count == 0) //If count is 0, there are no more cards to delete
               {
                    MessageBox.Show("There are no more cards to delete", "Cards List Empty");
               }
               else
               {
                    int index = dataGridViewCards.CurrentCell.RowIndex;
                    table.Rows[index].Delete();
               }
               
          }
     }
}