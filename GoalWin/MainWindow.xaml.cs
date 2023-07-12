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
        string GNameinfo;
        string GNoteinfo;
        string GPri;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Gsum_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Gname.Text))
            {
                string numericValue = Gname.Text;
                GInputState.Text = "Goal Summited";
                GInputState.Foreground = new SolidColorBrush(Colors.Green);


                GDateinfo = GDate.Text;
                GNameinfo = Gname.Text;
                GNoteinfo = Gnote.Text;
                GPri = Gpry.Text;


                if (string.IsNullOrEmpty(GDate.Text))
                {
                    GDateinfo = "none";
                }
                if (string.IsNullOrEmpty(Gnote.Text))
                {
                    GNoteinfo = "none";
                }
                if (string.IsNullOrEmpty(Gpry.Text))
                {
                    GPri = "none";
                }
                GDate.Text = "";
                Gname.Text = "";
                Gnote.Text = "";
                Gpry.Text = "";
                Console.Write("Name of Goal: " + GNameinfo + " Date: " + GDateinfo + " Notes: " + GNoteinfo + " Priority: " + GPri);

            }
            else
            {
                GInputState.Foreground = new SolidColorBrush(Colors.Red);
                GInputState.Text = "Please Enter A Name For Your Goal";
            }


                
        }

        private void NumericTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Check if the entered text is a valid number
            if (!int.TryParse(e.Text, out _))
            {
                e.Handled = true; // Cancel the input event if it is not a number
            }
        }

        private void Gleave(object sender, MouseEventArgs e)
        {
            GInputState.Text = "";
;        }
    }
}
