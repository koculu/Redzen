﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Redzen.Numerics;
using System;

namespace Redzen.UnitTests
{
    [TestClass]
    public class DiscreteDistributionTests
    {
        // TODO: More tests required.

        [TestMethod]
        [TestCategory("DiscreteDistributionTests")]
        public void SampleUniformWithoutReplacement_SampleAllChoices()
        {
            const int size = 5;
            XorShiftRandom rng = new XorShiftRandom();

            // Sample all of the elements.
            int[] sampleArr = new int[size];
            DiscreteDistributionUtils.SampleUniformWithoutReplacement(size, sampleArr, rng);

            // Sort the samples.
            Array.Sort(sampleArr);

            // Confirm that all of the choices were selected.
            for(int i=0; i<size; i++) {
                Assert.AreEqual(i, sampleArr[i]);
            }
        }
    }
}
