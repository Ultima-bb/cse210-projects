private class ScriptureReference
    {
        private string _book { get; private set; }
        private int _chapter { get; private set; }
        private int _start { get; private set; }
        private int _end { get; private set; }

        private ScriptureReference(string reference)
        {
            ParseReference(reference);
        }

        private void ParseReference(string reference)
        {
            string[] parts = reference.Split(':');
            _book = parts[0];
            string[] chapterVerse = parts[1].Split('-');
            _chapter = int.Parse(chapterVerse[0]);
            _start = int.Parse(chapterVerse[1]);
            if (chapterVerse.Length == 1)
                _end = int.Parse(chapterVerse[1]);
        }
    }
}