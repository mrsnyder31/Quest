using System;
namespace Quest
{
    public class Prize
    {
        private string _text;
        Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer quester)
        {
            if (quester.Awesomeness > 0)
            {
                for (int i = 0; i < quester.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("You are not awesome enough for even a participation trophy.");
            }
        }

    }
}