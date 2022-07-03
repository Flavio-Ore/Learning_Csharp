using System.Net.Mime;
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

namespace aWPFICs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //^Windows Presentation Fundation
        
        //^Sucesor de Windows Forms
        //Wpf es una API (application programming interface) perteneciente al framework .NET para crear interfaces de usuario (aplicaciones gráficas de escritorio) bajo Windows
        //Con WPF podemos crear interfaces gráficas de escritorio bajo Windows
        //Con Visual Studio IDE se podrá crear interfaces de usuario de forma visual generando código XAML por detrás
        public MainWindow()
        {
            InitializeComponent();

            Grid firstGrid = new();

            Button aBtn = new();

            WrapPanel wrapPanel = new();

            TextBlock txt1 = new();

            TextBlock txt2 = new();

            TextBlock txt3 = new();

            this.Content = firstGrid;

            txt1.Text = "Hey";

            txt2.Text = "Click";

            txt3.Text = "Envialo";

            aBtn.Background = Brushes.DeepPink;

            aBtn.Width = 180;

            aBtn.Height = 50;

            wrapPanel.Children.Add(txt1);
            
            wrapPanel.Children.Add(txt2);

            wrapPanel.Children.Add(txt3);

            aBtn.Content = wrapPanel;

            firstGrid.Children.Add(aBtn);
        }
    }
}
