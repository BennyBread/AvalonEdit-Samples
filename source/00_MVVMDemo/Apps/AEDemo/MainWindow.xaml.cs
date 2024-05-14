using System;
using ICSharpCode.AvalonEdit;

namespace AEDemo
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Loaded -= MainWindow_Loaded;
        }

        private void AvEditor_OnDocumentChanged(object sender, EventArgs e)
        {
            // is not called after open document
            if (sender is TextEditor editor)
            {
                var txt = editor.Text;
                var txtAreaTxt = editor.TextArea.TextView.Document?.Text;
            }
        }

        private void AvEditor_OnTextChanged(object sender, EventArgs e)
        {
            // is not called after open document

            if (sender is TextEditor editor)
            {
                var txt = editor.Text;
                var txtAreaTxt = editor.TextArea.TextView.Document?.Text;
            }
        }
    }
}
