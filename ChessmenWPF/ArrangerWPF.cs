using ChessmenCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ChessmenWPF
{
    class ArrangerWPF : Arranger
    {
        private Button btn;
        private string selectedPiece;

        public ArrangerWPF(Button btn, string selectedPiece)
        {
            this.btn = btn;
            this.selectedPiece = selectedPiece;
        }

        public override void PlacePiece(int x, int y)
        {
            btn.Content = selectedPiece;
        }
    }
}
