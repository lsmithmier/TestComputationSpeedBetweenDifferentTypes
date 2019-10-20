using System;

namespace TestComputationSpeedBetweenDifferentTypes
{
    public class SpeedTestValues
    {
        internal const int N = 100;
        internal readonly sbyte[] sbytes;
        internal readonly byte[] bytes;
        internal readonly short[] shorts;
        internal readonly ushort[] ushorts;
        internal readonly int[] ints;
        internal readonly uint[] uints;
        internal readonly long[] longs;
        internal readonly ulong[] ulongs;
        internal readonly float[] floats;
        internal readonly double[] doubles;
        internal readonly decimal[] decimals;

        public SpeedTestValues()
        {
            var rand = new Random();
            sbytes = new sbyte[N];
            for (int i = 0; i < N; i++)
            {
                sbytes[i] = (sbyte)rand.Next((sbyte.MaxValue - sbyte.MinValue - 2) / 3);
            }
            bytes = new byte[N];
            for (int i = 0; i < N; i++)
            {
                bytes[i] = (byte)rand.Next((byte.MaxValue - byte.MinValue - 2) / 3);
            }
            shorts = new short[N];
            for (int i = 0; i < N; i++)
            {
                shorts[i] = (short)rand.Next((short.MaxValue - short.MinValue - 2) / 3);
            }
            ushorts = new ushort[N];
            for (int i = 0; i < N; i++)
            {
                ushorts[i] = (ushort)rand.Next((ushort.MaxValue - ushort.MinValue - 2) / 3);
            }
            ints = new int[N];
            for (int i = 0; i < N; i++)
            {
                ints[i] = (int)rand.Next((int.MaxValue - 2) / 3);
            }
            uints = new uint[N];
            for (int i = 0; i < N; i++)
            {
                uints[i] = (uint)rand.Next((int.MaxValue - 2) / 3);
            }
            longs = new long[N];
            for (int i = 0; i < N; i++)
            {
                longs[i] = (long)rand.Next((int.MaxValue - 2) / 3);
            }
            ulongs = new ulong[N];
            for (int i = 0; i < N; i++)
            {
                ulongs[i] = (ulong)rand.Next((int.MaxValue - 2) / 3);
            }
            floats = new float[N];
            for (int i = 0; i < N; i++)
            {
                floats[i] = (float)rand.Next((int.MaxValue - 2) / 3);
            }
            doubles = new double[N];
            for (int i = 0; i < N; i++)
            {
                doubles[i] = (double)rand.Next((int.MaxValue - 2) / 3);
            }
            decimals = new decimal[N];
            for (int i = 0; i < N; i++)
            {
                decimals[i] = (decimal)rand.Next((int.MaxValue - 2) / 3);
            }
        }
    }
}