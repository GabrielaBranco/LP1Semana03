using System;

namespace GameStatus
{
    [Flags]
    public enum Status
    {
        Draw = 0 ,
        Player1Wins = 1, 
        Player2Wins = 2
    }
}