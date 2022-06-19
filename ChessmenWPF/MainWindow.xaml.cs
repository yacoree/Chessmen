using ChessmenCore;
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
using System.Drawing;

namespace ChessmenWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Piece currentPiece;
        string selectedPiece;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckerboardCell_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string content = "" + btn.Content;
            int x = Grid.GetColumn(btn);
            int y = Grid.GetRow(btn);
            if (currentPiece != null)
            {
                if (currentPiece.isRightTurn(x, y))
                {
                    (int x0, int y0) = currentPiece.Parse();
                    //Grid.SetColumn(btn, y0);
                    //Grid.SetRow(btn, x0);
                    //var i = GridView.GetColumnCollection(btn);
                    //MessageBox.Show("" + i);
                    return;
                }
                //return;
            }
            if (content != "")
            {
                currentPiece = Piece.checkerboard[x, y];
            }
            if (content == "" && selectedPiece != "")
            {
                Piece currentPiece = PieceMaker.Make(selectedPiece, x, y);
                currentPiece.arranger = new ArrangerWPF();
                btn.Content += selectedPiece;
                MessageBox.Show(selectedPiece);
            }
            //currentPiece = PieceMaker.Make(selectedPiece, 1, 1);
        }

        private void SelectedPiece_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            selectedPiece = "" + btn.Content;
            MessageBox.Show(selectedPiece);
        }
    }
}
