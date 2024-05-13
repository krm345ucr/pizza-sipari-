namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplamfiyat = 75;

            if(radioButton1.Checked == true )
            {
                
            }
            else if(radioButton2.Checked == true )
            {
                toplamfiyat += 5;

            }


            if(checkBox1.Checked == true )
            {
                toplamfiyat = toplamfiyat + 15;
            }
            if(checkBox2.Checked == true )
            {
                toplamfiyat = toplamfiyat + 20;
            }
            if(checkBox3.Checked == true )
            {
                toplamfiyat += 15;
            }
            if(checkBox4.Checked == true )
            {
                toplamfiyat += 25;
            }
            if (checkBox5.Checked == true )
            {
                toplamfiyat += 30;

            }
            if(checkBox6.Checked == true )
            {
                toplamfiyat += 10;
            }
            if(checkBox7.Checked == true )
            {
                toplamfiyat += 20;
            }
            if(checkBox8.Checked == true )
            {
                toplamfiyat += 20;
            }
            else
            {
                textBox1.Text=Convert.ToString(toplamfiyat);
            }
            textBox1.Text = toplamfiyat.ToString();

            
            
           
                
          

        }
    }
}
