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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz_25
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

        private void btn_Num_0_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 0;
        private void btn_Num_1_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 1;
        private void btn_Num_2_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 2;
        private void btn_Num_3_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 3;
        private void btn_Num_4_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 4;
        private void btn_Num_5_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 5;
        private void btn_Num_6_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 6;
        private void btn_Num_7_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 7;
        private void btn_Num_8_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 8;
        private void btn_Num_9_Click(object sender, RoutedEventArgs e) => tb_Result.Text += 9;

        private void btn_Del_Click(object sender, RoutedEventArgs e)                                            // *Написать функционал для отмены последних трёх действий
        {
        }
        private void btn_Clear_Click(object sender, RoutedEventArgs e) => tb_Result.Text = "";
        private void btn_Plus_Click(object sender, RoutedEventArgs e) => tb_Result.Text += "+";                // *Написать проверку на наличие уже имеющегося символа для калькуляции
        private void btn_Minus_Click(object sender, RoutedEventArgs e) => tb_Result.Text += "-";
        private void btn_Devide_Click(object sender, RoutedEventArgs e) => tb_Result.Text += "/";
        private void btn_Multiply_Click(object sender, RoutedEventArgs e) => tb_Result.Text += "*";
        private void btn_ToSquare_Click(object sender, RoutedEventArgs e)
        {
            string temp = "(" + tb_Result.Text + ")^2";
            tb_Result.Text = temp;
        }

        private void btn_Num_res_Click(object sender, RoutedEventArgs e)
        {
            tb_Result.Text += "=";
        }
    }
}
