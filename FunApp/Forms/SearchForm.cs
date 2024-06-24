
using FunApplication.Models;

namespace FunApplication.Forms
{
    public partial class SearchForm : Form
    {
        const string PATH_TO_DATA = ".\\sportsmen.txt";
        SportsmanScript sportsmanScript = new SportsmanScript();


        public SearchForm()
        {
            InitializeComponent();
            sportsmanScript = sportsmanScript.LoadData(PATH_TO_DATA);
        }




        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                var result = sportsmanScript.Search(sportBox.Text, nameBox.Text, surnameBox.Text, countryBox.Text, clubBox.Text);


                sportsmanListBindingSource.DataSource = result;


                if (resultList.SelectedItem is SportsmanList sportsmanClick)
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
                    MessageBox.Show("Немає спортсмена з такими парметрами.", "Пошук", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sportsmanScript.SaveData(PATH_TO_DATA);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sportsmanScript = sportsmanScript.LoadData(PATH_TO_DATA);
        }



        private void resultList_DoubleClick_1(object sender, EventArgs e)
        {
            if (resultList.SelectedItems.Count > 0)
            {
                SportsmanList sportsman = resultList.SelectedItem as SportsmanList;
                var editForm = new EditForm(sportsman);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    searchButton_Click(null, null);
                }
            }
        }

        private void resultList_Click(object sender, EventArgs e)
        {
            SportsmanList sportsmanClick = resultList.SelectedItem as SportsmanList;
            pictureBoxFace.ImageLocation = sportsmanClick.ImageLocation;


            pictureBoxFlag.ImageLocation = sportsmanClick.ImageLocationFlag;
        }



        private void buttonGoBackMainForm_Click(object sender, EventArgs e)
        {
            sportsmanScript.SaveData(PATH_TO_DATA);
            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }

        //ЗАКРТИТТЯ ФОРМИ


        private void SearchForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            sportsmanScript.SaveData(PATH_TO_DATA);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool containsDigit = nameBox.Text.Any(char.IsDigit);
            if (containsDigit)
            {
                MessageBox.Show("Ім'я не повинно містити цифри.");
                e.Cancel = true;
            }
            else if (nameBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ім'я не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (nameBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("Ім'я занадто велике.");
                e.Cancel = true;
            }

        }


        private void surnameBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool containsDigit = surnameBox.Text.Any(char.IsDigit);
            if (surnameBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Прізвище не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (surnameBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("Прізвище занадто велике.");
                e.Cancel = true;
            }


            else if (containsDigit)
            {
                MessageBox.Show("Прізвище не повинно містити цифри.");
                e.Cancel = true;
            }
        }

        private void sportBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void countryBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool containsDigit = countryBox.Text.Any(char.IsDigit);
            if (countryBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Це поле не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (countryBox.Text.Trim().Length > 25)
            {
                MessageBox.Show("Занадто багато символів.");
                e.Cancel = true;
            }

            else if (countryBox.Text.Trim().Length < 3)
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

        private void додатиСпортсменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SportsmanList sportsman = new SportsmanList
            {
                Id = new Random().Next(100000, 1000000),

            };

            var dialog = new EditForm(sportsman);
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                sportsmanScript.SportsmanList.Add(sportsman);


                sportsmanScript.SaveData(PATH_TO_DATA);
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
    }
}
