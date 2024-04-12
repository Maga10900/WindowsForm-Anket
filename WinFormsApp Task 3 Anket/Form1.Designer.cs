namespace WinFormsApp_Task_3_Anket
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Anket_Group = new GroupBox();
            Button_Add_Change = new Button();
            Button_Change = new Button();
            DateTime_Dogum = new DateTimePicker();
            TextBox_Tel = new TextBox();
            TextBox_Email = new TextBox();
            TextBox_Soyad = new TextBox();
            TextBox_Ad = new TextBox();
            Label_Dogum = new Label();
            Label_Telefon = new Label();
            Label_Email = new Label();
            Label_Soyad = new Label();
            Label_Ad = new Label();
            ListBox = new ListBox();
            TextBox = new TextBox();
            Button_Save = new Button();
            Button_Load = new Button();
            Anket_Group.SuspendLayout();
            SuspendLayout();
            // 
            // Anket_Group
            // 
            Anket_Group.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Anket_Group.Controls.Add(Button_Add_Change);
            Anket_Group.Controls.Add(Button_Change);
            Anket_Group.Controls.Add(DateTime_Dogum);
            Anket_Group.Controls.Add(TextBox_Tel);
            Anket_Group.Controls.Add(TextBox_Email);
            Anket_Group.Controls.Add(TextBox_Soyad);
            Anket_Group.Controls.Add(TextBox_Ad);
            Anket_Group.Controls.Add(Label_Dogum);
            Anket_Group.Controls.Add(Label_Telefon);
            Anket_Group.Controls.Add(Label_Email);
            Anket_Group.Controls.Add(Label_Soyad);
            Anket_Group.Controls.Add(Label_Ad);
            Anket_Group.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Anket_Group.Location = new Point(4, 0);
            Anket_Group.Name = "Anket_Group";
            Anket_Group.Size = new Size(694, 578);
            Anket_Group.TabIndex = 0;
            Anket_Group.TabStop = false;
            Anket_Group.Text = "Anket";
            // 
            // Button_Add_Change
            // 
            Button_Add_Change.BackColor = Color.White;
            Button_Add_Change.FlatStyle = FlatStyle.Flat;
            Button_Add_Change.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Add_Change.Location = new Point(288, 414);
            Button_Add_Change.Name = "Button_Add_Change";
            Button_Add_Change.Size = new Size(378, 132);
            Button_Add_Change.TabIndex = 11;
            Button_Add_Change.Text = "Add List";
            Button_Add_Change.UseVisualStyleBackColor = false;
            Button_Add_Change.Click += Button_Add_Change_Click;
            // 
            // Button_Change
            // 
            Button_Change.BackColor = Color.Transparent;
            Button_Change.BackgroundImage = Properties.Resources.night_mode;
            Button_Change.BackgroundImageLayout = ImageLayout.Zoom;
            Button_Change.FlatAppearance.BorderSize = 0;
            Button_Change.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Button_Change.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Button_Change.FlatStyle = FlatStyle.Flat;
            Button_Change.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Change.ForeColor = Color.Transparent;
            Button_Change.Location = new Point(27, 434);
            Button_Change.Name = "Button_Change";
            Button_Change.Size = new Size(178, 99);
            Button_Change.TabIndex = 10;
            Button_Change.UseVisualStyleBackColor = false;
            Button_Change.Click += Button_Change_Click;
            // 
            // DateTime_Dogum
            // 
            DateTime_Dogum.Location = new Point(178, 343);
            DateTime_Dogum.Name = "DateTime_Dogum";
            DateTime_Dogum.Size = new Size(350, 34);
            DateTime_Dogum.TabIndex = 9;
            // 
            // TextBox_Tel
            // 
            TextBox_Tel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Tel.Location = new Point(178, 261);
            TextBox_Tel.Name = "TextBox_Tel";
            TextBox_Tel.Size = new Size(505, 39);
            TextBox_Tel.TabIndex = 8;
            // 
            // TextBox_Email
            // 
            TextBox_Email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Email.Location = new Point(178, 186);
            TextBox_Email.Name = "TextBox_Email";
            TextBox_Email.Size = new Size(505, 39);
            TextBox_Email.TabIndex = 7;
            // 
            // TextBox_Soyad
            // 
            TextBox_Soyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Soyad.Location = new Point(178, 111);
            TextBox_Soyad.Name = "TextBox_Soyad";
            TextBox_Soyad.Size = new Size(505, 39);
            TextBox_Soyad.TabIndex = 6;
            // 
            // TextBox_Ad
            // 
            TextBox_Ad.BackColor = Color.White;
            TextBox_Ad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox_Ad.Location = new Point(178, 41);
            TextBox_Ad.Name = "TextBox_Ad";
            TextBox_Ad.Size = new Size(505, 39);
            TextBox_Ad.TabIndex = 5;
            // 
            // Label_Dogum
            // 
            Label_Dogum.AutoSize = true;
            Label_Dogum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Dogum.Location = new Point(27, 343);
            Label_Dogum.Name = "Label_Dogum";
            Label_Dogum.Size = new Size(94, 32);
            Label_Dogum.TabIndex = 4;
            Label_Dogum.Text = "Dogum";
            // 
            // Label_Telefon
            // 
            Label_Telefon.AutoSize = true;
            Label_Telefon.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Telefon.Location = new Point(27, 264);
            Label_Telefon.Name = "Label_Telefon";
            Label_Telefon.Size = new Size(44, 32);
            Label_Telefon.TabIndex = 3;
            Label_Telefon.Text = "Tel";
            // 
            // Label_Email
            // 
            Label_Email.AutoSize = true;
            Label_Email.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Email.Location = new Point(27, 189);
            Label_Email.Name = "Label_Email";
            Label_Email.Size = new Size(71, 32);
            Label_Email.TabIndex = 2;
            Label_Email.Text = "Email";
            // 
            // Label_Soyad
            // 
            Label_Soyad.AutoSize = true;
            Label_Soyad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Soyad.Location = new Point(27, 114);
            Label_Soyad.Name = "Label_Soyad";
            Label_Soyad.Size = new Size(79, 32);
            Label_Soyad.TabIndex = 1;
            Label_Soyad.Text = "Soyad";
            // 
            // Label_Ad
            // 
            Label_Ad.AutoSize = true;
            Label_Ad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Ad.Location = new Point(27, 44);
            Label_Ad.Name = "Label_Ad";
            Label_Ad.Size = new Size(43, 32);
            Label_Ad.TabIndex = 0;
            Label_Ad.Text = "Ad";
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 20;
            ListBox.Location = new Point(704, 12);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(366, 444);
            ListBox.TabIndex = 1;
            ListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TextBox.Location = new Point(704, 462);
            TextBox.Name = "TextBox";
            TextBox.PlaceholderText = "File adi daxil edin";
            TextBox.Size = new Size(366, 36);
            TextBox.TabIndex = 2;
            // 
            // Button_Save
            // 
            Button_Save.FlatStyle = FlatStyle.Flat;
            Button_Save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Save.Location = new Point(704, 504);
            Button_Save.Name = "Button_Save";
            Button_Save.Size = new Size(183, 66);
            Button_Save.TabIndex = 3;
            Button_Save.Text = "Save";
            Button_Save.UseVisualStyleBackColor = true;
            Button_Save.Click += Button_Save_Click;
            // 
            // Button_Load
            // 
            Button_Load.FlatStyle = FlatStyle.Flat;
            Button_Load.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Button_Load.Location = new Point(893, 504);
            Button_Load.Name = "Button_Load";
            Button_Load.Size = new Size(177, 66);
            Button_Load.TabIndex = 4;
            Button_Load.Text = "Load";
            Button_Load.UseVisualStyleBackColor = true;
            Button_Load.Click += Button_Load_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 578);
            Controls.Add(Button_Load);
            Controls.Add(Button_Save);
            Controls.Add(TextBox);
            Controls.Add(ListBox);
            Controls.Add(Anket_Group);
            Name = "Form1";
            Text = "Anket";
            Anket_Group.ResumeLayout(false);
            Anket_Group.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Anket_Group;
        private TextBox TextBox_Soyad;
        private TextBox TextBox_Ad;
        private Label Label_Dogum;
        private Label Label_Telefon;
        private Label Label_Email;
        private Label Label_Soyad;
        private Label Label_Ad;
        private DateTimePicker DateTime_Dogum;
        private TextBox TextBox_Tel;
        private TextBox TextBox_Email;
        private Button Button_Change;
        private ListBox ListBox;
        private TextBox TextBox;
        private Button Button_Add_Change;
        private Button Button_Save;
        private Button Button_Load;
    }
}
