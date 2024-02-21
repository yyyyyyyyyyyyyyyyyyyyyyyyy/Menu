using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;
using System.IO;

namespace Menu
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, New_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, Open_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, Save_Executed));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Close, Close_Executed));
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            mojTekst.Text = string.Empty;
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                mojTekst.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, mojTekst.Text);
            }
        }

        private void Close_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void Zawijanie_Click(object sender, RoutedEventArgs e)
        {
            if (menuZawijanie.IsChecked)
            {
                mojTekst.TextWrapping = TextWrapping.Wrap;
            }
            else
            {
                mojTekst.TextWrapping = TextWrapping.NoWrap;
            }
        }

        private void Powiekszanie_Click(object sender, RoutedEventArgs e)
        {
            mojTekst.FontSize += 5;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
