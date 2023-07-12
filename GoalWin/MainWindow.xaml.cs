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

namespace GoalWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string GDateinfo;
        String GNameinfo;
        string GNoteinfo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Gsum_Click(object sender, RoutedEventArgs e)
        {
            GDateinfo = GDate.Text;
            GNameinfo = Gname.Text;
            GNoteinfo = Gnote.Text;
            Console.Write("Name of Goal: "+ GNameinfo + " Date: " + GDateinfo + " Notes: " + GNoteinfo);
             
        }

    }
}
