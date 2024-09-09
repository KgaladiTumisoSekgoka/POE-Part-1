using System;
using System.Windows;
using MySql.Data.MySqlClient;

namespace POEPart1
{
    public partial class MainWindow : Window
    {
        private string connectionString = "server=localhost;database=cmcs;uid=root;";

        public MainWindow()
        {
            InitializeComponent();
        }    
    }
}
