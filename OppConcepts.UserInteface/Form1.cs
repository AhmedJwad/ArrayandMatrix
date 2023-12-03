using OppConcepts.Logic;

namespace OppConcepts.UserInteface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("please in insert a year", "Error");
                return;
            }
            if (txtMonth.Text.Length == 0)
            {
                MessageBox.Show("please in insert a month", "Error");
                return;
            }
            if (txtDay.Text.Length == 0)
            {
                MessageBox.Show("please in insert a day", "Error");
                return;
            }
            try
            {
                int Year = Convert.ToInt32(txtYear.Text);
                int Month = Convert.ToInt32(txtMonth.Text);
                int Day = Convert.ToInt32(txtDay.Text);
                var date= new Date(Year, Month, Day);
                MessageBox.Show($"{date}", "Confirm");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}