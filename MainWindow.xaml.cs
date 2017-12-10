using Ecrypt_Serialize_BD.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Ecrypt_Serialize_BD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        Settings set = new Settings();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User next = new User();
            next.Username = txtA.Text;
            next.Password = Cryptor.Encr(txtB.Text);
            set.AddUser(next);
            
            set.Save();
            LoadXML();
            //grid.ItemsSource = set.Users;
            
            /*
            set.Username = txtA.Text;
            set.Encrypt(txtB.Text);
            set.Save();
            set = Settings.Load();
            Block1.Text = "Username: " + set.Username + "\n Password: " + set.Password + "";*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        /*

            set=Settings.Load();
            Block2.Text = "Username: " + set.Username + "\n Password: " + set.Decrypt() + "";*/
        }
        public int a =0;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {/*
            using (AccModelContext context = new AccModelContext())
            {
                a++;
                Acc acc = new Acc();
                acc.Id = a;
                acc.Username = set.Username;
                acc.Password = set.Decrypt();
                context.Accounts.Add(acc);
                context.SaveChanges();*/
        }
    

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {/*
            SqlConnection con = new SqlConnection(@"data source=.\MSSQLSERVERGEORG;initial catalog=AccountsDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Accs",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DBgrid.ItemsSource = dt.DefaultView;*/
        }

        public void Button_Click_4(object sender, RoutedEventArgs e)
        {
            LoadXML();


        }

        private void LoadXML()
        {
            set = Settings.Load();
            grid.ItemsSource = set.Users;

        }



    }
    }
