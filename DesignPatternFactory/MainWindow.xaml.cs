using BusinessLayer;
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

namespace DesignPatternFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Configuration configuration;
        public MainWindow()
        {
            configuration = new Configuration();
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            cbPatternNames.ItemsSource = configuration.PatternNames;
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string pattern = cbPatternNames.SelectedValue.ToString();
            // Create object using builder pattern to send it to Command
            // Create a Command to generate Pattern selected - using Command Pattern
            // After create the pattern, ask to user where want to save the files
        }
    }
}
