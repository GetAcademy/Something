namespace Something
{
    class Label : Component
    {
        private string _text;

        public Label(int x, int y, string text, IScreenWriter screenWriter)
            : base(x, y, text.Length + 4, 3, screenWriter)
        {
            _text = text;
        }

        public override void Show()
        {
            ScreenWriter.Write(X + 2, Y + 1, _text);
            base.Show();
        }
    }
}
