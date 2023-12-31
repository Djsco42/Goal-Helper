﻿//Oh ya MF, Main Ui is done! 7/20/23 10:30AM
// GOOD LUCK for the 100th time Anya is amazing!! 12/2/23 6:30-7:30PM
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
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO.Pipes;
using System.Diagnostics;
using Timer_pop_up;

namespace GoalWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class Win : Window
    {
        string GDateinfo;
        string GNameinfo;
        string GNoteinfo;
        string GPri;
        string GSessioninfo;
        string GBreakinfo;
        string GfilePath = "Stored Goals.txt";
        string[] targetWords = { "Name of Goal:", "Date:", "Notes:", "Priority:", "Session:", "Break:" };
        string content = string.Empty;
        ObservableCollection<GList> Goal = new ObservableCollection<GList>();
        private DateTime lastWriteTime;
        bool Iscl = false;

        private String FSess;
        private String FBreak;








        public Win()
        {
            InitializeComponent();
            Gref();
            //FileChanged();

        }

        public class GList
        {
            public string Name { get; set; }
            public string Date { get; set; }
            public string Notes { get; set; }
            public string Pri { get; set; }
            public string Session { get; set; }
            public string Break { get; set; }
        }
        private void Gsum_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Gname.Text) && !string.IsNullOrEmpty(Gsession.Text) && !string.IsNullOrEmpty(Gbreak.Text))
            {
                

                Iscl = true;

                string numericValue = Gname.Text;
                GInputState.Text = "Goal Summited";
                GInputState.Foreground = new SolidColorBrush(Colors.Green);


                GDateinfo = GDate.Text;
                GNameinfo = Gname.Text;
                GNoteinfo = Gnote.Text;
                GPri = Gpry.Text;
                GSessioninfo = Gsession.Text;
                GBreakinfo = Gbreak.Text;


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
                Gsession.Text = "";
                Gbreak.Text = "";

                //.txt read/write
                using (StreamWriter sw =new StreamWriter(GfilePath, true))
                {
                    //sw.WriteLine();
                    sw.WriteLine("Name of Goal: " + GNameinfo + " Date: " + GDateinfo + " Notes: " + GNoteinfo + " Priority: " + GPri +" Session:" +GSessioninfo+" Break:"+GBreakinfo);
                }
                Gref();
                Listtxt();
                //FileChanged();
                //No goal name error
            }
            else
            {
                GInputState.Foreground = new SolidColorBrush(Colors.Red);
                GInputState.Text = "Please Fill Out All Required Fields";
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

        private void Gdel_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = Gcurrent.SelectedItems.Cast<GList>().ToList();

            // Create a list to store the items to be removed from the Goal list
            List<GList> itemsToRemove = new List<GList>();

            foreach (var selectedItem in selectedItems)
            {
                itemsToRemove.Add(selectedItem);
            }

            // Remove the items from the Goal list
            foreach (var item in itemsToRemove)
            {
                Goal.Remove(item);
            }

            // Refresh the ListView
            Gcurrent.ItemsSource = null;
            Gcurrent.ItemsSource = Goal.OrderBy(item => item.Pri);
            Listtxt();
            Gref();
            //FileChanged();
        }

        private void Gref()
        {
            Gcurrent.ItemsSource = null;
            Goal.Clear();
            //sets Goal list
            string[] lines = File.ReadAllLines(GfilePath);

                // Iterate over each line
                foreach (string line in lines)
                {
                    string[] words = Regex.Split(line, @"\b(?:Name of Goal:|Date:|Notes:|Priority:|Session:|Break:)\s*");

                    if (words.Length >= 7)
                    {
                        Goal.Add(new GList
                        {
                            Name = "Name of Goal: " + words[1].Trim(),
                            Date = "Date: " + words[2].Trim(),
                            Notes = "Notes: " + words[3].Trim(),
                            Pri = "Priority: " + words[4].Trim(),
                            Session = "Session: " + words[5].Trim(),
                            Break = "Break: " + words[6].Trim()
                        });

                    }
                }
            Goal = new ObservableCollection<GList>(Goal.OrderBy(item => item.Pri));

            Gcurrent.ItemsSource = Goal;

            if (Goal.Count > 0)
            {
                GList firstItem = Goal.FirstOrDefault(); 
                FSess = ExtractTimePortion(firstItem.Session);
                FBreak = ExtractTimePortion(firstItem.Break);
            }
            else
            {
                FSess = null;
                FBreak = null;
            }

        }

        private string ExtractTimePortion(string input)
        {
            // Assuming the input format is like "Session: 09:00 AM"
            string[] parts = input.Split(' ');
            if (parts.Length >= 2)
            {
                return parts[1]; // Return the time portion
            }
            return string.Empty;
        }

        /*private void FileChanged()
        {
            DateTime currentWriteTime = File.GetLastWriteTime(GfilePath);
            if (currentWriteTime != lastWriteTime)
            {
                //changed
                lastWriteTime = currentWriteTime;
                using StreamReader sr = new StreamReader(GfilePath);
                {
                    content = sr.ReadToEnd();
                    Console.Clear();
                    Console.WriteLine(content);
                }
                
            }
            // not been changed
        }*/

        private void Listtxt()
        {
            // Open or create the text file for writing
            using (StreamWriter writer = new StreamWriter(GfilePath))
            {
                foreach (var item in Gcurrent.Items)
                {
                    // Assuming each item in the ListView is a GList object
                    if (item is GList listItem)
                    {
                        // Concatenate the data from the GList properties into a single line
                        string line = $"{listItem.Name} {listItem.Date} {listItem.Notes} {listItem.Pri} {listItem.Session} {listItem.Break}";

                        // Write the line to the text file
                        writer.WriteLine(line);
                    }
                }
            }
        }

        private void Win_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                using(StreamWriter writer = new StreamWriter(GfilePath))
                {
                    writer.WriteLine();
                }
            }
            if (e.Key == Key.Q) 
            {
                Listtxt();
            }
            if(e.Key == Key.W)
            {
                Gref();
            }
            if( e.Key == Key.Z)
            {
                Process.GetCurrentProcess().CloseMainWindow();
            }
            if(e.Key== Key.S)
            {

            }
        }

        private void Gstart_Click(object sender, RoutedEventArgs e)
        {
            Gref();
            if (FSess == null | FBreak == null)
            {
                Gshow.Height = 530;
                Gpoperror.Foreground = new SolidColorBrush(Colors.Red);
                Gpoperror.Text = "Please Add A Goal Before Starting One";
            }
            else
            {
            Timerpop pop = new Timerpop();
            pop.TSess = int.Parse(FSess);
            pop.TBreak = int.Parse(FBreak);
            pop.Show();
            pop.Topmost = true;
            }

        }

        private void Gshow_MouseLeave(object sender, MouseEventArgs e)
        {
            Gshow.Height = 470;
            Gpoperror.Text = "";
        }
    }

}



