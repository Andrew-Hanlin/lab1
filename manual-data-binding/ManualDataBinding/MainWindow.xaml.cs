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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Note note = new Note();
        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }
        public void OnNewNote(Object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;


        }
        public void OnClearNote(Object sender, RoutedEventArgs e)
        {
            note.Body = "";

        }
        public void OnMutateNote(Object sender, RoutedEventArgs e)
        {
            note.Title = "this title sucks";
            note.Body = "this is a terrible body";
        }
    }
}
