using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



namespace spoofer
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();

        }


        //Method for firebase connection
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "NuHfD8AJJ8xOod70Au0bYtf4zjxVt7ySeGv5HBI9",
            BasePath = "https://spoofer-af6ea-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("There was an error connecting to Internet!");
            }
        }

 

        private void spooferLaunher_MouseLeave(object sender, EventArgs e)
        {
            spooferLaunher.BackColor = Color.Transparent;
            spooferLaunher.ForeColor= Color.White;
        }

        private void spooferLaunher_MouseEnter(object sender, EventArgs e)
        {
            spooferLaunher.BackColor = Color.White;

            spooferLaunher.ForeColor = Color.Black;
        }

        private void spooferLaunher_Click(object sender, EventArgs e)
        {
            string id = subKeyTextBox1.Text;
            MessageBox.Show(id);
            //Fething data from database
            FirebaseResponse response = client.Get("customerList/" + id);
            customer responsecst = response.ResultAs<customer>();  //result from database
            //Now value from textboxes of current login

            customer curcst = new customer()
            {
                subk1 = subKeyTextBox1.Text,
            };

            if (customer.IsEqual(responsecst, curcst))
            {
                //Now checkig expiry date
                if (customer.IsExpire(responsecst)) {
                    this.Hide();
                    UserMenu usmenu = new UserMenu();
                    usmenu.Show();
                }
                else
                {
                    MessageBox.Show("Subscription Has been expired");
                }

            }
            else
            {
                MessageBox.Show("Wrong Login Info!!");
            }



        }

        private void subKeyTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.subKeyTextBox1.MaxLength = 8;

        }
    }
}