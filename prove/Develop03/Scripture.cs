    private class Scripture
    {
        private string _reference { get; set; }
        private List<Word> _words { get; set; }

        public Scripture(string reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

        public void Memoryaid()
        {
            int wecountyoudont = 0;
            Random random = new Random();
            while (wecountyoudont < _words.Count)
            {
                Console.Clear();
                Hiddenword(random);
                ScriptureMastery();
                Console.WriteLine("\nPress Enter to continue or type 'done' to exit.");
                string input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;
            }
        }

        private void Hiddenword(Random random)
        {
            int index = random.Next(_words.Count);
            if (!_words[index]._hideThis)
            {
                _words[index]._hideThis = true;
                Console.WriteLine($"Hidden word: {_words[index]._text}");
            }
        }

        private void ScriptureMastery()
        {
            Console.WriteLine($"Scripture: {_reference}");
            foreach (var word in _words)
            {
                if (word._hideThis)
                    Console.Write("[-----] ");
                else
                    Console.Write($"{word._text} ");
            }
        }
    }