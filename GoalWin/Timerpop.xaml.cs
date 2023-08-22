using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.IO;
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
using System.Windows.Threading;
using System.Reflection;
using static GoalWin.Win;
using GoalWin;
using System.Timers;

namespace Timer_pop_up
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Timerpop : Window
    {
        DispatcherTimer Sess;
        TimeSpan tsess;
        DispatcherTimer Break;
        TimeSpan tbreak;
        bool isfirst = true;
        bool issturn=true;
        public int TSess { get; set; }
        public int TBreak { get; set; }

        public Timerpop()
        {
            InitializeComponent();


            Sess = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (issturn)
                {
                    if (isfirst == true)
                    {
                        tbreak = TimeSpan.FromSeconds(TBreak); T2.Text = tbreak.ToString("c");
                        isfirst = false;
                    }
                    T1.Text = tsess.ToString("c");
                    if (tsess == TimeSpan.Zero) 
                    { 
                        Sess.Stop(); 
                        Break.Start(); 
                        isfirst = true; 
                        issturn = false;
                        tbreak = tbreak.Add(TimeSpan.FromSeconds(-1));
                    }
                    tsess = tsess.Add(TimeSpan.FromSeconds(-1));
                
                }

            }, Application.Current.Dispatcher);

            Break = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (issturn==false)
                {
                    if (isfirst == true)
                    {
                        tsess = TimeSpan.FromSeconds(TSess); T1.Text = tsess.ToString("c");
                        isfirst = false;
                    }
                    T2.Text = tbreak.ToString("c");
                    if (tbreak == TimeSpan.Zero) 
                    { 
                        Break.Stop(); 
                        Sess.Start(); 
                        isfirst = true; 
                        issturn = true;
                        tsess = tsess.Add(TimeSpan.FromSeconds(-1));
                    }
                    tbreak = tbreak.Add(TimeSpan.FromSeconds(-1));
                }
            }, Application.Current.Dispatcher);

            Sess.Start();


        }
        private void tim_Loaded(object sender, RoutedEventArgs e)
        {
            TSess = TSess * 60;
            TBreak = TBreak * 60;

            tsess = TimeSpan.FromSeconds(TSess);
        }

    }
}
