using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Create();
        }

        public void Create()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source = DIZKY\\DIZKY ;database=ProdiTI ;Integrated Security = True");
                con.Open();

                SqlCommand cm = new SqlCommand("Create Table Mahasiswa_Coba (NIM Char(12) not null primary key, Nama Varchar(50), Alamat Varchar(50), Jenis_Kelamin char(5))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Create tabel berhasil");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error",  e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}











