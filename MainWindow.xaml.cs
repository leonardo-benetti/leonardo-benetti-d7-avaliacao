using leonardo_benetti_d7_avaliacao.Model;
using System.Linq;
using System.Windows;

namespace leonardo_benetti_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SQLiteContext context;

        User LoginAttempt = new();

        public MainWindow(SQLiteContext context)
        {
            this.context = context;
            InitializeComponent();
            MainGrid.DataContext = LoginAttempt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User? db_user = context.Users.Where(user => 
            user.UserName == LoginAttempt.UserName && user.Password == LoginAttempt.Password
            ).FirstOrDefault();

            if (db_user != null) // login success
            {
                var result = MessageBox.Show("Usuário autenticado!");
            }
            else
            {
                var result = MessageBox.Show("Credenciais inválidas!");
            }
            LoginAttempt = new();
            MainGrid.DataContext = LoginAttempt;
        }
    }
}
