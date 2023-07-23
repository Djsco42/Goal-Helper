namespace Goal_Helper
{
    internal class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            Thread thread = new Thread(() =>
            {
                var app = new System.Windows.Application();
                var mainWindow = new GoalWin.MainWindow(); // Replace "YourWpfApp" with the namespace of your WPF app
                app.Run(mainWindow);
               
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            

        }
    }
}