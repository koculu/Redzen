﻿
namespace Redzen.Random.Tests
{
    public class Xoshiro256StarStarRandomTests : RandomSourceTests
    {
        protected override IRandomSource CreateRandomSource()
        {
            return new Xoshiro256StarStarRandom(1);
        }
    }
}
