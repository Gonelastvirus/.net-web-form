using System;
using System.Web;
using System.Web.UI;
using Mono.Data.Sqlite;
using System.Data;
using System.Text;
using System.Configuration;
namespace employee
{

    public partial class Default : System.Web.UI.Page
    {
        StringBuilder table = new StringBuilder();
        public void Button1Clicked(object sender, EventArgs args)
        {
            /*String cs = @"Data Source=file:/home/lastvirus/Projects/employee/employee.db;Version=3;";
            SqliteConnection con = new SqliteConnection(cs); 
            String query = "insert into employee('"+txtv1.Text+"'"+")";
            con.Open();

            SqliteCommand cmd = new SqliteCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            using (var dbconnection = new SqliteConnection(@"Data Source=file:/home/lastvirus/Projects/employee/employee.db;Version=3;"))
            {
                dbconnection.Open();
                String sql = @"INSERT INTO ""employee""(""name"") VALUES(""TEST"")";
                using (var insertCommand = new SqliteCommand(sql, dbconnection))
                {
                    insertCommand.ExecuteNonQuery();
                }
                dbconnection.Close();
                err.Text = "data inserted";

            }*/
            String cs = @"URI=file:/home/lastvirus/Projects/employee/employee.sqlite;Version=3;";
            using (var con = new SqliteConnection(cs))
            {
                con.Open();
                using (SqliteCommand cmd = new SqliteCommand("INSERT INTO employee(name) VALUES(@name)"))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@name", txtv1.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    err.Text = "Data Saved";
                }
                txtv1.Text = " ";
                con.Close();
            }

        }


        public void Button2Clicked(object sender, EventArgs args)
        {
            /*string cs = @"URI=file:/home/lastvirus/Projects/employee/employee.sqlite";

            using (var con = new SqliteConnection(cs)) 
            {
                con.Open();

                string stm = "SELECT * FROM employee";

                using (var cmd = new SqliteCommand(stm, con))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        table.Append("<table border='1'>");
                        table.Append("<tr><th>ID</th><th>Name</th>");
                        table.Append("</tr>");
                        if (rdr.HasRows)
                        {
                            while (rdr.Read())
                            {
                                table.Append("<tr>");
                                table.Append("<td>"+rdr[0]+"</td>");
                                table.Append("<td>" + rdr[1] + "</td>");
                                table.Append("</tr>");
                            }
                        }
                        table.Append("</table>");
                        placeholder1.Controls.Add(new LiteralControl { Text = table.ToString() });
                        rdr.Close();
                        con.Close();
                    }
                }
            }*/

        }


        public void Button3Clicked(object sender, EventArgs args)
        {

            String cs = @"URI=file:/home/lastvirus/Projects/employee/employee.sqlite;Version=3;";
            using (var con = new SqliteConnection(cs))
            {
                con.Open();
                using (SqliteCommand cmd = new SqliteCommand("DELETE FROM employee WHERE id='"+txtv2.Text+"'"))
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    label2.Text = "Data Deleted";
                }
                txtv2.Text = " ";
                con.Close();
            }


        }

        public void Button4Clicked(object sender, EventArgs args)
        {
            String cs = @"URI=file:/home/lastvirus/Projects/employee/employee.sqlite;Version=3;";
            using (var con = new SqliteConnection(cs))
            {
                con.Open();
                using (SqliteCommand cmd = new SqliteCommand("UPDATE employee  SET name='" + txtv4.Text + "'"+"WHERE id='"+txtv3.Text+"'"))
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    label5.Text = "Data Update";
                }
                txtv3.Text = " ";
                txtv4.Text = " ";
                con.Close();
            }
        }


    }
        
}
