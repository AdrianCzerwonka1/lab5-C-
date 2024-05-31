using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public class Person
    {
        private string FName;
        private string MName;
        private string LName;
        private string Street1;
        private string Street2;
        private string City;
        private string State;
        private string Zip;
        private string Phone;
        private string Email;

        public string FirstName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }
        public string MidName
        {
            get
            {
                return MName;
            }
            set
            {
                MName = value;
            }
        }
        public string LastName
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public string StreetOne
        {
            get
            {
                return Street1;
            }
            set
            {
                Street1 = value;
            }
        }
        public string StreetTwo
        {
            get
            {
                return Street2;
            }
            set
            {
                Street2 = value;
            }
        }
        public string PubCity
        {
            get
            {
                return City;
            }
            set
            {
                City = value;
            }
        }
        public string PubState
        {
            get
            {
                return State;
            }
            set
            {
                State = value;
            }
        }
        public string ZipCode
        {
            get
            {
                return Zip;
            }
            set
            {
                Zip = value;
            }
        }
        public string PhoneNum
        {
            get
            {
                return Phone;
            }
            set
            {
                Phone = value;
            }
        }
        public string UserEmail
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

    }




    public class Insta : Person
    {
        private string Instagram;
        private string CellPhone;
        public string UserInsta
        {
            get
            {
                return Instagram;
            }
            set
            {
                Instagram = value;
            }
        }

        public string Cell
        {
            get
            {
                return CellPhone;
            }
            set
            {
                CellPhone = value;
            }

        }

        public string AddARecord()
        {
            Console.WriteLine("Help me step 1");
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
            Conn.ConnectionString = @"Server=sql.neit.edu\sqlstudentserver,4500;Database=Dev_202430_ACzerwonka;User Id=Dev_202430_ACzerwonka;Password=008022318;";     //Set the Who/What/Where of DB
            Console.WriteLine("Help me step 2");

            //*******************************************************************************************************
            // NEW
            //*******************************************************************************************************
            string strSQL = "INSERT INTO Workers (FName, MName, LName, Street1, Street2, City, State, Zip, Phone, Email, InstagramURL, CellPhone) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Phone, @Email, @InstagramURL, @CellPhone)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is
            Console.WriteLine("Help me step 3");
            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@FName", FirstName);
            comm.Parameters.AddWithValue("@MName", MidName);
            comm.Parameters.AddWithValue("@LName", LastName);
            comm.Parameters.AddWithValue("@Street1", StreetOne);
            comm.Parameters.AddWithValue("@Street2", StreetTwo);
            comm.Parameters.AddWithValue("@City", PubCity);
            comm.Parameters.AddWithValue("@State", PubState);
            comm.Parameters.AddWithValue("@Zip", ZipCode);
            comm.Parameters.AddWithValue("@Phone", PhoneNum);
            comm.Parameters.AddWithValue("@Email", UserEmail);
            comm.Parameters.AddWithValue("@InstagramURL", Instagram);
            comm.Parameters.AddWithValue("@CellPhone", Cell);
            Console.WriteLine("Help me step 5");

            //*******************************************************************************************************





            //attempt to connect to the server
            try
            {
                Conn.Open();
                Console.WriteLine("Help me step 6.1");
                int intRecs = comm.ExecuteNonQuery();
                Console.WriteLine("Help me step 6.2");
                strResult = $"SUCCESS: Inserted {intRecs} records.";
                Conn.Close();
                Console.WriteLine("Help me step 6");
            }
            catch (Exception err)
            {
                Console.WriteLine("Help me step 7");
                strResult = "ERROR: " + err.Message;
            }
            finally
            {

            }
            //Return resulting feedback string
            return strResult;
        }
    }

}



