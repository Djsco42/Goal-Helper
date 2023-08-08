namespace Goal_Helper
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
                var app = new System.Windows.Application();
                var mainWindow = new GoalWin.Win();
                app.Run(mainWindow);
        }
    }
}