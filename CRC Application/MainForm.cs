using CRC_Application.Properties;
using System.Data;

namespace CRC_Application
{
     public partial class CrcFormLabel : Form
     {
          DataTable table; //This creates a dataTable for storing information of CRC cards
          string p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "mydata.xml"); //Data of datatable will be in XML file
          public CrcFormLabel()
          {
               InitializeComponent();
          }


          private void Form1_Load(object sender, EventArgs e)
          {


               if (!File.Exists(p)) //if the XML file containing data doesn't exist, create a table
               {
                    table = new DataTable { TableName = "CardData" };
                    table.Columns.Add("Cards List (By Class Name)", typeof(string));
                    table.Columns.Add("Description", typeof(string));
                    table.Columns.Add("Responsibilities", typeof(string));
                    table.Columns.Add("Collaboraters", typeof(string));


               }
               else //Else use the existing data in the XML file
               {
                    table = new DataTable { TableName = "CardData" };
                    table.ReadXml(p);
               }


               //This setsthe properties of the table so that only the class name shows in the list for columns
               dataGridViewCards.DataSource = table;
               dataGridViewCards.Columns["Description"].Visible = false;
               dataGridViewCards.Columns["Responsibilities"].Visible = false;
               dataGridViewCards.Columns["Collaboraters"].Visible = false;
               dataGridViewCards.Columns["Cards List (By Class Name)"].Width = 458;



          }

          //This clears the form so that the user can input new information for card details
          private void newCardButton_Click(object sender, EventArgs e)
          {
               classTextBox.Clear();
               descriptionTextBox.Clear();
               responseTextBox.Clear();
               collabTextBox.Clear();
          }

          //This saves the current card to the list of cards
          private void saveCardButton_Click(object sender, EventArgs e)
          {
               //This is for error handling. If the class name is empty, the card cannot be saved since it needs that identifier
               if (classTextBox.Text != "")
               {
                    table.Rows.Add(classTextBox.Text, descriptionTextBox.Text, responseTextBox.Text, collabTextBox.Text);
                    clearFormButton.PerformClick();
               }
               else
               {
                    //Prints message box to the screen for the user to fill the class name field
                    MessageBox.Show("Class name cannot be empty", "Empty Class Field");
               }


          }

          //This event is used for reading the card that is selected within the list of cards
          private void loadCardButton_Click(object sender, EventArgs e)
          {
               CardDisplay displayCard = new CardDisplay();


               if (dataGridViewCards.Rows.Count == 0) //If no cards exist, print a message to the user
               {
                    MessageBox.Show("There are no cards to read", "No cards available for reading");
               }
               else
               {
                    //This is responsible for loading the selected card in another window with all information provided
                    int index = dataGridViewCards.CurrentCell.RowIndex;
                    displayCard.className = table.Rows[index].ItemArray[0].ToString();
                    displayCard.description = table.Rows[index].ItemArray[1].ToString();
                    displayCard.responsibilities = table.Rows[index].ItemArray[2].ToString();
                    displayCard.collaborators = table.Rows[index].ItemArray[3].ToString();
                    displayCard.Show();
               }


          }

          //This is the implementation of the help menu for the application, discussing how to use the software
          private void helpToolStripMenuItem_Click(object sender, EventArgs e)
          {
               HelpWindow userHelp = new HelpWindow();
               userHelp.Show();
          }

          //This function is responsible for deleting cards. If there arent any cards to delete, it lets the user know in a messagebox
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

          private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
          {
               table.WriteXml(p, XmlWriteMode.WriteSchema);
          }
     }
}