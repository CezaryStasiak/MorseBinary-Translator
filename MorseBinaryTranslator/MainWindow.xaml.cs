using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using MorseBinaryTranslatorLib;

namespace MorseBinaryTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MorseBinaryCoder coder;
        public MorseBinaryDecoder decoder;
        public MainWindow()
        {
            InitializeComponent();
            coder = new MorseBinaryCoder();
            decoder = new MorseBinaryDecoder();
        }
        

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = new TextRange(InputTextBox.Document.ContentStart, InputTextBox.Document.ContentEnd).Text;
            text = text.Remove(text.Count() - 2);
            OutputTextBox.Document.Blocks.Clear();
            OutputTextBox.AppendText(coder.Translate(text));
        }

        private void InputTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = new TextRange(InputTextBox1.Document.ContentStart, InputTextBox1.Document.ContentEnd).Text;
            text = text.Remove(text.Count() - 2);
            OutputTextBox1.Document.Blocks.Clear();
            OutputTextBox1.AppendText(decoder.Translate(text));
        }
    }
}
