using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace Exercise_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            var arlist = new ArrayList()
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            foreach (var ar in arlist)
            {
                listBox.Items.Add(ar);
            };
            listBox.SelectedIndexChanged += new EventHandler(listBox_SelectedIndexChanged);
            // Here, every time a different item on the listbox is clicked, we are are saying to trigger an "new" event handler to accomodate that change
            // in this case, referring the "listBox_SelectedIndexChanged" event handler at the bottom of this code.
            // += means "Add this event handler to the list of handlers that should be called when the SelectedIndexChanged event is fired."

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string selectedDay = listBox.SelectedItem.ToString();
            string filePath = $"C:/Users/kiran/Downloads/My Week Days/{selectedDay}.txt";
            try
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(textBox.Text);
                sw.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error writing file: {ex.Message}");
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDay = listBox.SelectedItem.ToString();
            string filePath = $"C:/Users/kiran/Downloads/My Week Days/{selectedDay}.txt";

            try
            {
                StreamReader sr = new StreamReader(filePath);
                textBox.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error reading file: {ex.Message}");
            }
        }
    }
}