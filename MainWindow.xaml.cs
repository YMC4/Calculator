using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public float? Total { get; set; }
        public float? XValue { get; set; }
        public string? Operator { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? buttonPressed = sender as Button;
            if (buttonPressed != null) 
            {
                float tempFloat;
                if (float.TryParse((string)buttonPressed.Content, out tempFloat))
                {
                    if (Operator == null)
                    {
                        XValue += (float?)(XValue * 10 + tempFloat);
                    }
                    else
                    {
                        switch (Operator) 
                        {
                            //mettre les symboles non hardcoded
                            case "+": Total += XValue;break;
                            case "-": Total -= XValue; break;
                            case "*": Total *= XValue; break;
                            case "/": Total /= XValue; break;
                            case "=":Total = 0;break; // need to output on the textblock

                        }




                        

                    }
                }
                else 
                {
                    switch ((string)buttonPressed.Content) 
                    {
                        case:


                    }



                
                }
                    















               
                
            };
        }
    }
}