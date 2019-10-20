using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace TestComputationSpeedBetweenDifferentTypes
{
    public class AdditionSpeedTests : SpeedTestValues
    {
        [Benchmark(Description = "signed byte addition")]
        public void SignedByteAdditon()
        {
            for (int x = 0; x < N/2; x++)
            {
                int z = sbytes[x] + sbytes[x + 1];
            }
        }

        [Benchmark(Description = "byte addition")]
        public void ByteAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = bytes[x] + bytes[x + 1];
            }
        }

        [Benchmark(Description = "short integer addition")]
        public void ShortIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = shorts[x] + shorts[x + 1];
            }
        }

        [Benchmark(Description = "unsigned short integer addition")]
        public void UnsignedShortIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ushorts[x] + ushorts[x + 1];
            }
        }

        [Benchmark(Description = "integer addition")]
        public void IntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                int z = ints[x] + ints[x + 1];
            }
        }

        [Benchmark(Description = "unsigned integer addition")]
        public void UnsignedIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                uint z = uints[x] + uints[x + 1];
            }
        }

        [Benchmark(Description = "long integer addition")]
        public void LongIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                long z = longs[x] + longs[x + 1];
            }
        }

        [Benchmark(Description = "unsigned long integer addition")]
        public void UnsignedLongIntegerAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                ulong z = ulongs[x] + ulongs[x + 1];
            }
        }

        [Benchmark(Description = "float addition")]
        public void FloatAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                float z = floats[x] + floats[x + 1];
            }
        }

        [Benchmark(Description = "double addition")]
        public void DoubleAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                double z = doubles[x] + doubles[x + 1];
            }
        }

        [Benchmark(Description = "decimal addition")]
        public void DecimalAdditon()
        {
            for (int x = 0; x < N / 2; x++)
            {
                decimal z = decimals[x] + decimals[x + 1];
            }
        }
    }
}