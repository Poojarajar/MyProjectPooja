using System.Data;
using System.Data.SqlClient;
//using System.Security.Cryptography.Pkcs;
namespace Employee_Project_2
{
    public partial class StoreProcedure : Form
    {

        SqlConnection con = new SqlConnection("Server=DESKTOP-A3NAL7E\\SQLSERVER2022;DataBase=employeedb;User Id=sa;Password=user123;");
        SqlCommand cmd;
        SqlParameter p1;
        SqlDataReader dr;


        public StoreProcedure()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void BTNInsert_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTEmp.Text);
            cmd.Parameters.Add(p1);



            p1 = new SqlParameter("@PEmpName", SqlDbType.VarChar);
            p1.Value = TXTEmpName.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpDesig", SqlDbType.VarChar);
            p1.Value = TXTEmpDesig.Text;
            cmd.Parameters.Add(p1);



            p1 = new SqlParameter("@PEmpDOJ", SqlDbType.DateTime);
            p1.Value = TXTEmpDOJ.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpSal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTSal.Text);
            cmd.Parameters.Add(p1);



            p1 = new SqlParameter("@PEmpDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTEmpDeptNO.Text);
            cmd.Parameters.Add(p1);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)Inserted");
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SPEmp_Update1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTEmp.Text);
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpName", SqlDbType.VarChar);
            p1.Value = TXTEmpName.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpDesig", SqlDbType.VarChar);
            p1.Value = TXTEmpDesig.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpDOJ", SqlDbType.DateTime);
            p1.Value = TXTEmpDOJ.Text;
            cmd.Parameters.Add(p1);


            p1 = new SqlParameter("@PEmpSal", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTSal.Text);
            cmd.Parameters.Add(p1);



            p1 = new SqlParameter("@PEmpDept", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTEmpDeptNO.Text);
            cmd.Parameters.Add(p1);


            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(s)Updated");

        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DelRecP1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            p1 = new SqlParameter("@PEmpId", SqlDbType.Int);
            p1.Value = Convert.ToInt32(TXTEmp.Text);
            cmd.Parameters.Add(p1);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + "record(S)deleted");
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BTNFind_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select *from employeetb where EMpId =" + TXTEmp.Text, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            dr= cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                TXTEmp.Text = dr[0].ToString();
                TXTEmpName.Text = dr[1].ToString();
                TXTEmpDesig.Text = dr[2].ToString();
                TXTEmpDOJ.Text = dr[3].ToString();
                TXTSal.Text = dr[4].ToString();
                TXTEmpDeptNO.Text = dr[5].ToString();

            }

            else
            {
                MessageBox.Show("records not found");
                dr.Close();
            }
            con.Close();

        }

        //private void Empidlbl_Click(object sender, EventArgs e)
        //{

        //}

        //private void StoreProcedure_Load(object sender, EventArgs e)
        //{

        //}
    }
}
