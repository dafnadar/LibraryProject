using System;

namespace BookLib
{
    [Flags]
    public enum JournalSubject
    {
        LifeStyle = 1,
        Children = 2,
        Music = 4,
        Business = 8,
        Science = 16,
        General = 32,
    }
}
