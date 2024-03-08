using System;

namespace PlayerPowers
{
    [Flags]
    public enum Powers
    {
        Fly = 1 << 0,
        SuperStrength = 1 << 1, 
        XRayVision = 1 << 2
    }
}