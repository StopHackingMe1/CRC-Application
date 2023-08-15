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
               table.Columns.Add("Title", typeof(string));
               table.Columns.Add("Description", typeof(string));
               table.Columns.Add("Responsibilities", typeof(string));
               table.Columns.Add("Collaboraters", typeof(string));

               dataGridViewCards.DataSource = table;
               dataGridViewCards.Columns["Description"].Visible = false;
               dataGridViewCards.Columns["Responsibilities"].Visible = false;
               dataGridViewCards.Columns["Collaboraters"].Visible = false;
          }

          private void newCardButton_Click(object sender, EventArgs e)
          {
               classTextBoxLabel.Clear();
               descriptionTextBoxLabel.Clear();
               responseTextBoxLabel.Clear();
               collabTextBoxLabel.Clear();
          }

          private void saveCardButton_Click(object sender, EventArgs e)
          {
               table.Rows.Add(classTextBoxLabel.Text, descriptionTextBoxLabel.Text, responseTextBoxLabel.Text, collabTextBoxLabel.Text);
               newCardButton.PerformClick();
          }

          private void loadCardButton_Click(object sender, EventArgs e)
          {
               Form2 displayCard = new Form2();

               

              int index = dataGridViewCards.CurrentCell.RowIndex;

               if(index > -1)
               {
                    displayCard.className = table.Rows[index].ItemArray[0].ToString();
                    displayCard.description = table.Rows[index].ItemArray[1].ToString();
                    displayCard.responsibilities = table.Rows[index].ItemArray[2].ToString();
                    displayCard.collaborators = table.Rows[index].ItemArray[3].ToString();

               }

               displayCard.Show();

               //This is a Test

          }
     }
}