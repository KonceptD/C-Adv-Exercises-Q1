using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace Exercise_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {   
            // loads the form
            InitializeComponent();

            // Create a new arrayList for the ListBox
            var arlist = new ArrayList()
            {
                // adding elements using object initializer syntax rather than populate it one by one
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            foreach (var ar in arlist)
            {
                // For each item in the arrayList, add it to the ListBox Items collection
                listBox.Items.Add(ar);
            };

            // Here, every time a different item on the listbox is clicked (SelectedIndexChanged), we are are saying to trigger an "new" event handler to accomodate that change
            listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged); // in this case, referring the "listBox_SelectedIndexChanged" event handler at the bottom of this code.

            // += means "Add this event handler to the list of handlers that should be called when the SelectedIndexChanged event is fired."

        }

        // Saving the edited or newly added text to file
        private void btnsave_Click(object sender, EventArgs e) 
        {
            // the selectDay var takes the selected item once it has been converted to a string
            string selectedDay = listBox.SelectedItem.ToString();

            // Assign the file path of the text file using string interpolation so we don't have to do it manually for each day
            string filePath = $"C:/Users/kiran/Downloads/My Week Days/{selectedDay}.txt";

            // Practice to catch errors, ensuring the success
            try
            {
                // assign the new streamwriter instance and filepath to a var
                StreamWriter sw = new StreamWriter(filePath);

                // Streamwriter writers the new or edited info in from the textbox text 
                sw.WriteLine(textBox.Text);

                // Close the StreamWrite stream
                sw.Close(); 
            }
            catch (Exception ex)
            {
                // If the streamwriting fails, a message box will pop up
                MessageBox.Show($"Error writing file: {ex.Message}"); 
            }
        }

        // Event handler for when the selected item in the listbox changes
        private void listBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            // the selectDay var takes the selected item once it has been converted to a string
            string selectedDay = listBox.SelectedItem.ToString();

            // Assign the file path of the text file using string interpolation so we don't have to do it manually for each day
            string filePath = $"C:/Users/kiran/Downloads/My Week Days/{selectedDay}.txt";

            // Practice to catch errors, ensuring the success
            try
            {
                // Assign the new StreamReader instance and filepath to a var
                StreamReader sr = new StreamReader(filePath);

                // Populates the TextBox text with StreamRead file once its read to the end
                textBox.Text = sr.ReadToEnd();

                // Closes the streamRead stream
                sr.Close();
            }
            catch (Exception ex)
            {
                // If the streamwriting fails, a message box will pop up
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }
    }
}