using MySql.Data.MySqlClient;
using System.Linq.Expressions;
namespace WinFormsApp1
{
    public partial class CatchBlock : Form
    {
        public CatchBlock()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=Qwerty@123;database=test";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            string sql = "Select * from tester";
            MySqlCommand cmd= new MySqlCommand(sql, con);
            MySqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                MessageBox.Show("id :" + reader["id"] + "Name :" + reader["Name"]);
                
            }
        }CatchBlock(MySqlException ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}
