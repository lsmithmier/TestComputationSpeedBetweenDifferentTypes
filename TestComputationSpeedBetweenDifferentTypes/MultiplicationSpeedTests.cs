using BenchmarkDotNet.Attributes;

namespace TestComputationSpeedBetweenDifferentTypes
{
    public class MultiplicationSpeedTests : SpeedTestValues
    {
        [Benchmark(Description = "signed byte multiplication")]
        public void TestSignedByteMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = sbytes[x] * 3;
            }
        }

        [Benchmark(Description = "byte multiplication")]
        public void TestByteMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = bytes[x] * 3;
            }
        }

        [Benchmark(Description = "short integer multiplication")]
        public void TestShortIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = shorts[x] * 3;
            }
        }

        [Benchmark(Description = "unsigned short integer multiplication")]
        public void TestUnsignedShortIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ushorts[x] * 3;
            }
        }

        [Benchmark(Description = "integer multiplication")]
        public void TestIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ints[x] * 3;
            }
        }

        [Benchmark(Description = "unsigned integer multiplication")]
        public void TestUnsignedIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                uint z = uints[x] * 3U;
            }
        }

        [Benchmark(Description = "long integer multiplication")]
        public void TestLongIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                long z = longs[x] * 3L;
            }
        }

        [Benchmark(Description = "unsigned long integer multiplication")]
        public void TestUnsignedLongIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                ulong z = ulongs[x] * 3UL;
            }
        }

        [Benchmark(Description = "float multiplication")]
        public void TestFloatMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                float z = floats[x] * 3F;
            }
        }

        [Benchmark(Description = "double multiplication")]
        public void TestDoubleMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                double z = doubles[x] * 3D;
            }
        }

        [Benchmark(Description = "decimal multiplication")]
        public void TestDecimalMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                decimal z = decimals[x] * 3M;
            }
        }
    }
}