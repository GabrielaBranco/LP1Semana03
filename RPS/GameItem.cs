using System;

namespace GameItem
{
    [Flags]
    public enum Items
    {
        Rock = 1 << 0,
        Paper = 1 << 1, 
        Scissors = 1 << 2
    }
}