using System;

class Program
{
    static void Main(string[] args)
    {
        SetText setText = new SetText();
        Hide hide = new Hide();
        Replace replace = new Replace();

        hide.Split(setText.SetReference(), setText.SetScripture(), replace);

    }
}