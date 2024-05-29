public class Scripture
{
    private string Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Memoryaid()
    {
        int wecountyoudont = 0;
        Random random = new Random();
        while (wecountyoudont < Words.Count)
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
        int index = random.Next(Words.Count);
        if (!Words[index].hideThis)
        {
            Words[index].hideThis = true;
            Console.WriteLine($"Hidden word: {Words[index].Text}");
        }
    }

    private void ScriptureMastery()
    {
        Console.WriteLine($"Scripture: {Reference}");
        foreach (var word in Words)
        {
            if (word.hideThis)
                Console.Write("[-----] ");
            else
                Console.Write($"{word.Text} ");
        }
    }
}