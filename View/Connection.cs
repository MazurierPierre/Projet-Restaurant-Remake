using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Projet_Restaurant_Remake
{
    class Connection
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Connection()
        {
            try
            {
                cnn = new SqlConnection("Data Source=. ;Initial Catalog=projet_restaurant;Integrated Security=True");
                cnn.Open();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowButler(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 0", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error"+ex.ToString());
            }
        }

        public void ShowheadWaiter(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 1", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowWaiter(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 2", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowRoomClerk(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 3", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowHeadChef(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 4", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowCook(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 5", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowKitchenClerk(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 6", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }

        public void ShowDishWasher(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select name from Members where roleid = 7", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["name"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("Error" + ex.ToString());
            }
        }
    }
}
