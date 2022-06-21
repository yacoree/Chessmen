﻿using ChessmenCore;
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
        Button selectedButton;
        string selectedPiece = "";
        int selectedColor;

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
                try
                {
                    currentPiece.arranger = new ArrangerWPF(btn, selectedPiece);
                    currentPiece.Turn(x, y);
                    selectedButton.Content = "";
                    //можно убрать, но пусть пока так
                    selectedPiece = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                selectedButton = null;
                currentPiece = null;
                return;
            }
            if (content != "")
            {
                currentPiece = Piece.checkerboard[x, y];
                selectedButton = btn;
                selectedPiece = "" + btn.Content;
                
            }
            if (content == "" && selectedPiece != "")
            {
                Piece currentPiece = PieceMaker.Make(selectedPiece, x, y, selectedColor);
                btn.Content += selectedPiece;
                (int x3, int y3) = currentPiece.Parse();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (selectedButton != null)
            {
                string content = "" + selectedButton.Content;
                if (content != "")
                {
                    currentPiece.Delete();
                    selectedButton.Content = "";
                    selectedButton = null;
                    currentPiece = null;
                }
            }
        }

        private void SelectedPiece_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var color = btn.Background;
            if (color == Brushes.White) selectedColor = 0;
            else if (color == Brushes.Black) selectedColor = 1;
            selectedPiece = "" + btn.Content;
        }
    }
}
