using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
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
using static System.Net.Mime.MediaTypeNames;
using Path = System.IO.Path;

namespace GoalWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        string GDateinfo;
        string GNameinfo;
        string GNoteinfo;
        string GPri;
        string GfilePath = @"C:\Users\djsco\source\repos\Goal Helper\GoalWin\Stored Goals.txt";
        string[] targetWords = { "Name:", "Date:", "Notes:", "Pri:" };
        string content = string.Empty;







        public MainWindow()
        {
            InitializeComponent();

        }
        public class GList
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Notes { get; set; }
            public string Pri { get; set; }
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


                string[] lines = File.ReadAllLines(GfilePath);

                // Iterate over each line
                foreach (string line in lines)
                {
                    // Iterate over each target word
                    foreach (string targetWord in targetWords)
                    {
                        // Use regular expressions to extract the word next to the target word
                        Match match = Regex.Match(line, $@"{targetWord}\s+(\w+)");

                        if (match.Success)
                        {
                            // Extract the word next to the target word
                            string extractedWord = match.Groups[1].Value;
                            Console.WriteLine($"Target Word: {targetWord}, Extracted Word: {extractedWord}");
                        }
                    }
                }


                //Clear console for .txt show
                Console.Clear();
                //.txt read/write
                using (StreamWriter sw =new StreamWriter(GfilePath, true))
                {
                    sw.WriteLine();
                    sw.WriteLine("Name of Goal: " + GNameinfo + " Date: " + GDateinfo + " Notes: " + GNoteinfo + " Priority: " + GPri);
                }

                using (StreamReader sr = new StreamReader(GfilePath))
                {
                    content = sr.ReadToEnd();
                    Console.WriteLine(content);
                }


                //sets Goal list
                List<GList> Goal = new List<GList>();

                Goal.Add(new GList { Name = GNameinfo, Date = GDateinfo, Notes = GNoteinfo, Pri = GPri });
                Gcurrent.ItemsSource = Goal;


            //No goal name error
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
            
        }
    }
}
