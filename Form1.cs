using System;
using System.Windows.Forms;

namespace Machine
{
    public partial class Form1 : Form
    {
        private CoffeeMachine machine;
        private Label lblStatus;
        public Form1()
        {
            InitializeComponent();

            machine = new CoffeeMachine(1000, 500, 500, 500);
            lblStatus = new Label();

            lblStatus = new Label();
            lblStatus.Text = "สถานะ: พร้อมใช้งาน";
            lblStatus.Size = new Size(100, 100);
            lblStatus.Location = new Point(300, 330);
            lblStatus.ForeColor = Color.Black;
            lblStatus.BackColor = Color.Transparent; 
            this.Controls.Add(lblStatus);

            this.Text = "เครื่องขายกาแฟอัตโนมัติ";
            this.Size = new Size(700, 400);
            this.BackColor = Color.BurlyWood;
            this.ForeColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            textBox1.Text = "เลือกเมนู";
            textBox1.ReadOnly = true;
            textBox1.TextAlign = HorizontalAlignment.Center;

            Button1.Text = "ทำลาเต้";
            Button1.Click += (sender, e) => textBox1.Text = machine.MakeLatte(1);
            Button1.BackColor = Color.Peru;
            Button1.ForeColor = Color.Black;
            Button1.FlatStyle = FlatStyle.Flat;

            Button2.Text = "ทำกาแฟดำ";
            Button2.Click += (sender, e) => textBox1.Text = machine.MakeBlackCoffee(1);
            Button2.BackColor = Color.Peru;
            Button2.ForeColor = Color.Black;
            Button2.FlatStyle = FlatStyle.Flat;

            Button5.Text = "น้ำเปล่า";
            Button5.Click += (sender, e) => textBox1.Text = machine.PlainWater(1);
            Button5.BackColor = Color.Peru;
            Button5.ForeColor = Color.Black;
            Button5.FlatStyle = FlatStyle.Flat;

            Button6.Text = "นม";
            Button6.Click += (sender, e) => textBox1.Text = machine.PlainMilk(1);
            Button6.BackColor = Color.Peru;
            Button6.ForeColor = Color.Black;
            Button6.FlatStyle = FlatStyle.Flat;

            Button3.Text = "แสดงสต็อก";
            Button3.Click += (sender, e) => textBox1.Text = machine.ShowStock();
            Button3.BackColor = Color.Peru;
            Button3.ForeColor = Color.Black;
            Button3.FlatStyle = FlatStyle.Flat;

            Button4.Text = "เติมสต็อก";
            Button4.Click += (sender, e) => textBox1.Text = machine.IncreaseStock();
            Button4.BackColor = Color.Peru;
            Button4.ForeColor = Color.Black;
            Button4.FlatStyle = FlatStyle.Flat;
        }
    }
}

