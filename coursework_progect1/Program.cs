namespace coursework_progect1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var loginForm = new Регистриция();
            var testForm = new Тест();

            loginForm.ShowDialog();

            if (loginForm.IsAuthorized)
            {
                Application.Run(new Тест());
            }

        }
    }
}