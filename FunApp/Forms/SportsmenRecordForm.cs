using FunApplication.Models;
using System.ComponentModel;


namespace FunApplication.Forms
{
    public partial class SportsmenRecordForm : Form
    {
        SportsmanScript sportsmanScript = new SportsmanScript();
        const string PATH_TO_DATA = ".\\sportsmen.txt";


        public SportsmenRecordForm()
        {
            InitializeComponent();
            sportsmanScript = sportsmanScript.LoadData(PATH_TO_DATA);

        }

        private void buttonGoBackMainForm_Click(object sender, EventArgs e)
        {
            sportsmanScript.SaveData(PATH_TO_DATA);
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                var result = sportsmanScript.Search(sportBox.Text);


                sportsmanListBindingSource.DataSource = result;


                if (resultListRecord.SelectedItem is SportsmanList sportsmanClick)
                {
                    pictureBoxFace.ImageLocation = sportsmanClick.ImageLocation;
                    pictureBoxFlag.ImageLocation = sportsmanClick.ImageLocationFlag;
                }

                else
                {
                    pictureBoxFace.ImageLocation = null;
                    pictureBoxFlag.ImageLocation = null;
                }


                if (result.Count == 0)
                {
                    MessageBox.Show("Немає спортсмена з такими парметрами.(введіть назву спорта повністю)", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

        private void resultListRecord_DoubleClick(object sender, EventArgs e)
        {
            if (resultListRecord.SelectedItems.Count > 0)
            {
                SportsmanList sportsman = resultListRecord.SelectedItem as SportsmanList;
                var editForm = new EditForm(sportsman);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    searchButton_Click(null, null);
                }
            }
        }

        private void SportsmenRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sportsmanScript.SaveData(PATH_TO_DATA);
        }

        private void sportBox_Validating(object sender, CancelEventArgs e)
        {
            bool containsDigit = sportBox.Text.Any(char.IsDigit);
            if (sportBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Це поле не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (sportBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("Занадто багато символів.");
                e.Cancel = true;
            }

            else if (sportBox.Text.Trim().Length < 0)
            {
                MessageBox.Show("Занадто мало символів.");
                e.Cancel = true;
            }

            else if (containsDigit)
            {
                MessageBox.Show("Це поле не повинно містити цифри.");
                e.Cancel = true;
            }
        }
    }


}
