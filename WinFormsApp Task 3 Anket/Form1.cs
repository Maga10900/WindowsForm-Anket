using System.Windows.Forms;

namespace WinFormsApp_Task_3_Anket
{
    public partial class Form1 : Form
    {
        bool isCheck = true;
        int num = 0;
        List<User> users = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if (isCheck)//ag mod
            {
                isCheck = false;
                Button_Change.BackgroundImage = Properties.Resources.night_mode__1_;
                BackColor = Color.DimGray;
                Label_Ad.ForeColor = Color.White;
                Label_Soyad.ForeColor = Color.White;
                Label_Email.ForeColor = Color.White;
                Label_Telefon.ForeColor = Color.White;
                Label_Dogum.ForeColor = Color.White;
                TextBox_Ad.BackColor = SystemColors.ScrollBar;
                TextBox_Soyad.BackColor = SystemColors.ScrollBar;
                TextBox_Email.BackColor = SystemColors.ScrollBar;
                TextBox_Tel.BackColor = SystemColors.ScrollBar;
                TextBox.BackColor = SystemColors.ScrollBar;
                Anket_Group.ForeColor = Color.White;
                ListBox.BackColor = SystemColors.ScrollBar;
                Button_Add_Change.BackColor = SystemColors.ScrollBar;
                Button_Add_Change.ForeColor = Color.Black;
                Button_Save.BackColor = SystemColors.ScrollBar;
                Button_Save.ForeColor = Color.Black;
                Button_Load.BackColor = SystemColors.ScrollBar;
                Button_Load.ForeColor = Color.Black;
            }
            else
            {
                isCheck = true;
                Button_Change.BackgroundImage = Properties.Resources.night_mode;
                BackColor = Color.White;
                Label_Ad.ForeColor = Color.Black;
                Label_Soyad.ForeColor = Color.Black;
                Label_Email.ForeColor = Color.Black;
                Label_Telefon.ForeColor = Color.Black;
                Label_Dogum.ForeColor = Color.Black;
                TextBox_Ad.BackColor = Color.White;
                TextBox_Soyad.BackColor = Color.White;
                TextBox_Email.BackColor = Color.White;
                TextBox_Tel.BackColor = Color.White;
                TextBox.BackColor = Color.White;
                Anket_Group.ForeColor = Color.Black;
                ListBox.BackColor = Color.White;
                Button_Add_Change.BackColor = Color.White;
                Button_Add_Change.ForeColor = Color.Black;
                Button_Save.BackColor = Color.White;
                Button_Save.ForeColor = Color.Black;
                Button_Load.BackColor = Color.White;
                Button_Load.ForeColor = Color.Black;
            }
        }



        private void Button_Add_Change_Click(object sender, EventArgs e)
        {
            if (Button_Add_Change.Text == "Add List")
            {
                User a = new();
                a.Name = TextBox_Ad.Text;
                a.Surname = TextBox_Soyad.Text;
                a.Email = TextBox_Email.Text;
                a.Telefon = TextBox_Tel.Text;
                a.Dogun = DateTime_Dogum.Value;
                users.Add(a);
                ListBox.DataSource = null;
                ListBox.DataSource = users;
                TextBox_Ad.Text = string.Empty;
                TextBox_Soyad.Text = string.Empty;
                TextBox_Email.Text = string.Empty;
                TextBox_Tel.Text = string.Empty;
                DateTime_Dogum.Value = DateTime.Now;
            }
            else if(Button_Add_Change.Text == "Change")
            {
                User u = new(TextBox_Ad.Text,TextBox_Soyad.Text,TextBox_Email.Text,TextBox_Tel.Text,DateTime_Dogum.Value);
                users[ListBox.SelectedIndex] = u;
                ListBox.DataSource = null;
                ListBox.DataSource = users;
                TextBox_Ad.Text = string.Empty;
                TextBox_Soyad.Text = string.Empty;
                TextBox_Email.Text = string.Empty;
                TextBox_Tel.Text = string.Empty;
                DateTime_Dogum.Value = DateTime.Now;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (TextBox.Text != string.Empty)
            {
                Functions.WriteUserTojson(users, TextBox.Text);
                Button_Add_Change.Text = "Add List";
            }
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (File.Exists(TextBox.Text))
            {
                users = Functions.ReadUserToJson(TextBox.Text);
                TextBox.Text = string.Empty;
                ListBox.DataSource = null;
                ListBox.DataSource = users;
            }

        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Button_Add_Change.Text = "Change";
            TextBox_Ad.Text = users[ListBox.SelectedIndex].Name;
            TextBox_Soyad.Text = users[ListBox.SelectedIndex].Surname;
            TextBox_Email.Text = users[ListBox.SelectedIndex].Email;
            TextBox_Tel.Text = users[ListBox.SelectedIndex].Telefon;
            DateTime_Dogum.Value = users[ListBox.SelectedIndex].Dogun;
            ListBox.DataSource = null;
            ListBox.DataSource = users;
        }
    }
}
