using System;

namespace Something
{
    class Component
    {
        protected IScreenWriter ScreenWriter;
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public Component(int x, int y, int width, int height, IScreenWriter screenWriter)
        {
            ScreenWriter = screenWriter;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public virtual void Show()
        {
            var fullLine = string.Empty.PadLeft(Width, '#');
            ScreenWriter.Write(X, Y, fullLine);

            for (var y = Y; y < Y + Height - 1; y++)
            {
                ScreenWriter.Write(X, y, "#");
                ScreenWriter.Write(X + Width, y, "#");
            }
            ScreenWriter.Write(X, Y + Height - 1, fullLine);
        }
    }
}
