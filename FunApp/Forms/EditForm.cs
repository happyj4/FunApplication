using FunApplication.Models;
using System.ComponentModel;


namespace FunApplication.Forms
{
    public partial class EditForm : Form
    {
        readonly SportsmanList sportsman = new SportsmanList ();
        SportsmanScript  sportsmanScript = new SportsmanScript();
        const string PATH_TO_DATA = ".\\sportsmen.txt";


        public EditForm(SportsmanList sportsman) // властивості спортсмена
        {
            InitializeComponent();

            this.sportsman = sportsman;
            idBox.Text = sportsman.Id.ToString();
            nameBox.Text = sportsman.Name;
            surnameBox.Text = sportsman.Surname;
            ageBox.Text = sportsman.Age.ToString();
            heightBox.Text = sportsman.Height.ToString();
            countryBox.Text = sportsman.Country;
            weightBox.Text = sportsman.Weight.ToString();
            clubBox.Text = sportsman.Club;
            sportBox.Text = sportsman.Sport;
            aboutSportsmanBox.Text = sportsman.aboutSportsman;
            pointBox.Text = sportsman.sportsRecord.ToString();
        }


        public EditForm()
        {
            InitializeComponent();
        }




        private void okButton_Click(object sender, EventArgs e)
        {
            sportsman.Name = nameBox.Text;
            sportsman.Surname = surnameBox.Text;
            sportsman.Age = Convert.ToInt32(ageBox.Text);
            sportsman.Height = Convert.ToInt32(heightBox.Text);
            sportsman.Country = countryBox.Text;
            sportsman.Weight = Convert.ToInt32(weightBox.Text);
            sportsman.Club = clubBox.Text;
            sportsman.Sport = sportBox.Text;
            sportsman.aboutSportsman = aboutSportsmanBox.Text;
            sportsman.sportsRecord = Convert.ToInt32(pointBox.Text);
        }



        private void uploadImgBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBoxFace.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка, спробуйте ще раз");
            }
        }

        private void nameBox_Validating(object sender, CancelEventArgs e)
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



        private void surnameBox_Validating(object sender, CancelEventArgs e)
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

        private void weightBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(weightBox.Text, out int weight);
            if (!isNumber)
            {
                MessageBox.Show("Тут повинні бути числа.");
                e.Cancel = true;
            }
            else if (weight <= 30)
            {
                MessageBox.Show("Вага занадто маленька.");
                e.Cancel = true;
            }

            else if (weight >= 1000)
            {
                MessageBox.Show("Вага занадто велика.");
                e.Cancel = true;
            }
        }


        private void heightBox_Validating(object sender, CancelEventArgs e)
        {

            bool isNumber = int.TryParse(heightBox.Text, out int height);
            if (!isNumber)
            {
                MessageBox.Show("Тут повинні бути числа.");
                e.Cancel = true;
            }
            else if (height <= 0)
            {
                MessageBox.Show("Зріст не може бути менше нуля.");
                e.Cancel = true;
            }

            else if (height >= 400)
            {
                MessageBox.Show("Зріст занадто великий.");
                e.Cancel = true;
            }
        }

        private void ageBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(ageBox.Text, out int age);
            if (!isNumber)
            {
                MessageBox.Show("Тут повинні бути числа.");
                e.Cancel = true;
            }
            else if (age <= 0)
            {
                MessageBox.Show("Вік не може бути менше нуля.");
                e.Cancel = true;
            }

            else if (age >= 200)
            {
                MessageBox.Show("Вік занадто великий.");
                e.Cancel = true;
            }
        }

        private void aboutSportsmanBox_Validating(object sender, CancelEventArgs e)
        {
            if (aboutSportsmanBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Це поле не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (aboutSportsmanBox.Text.Trim().Length > 550)
            {
                MessageBox.Show("занадто багато.");
                e.Cancel = true;
            }

            else if (aboutSportsmanBox.Text.Trim().Length < 100)
            {
                MessageBox.Show("занадто мало.");
                e.Cancel = true;
            }
        }

        private void pointBox_Validating(object sender, CancelEventArgs e)
        {
            bool isNumber = int.TryParse(pointBox.Text, out int point);
            if (!isNumber)
            {
                MessageBox.Show("Тут повинні бути числа.");
                e.Cancel = true;
            }
            else if (point <= 0)
            {
                MessageBox.Show("Не може бути менше нуля.");
                e.Cancel = true;
            }

            else if (point >= 100000)
            {
                MessageBox.Show("Занадто велике число.");
                e.Cancel = true;
            }


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

        private void clubBox_Validating(object sender, CancelEventArgs e)
        {

            bool containsDigit = clubBox.Text.Any(char.IsDigit);
            if (clubBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Це поле не повинно бути порожнім.");
                e.Cancel = true;
            }

            else if (clubBox.Text.Trim().Length > 20)
            {
                MessageBox.Show("Занадто багато символів.");
                e.Cancel = true;
            }

            else if (clubBox.Text.Trim().Length < 0)
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

        private void countryBox_Validating(object sender, CancelEventArgs e)
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

        private void uplButnFlag_Click(object sender, EventArgs e)
        {
            try
            {
                string imageLocation = "";
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    pictureBoxFace.ImageLocation = dialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка, спробуйте ще раз");
            }
        }

       

        
    }
}
