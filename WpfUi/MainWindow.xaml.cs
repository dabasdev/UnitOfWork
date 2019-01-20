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
using DAL.Model;
using Services;

namespace WpfUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ActorService _actorService;
        public MainWindow()
        {
            InitializeComponent();
            _actorService = new ActorService();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            using (var ctx = _actorService.GetRepository<Actor>())
            {
                if(!(GridItems.DataContext is Actor item)) return;

                await ctx.AddAsync(item);

                await _actorService.SaveAsync();

                MessageBox.Show("Done");
            }
        }
    }
}
