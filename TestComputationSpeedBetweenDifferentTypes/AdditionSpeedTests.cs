using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace TestComputationSpeedBetweenDifferentTypes
{
    public class AdditionSpeedTests : SpeedTestValues
    {
        [Benchmark(Description = "signed byte addition")]
        public void TestSignedByteAdditon()
        {
            for (int x = 0; x < N/2; x++)
            {
                int z = sbytes[x] + sbytes[x + 1];
            }
        }

        [Benchmark(Description = "byte addition")]
        public void TestByteAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = bytes[x] + bytes[x + 1];
            }
        }

        [Benchmark(Description = "short integer addition")]
        public void TestShortIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = shorts[x] + shorts[x + 1];
            }
        }

        [Benchmark(Description = "unsigned short integer addition")]
        public void TestUnsignedShortIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ushorts[x] + ushorts[x + 1];
            }
        }

        [Benchmark(Description = "integer addition")]
        public void TestIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ints[x] + ints[x + 1];
            }
        }

        [Benchmark(Description = "unsigned integer addition")]
        public void TestUnsignedIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                uint z = uints[x] + uints[x + 1];
            }
        }

        [Benchmark(Description = "long integer addition")]
        public void TestLongIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                long z = longs[x] + longs[x + 1];
            }
        }

        [Benchmark(Description = "unsigned long integer addition")]
        public void TestUnsignedLongIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                ulong z = ulongs[x] + ulongs[x + 1];
            }
        }

        [Benchmark(Description = "float addition")]
        public void TestFloatAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                float z = floats[x] + floats[x + 1];
            }
        }

        [Benchmark(Description = "double addition")]
        public void TestDoubleAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                double z = doubles[x] + doubles[x + 1];
            }
        }

        [Benchmark(Description = "decimal addition")]
        public void TestDecimalAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                decimal z = decimals[x] + decimals[x + 1];
            }
        }
    }
}