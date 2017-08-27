using BusinessLayer;
using BusinessLayer.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            // initialize combox with patterns
            cbPatternNames.ItemsSource = configuration.PatternNames.OrderBy(c => c);
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            configuration.PatternName = cbPatternNames.SelectedValue.ToString();

            IPatternFactory factory = new PatternFactory(); //LoadFactory(configuration.FullName);
            IPattern patternCreated = factory.CreatePattern(configuration.FullName);
            if (patternCreated != null)
            {
                patternCreated.GeneratePattern();
                MessageBox.Show(this, "Pattern files were sucessfully generated!!", "Success Message", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(this, "The pattern selected was not found!", "Error Message", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
