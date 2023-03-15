using System;
[Flags]
enum Perks
{
    None=0,
    WaterBreathing = 1 << 0,
    AutoHeal = 1 << 1,
    Stealth = 1 << 2,
    DoubleJump = 1 << 3
};