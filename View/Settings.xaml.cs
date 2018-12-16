using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projet_Restaurant_Remake
{
    /// <summary>
    /// Lógica de interacción para Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            //Connection c = new Connection();
            //c.ShowButler(ComboBox1);
            //c.ShowheadWaiter(ComboBox2);
            //c.ShowWaiter(ComboBox3);
            //c.ShowRoomClerk(ComboBox4);
            //c.ShowHeadChef(ComboBox5);
            //c.ShowCook(ComboBox6);
            //c.ShowKitchenClerk(ComboBox7);
            //c.ShowDishWasher(ComboBox8);
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            Simulation simulation = new Simulation();
            simulation.Show();
            this.Close();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowButler(ComboBox1);
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowheadWaiter(ComboBox2);
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowWaiter(ComboBox3);
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowRoomClerk(ComboBox4);
        }

        private void ComboBox5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowHeadChef(ComboBox5);
        }

        private void ComboBox6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowCook(ComboBox6);
        }

        private void ComboBox7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowKitchenClerk(ComboBox7);
        }

        private void ComboBox8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connection c = new Connection();
            c.ShowDishWasher(ComboBox8);
        }
    }
}
