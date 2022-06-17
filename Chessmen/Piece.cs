using System;

namespace Chessmen
{
    public abstract class Piece
    {
        protected int x;
        protected int y;
        public Piece(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Turn(int x1, int y1)
        {
            if (isRightTurn(x1, y1))
            {
                this.x = x1;
                this.y = y1;
                Console.WriteLine($"Новые координаты фигуры {x}:{y}");
            }
            else
            {
                Console.WriteLine("Ошибка, фигура не может так перемещаться");
            }
        }

        public virtual bool isRightTurn(int x1, int y1)
        {

            return false;
        }
    }
}
