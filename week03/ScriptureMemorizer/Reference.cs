using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _section;
    private int _endSection;

    public string GetDisplayText()
    {
        _book = "Doctrine and Covenants";
        _chapter = 78;
        _section = 21;
        _endSection = 22;
        string verse = $"{_book} {_chapter}:{_section}-{_endSection}";
        return verse;
    }


}