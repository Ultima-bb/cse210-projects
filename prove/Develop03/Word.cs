 private class Word
    {
        public string _text { get; private set; }
        public bool _hideThis { get; set; }

        public Word(string text)
        {
            _text = text;
            _hideThis = false;
        }
    }