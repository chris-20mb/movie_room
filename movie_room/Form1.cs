using System.Threading;

namespace movie_room
{
    public partial class Form1 : Form
    {
        public string user = "chris";
        public string password = "1234";

        Thread nt;
        public Form1()
        {
            
            InitializeComponent();
            
            pictureBox1.Load("C:/PROJECTS/movie_room/movie_room/movie_room/img/popcorn.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userLogin = userBox.Text;
            string passwordLogin = password_box.Text;
            if (userLogin == user && passwordLogin == password)
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else {
                MessageBox.Show("Conta não encontrada!");
            }
        }

        private void novoForm(object? obj)
        {
            Application.Run(new Form2());
        }
    }
}
