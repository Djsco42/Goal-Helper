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

namespace Timer_pop_up
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Timerpop : Window
    {
        private DispatcherTimer mainTimer;
        private TimeSpan timer1Duration;
        private TimeSpan timer2Duration;
        private int currentState = 1;

        public int TSess { get; set; }
        public int TBreak { get; set; }

        public Timerpop()
        {
            InitializeComponent();
            mainTimer = new DispatcherTimer();
            mainTimer.Interval = TimeSpan.FromSeconds(1);
            mainTimer.Tick += MainTimer_Tick;




        }
        private void tim_Loaded(object sender, RoutedEventArgs e)
        {
            pepe.Text = TSess.ToString() + TBreak.ToString();
            
            timer2Duration = TimeSpan.FromMinutes(TBreak);
            timer2TextBlock.Text = $"Timer 2: {timer2Duration:mm\\:ss}";
            timer1Duration = TimeSpan.FromMinutes(TSess);
            timer1TextBlock.Text = $"Timer 1: {timer1Duration:mm\\:ss}";
        }

        private void StartTimers_Click(object sender, RoutedEventArgs e)
        {
            mainTimer.Start();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if (currentState == 1)
            {
                timer1Duration = timer1Duration.Subtract(TimeSpan.FromSeconds(1));
                timer1TextBlock.Text = $"Timer 1: {timer1Duration:mm\\:ss}";

                if (timer1Duration.TotalSeconds <= 0)
                {
                    timer1Duration = TimeSpan.FromMinutes(1);
                    timer1TextBlock.Text = $"Timer 1: {timer1Duration:mm\\:ss}";
                    currentState = 2;
                    timer2Duration = TimeSpan.FromMinutes(1);
                    timer2TextBlock.Text = $"Timer 2: {timer2Duration:mm\\:ss}";
                }
            }
            else if (currentState == 2)
            {
                timer2Duration = timer2Duration.Subtract(TimeSpan.FromSeconds(1));
                timer2TextBlock.Text = $"Timer 2: {timer2Duration:mm\\:ss}";

                if (timer2Duration.TotalSeconds <= 0)
                {
                    timer2Duration = TimeSpan.FromMinutes(1);
                    timer2TextBlock.Text = $"Timer 2: {timer2Duration:mm\\:ss}";
                    currentState = 1;
                    timer1Duration = TimeSpan.FromMinutes(1);
                    timer1TextBlock.Text = $"Timer 1: {timer1Duration:mm\\:ss}";
                }
            }
        }


    }
}
