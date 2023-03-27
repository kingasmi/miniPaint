using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

//Szablon elementu Pusta strona jest udokumentowany na stronie https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x415

namespace miniPaint
{
    /// <summary>
    /// Pusta strona, która może być używana samodzielnie lub do której można nawigować wewnątrz ramki.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Point punktPoczatkowy ;
        bool czyRysuje = false;
        Stack<UIElement> listaUndo = new Stack<UIElement>();
        Shape shape;
        Line linia;//kreskazostawiana
        UIElement usunPoprzednie;
        SolidColorBrush kolor = new SolidColorBrush(Windows.UI.Colors.Black);
        int rozmiar = 3;
        Rectangle rectangle = new Rectangle();
        public MainPage()
        {
            this.InitializeComponent();
            rdbProsta.IsChecked = true;
            sldGrubość.Minimum = 1;
            sldGrubość.Maximum = 50;
        }

        private void poleRysowania_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            punktPoczatkowy = e.GetCurrentPoint(poleRysowania).Position;
            czyRysuje = true;
        }

        private void RysujLinie(PointerRoutedEventArgs e)
        {
            if(rectangle.Fill == null)
            {
                kolor = new SolidColorBrush(Windows.UI.Colors.Black);
            }
            else
            {
                kolor = (SolidColorBrush)rectangle.Fill;
            }
            if (czyRysuje == true)
            {
                Point pktAktualny = e.GetCurrentPoint(poleRysowania).Position;
                
                Windows.UI.Xaml.Shapes.Line linia_rys = new Windows.UI.Xaml.Shapes.Line()
                {
                    X1 = pktAktualny.X,
                    Y1 = pktAktualny.Y,
                    Stroke = kolor,
                    X2 = punktPoczatkowy.X,
                    Y2 = punktPoczatkowy.Y,
                    StrokeThickness = sldGrubość.Value,
                    StrokeEndLineCap = PenLineCap.Round,
                    StrokeStartLineCap = PenLineCap.Round

                };

                if (this.rdbProsta.IsChecked == true)
                {
                    if (usunPoprzednie != null)
                    {
                        poleRysowania.Children.Remove(usunPoprzednie);
                    }
                    poleRysowania.Children.Add(linia_rys);
                    usunPoprzednie = linia_rys;
                    linia = linia_rys;

                }
                else if (this.rdbDowolna.IsChecked == true)
                {
                    poleRysowania.Children.Add(linia_rys);
                    punktPoczatkowy = pktAktualny;
                    listaUndo.Push(linia_rys);

                }
            }
        }

        private void poleRysowania_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            RysujLinie(e);
        }

        private void poleRysowania_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Windows.UI.Xaml.Shapes.Line kreska = new Windows.UI.Xaml.Shapes.Line();
            czyRysuje = false;
            usunPoprzednie = null;
            listaUndo.Push(linia);


        }

        private void spKolory_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            rectangle = (Rectangle)e.OriginalSource;
        }

        private void sldGrubość_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            rozmiar = System.Convert.ToInt32(sldGrubość.Value);
        }


        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (listaUndo.Count > 0)
            {
                Shape undo = (Shape)listaUndo.Pop();
                poleRysowania.Children.Remove(undo);
            }

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
           
                    Windows.UI.Xaml.Application.Current.Exit();
        }

        private void rdbProsta_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rdbDowolna_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
