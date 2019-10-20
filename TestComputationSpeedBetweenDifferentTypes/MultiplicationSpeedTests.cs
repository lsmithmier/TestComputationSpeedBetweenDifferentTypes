using BenchmarkDotNet.Attributes;

namespace TestComputationSpeedBetweenDifferentTypes
{
    public class MultiplicationSpeedTests : SpeedTestValues
    {
        [Benchmark(Description = "signed byte multiplication")]
        public void SignedByteMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = sbytes[x] * 3;
            }
        }

        [Benchmark(Description = "byte multiplication")]
        public void ByteMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = bytes[x] * 3;
            }
        }

        [Benchmark(Description = "short integer multiplication")]
        public void ShortIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = shorts[x] * 3;
            }
        }

        [Benchmark(Description = "unsigned short integer multiplication")]
        public void UnsignedShortIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ushorts[x] * 3;
            }
        }

        [Benchmark(Description = "integer multiplication")]
        public void IntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ints[x] * 3;
            }
        }

        [Benchmark(Description = "unsigned integer multiplication")]
        public void UnsignedIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                uint z = uints[x] * 3U;
            }
        }

        [Benchmark(Description = "long integer multiplication")]
        public void LongIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                long z = longs[x] * 3L;
            }
        }

        [Benchmark(Description = "unsigned long integer multiplication")]
        public void UnsignedLongIntegerMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                ulong z = ulongs[x] * 3UL;
            }
        }

        [Benchmark(Description = "float multiplication")]
        public void FloatMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                float z = floats[x] * 3F;
            }
        }

        [Benchmark(Description = "double multiplication")]
        public void DoubleMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                double z = doubles[x] * 3D;
            }
        }

        [Benchmark(Description = "decimal multiplication")]
        public void DecimalMultiplication()
        {
            for (int x = 0; x < N / 2; x++)
            {
                decimal z = decimals[x] * 3M;
            }
        }
    }
}