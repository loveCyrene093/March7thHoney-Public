namespace March7thHoney.Util.Security;

public class MT19937
{
	private const int N = 312;

	private const int M = 156;

	private const ulong MATRIX_A = 13043109905998158313uL;

	private const ulong UPPER_MASK = 18446744071562067968uL;

	private const ulong LOWER_MASK = 2147483647uL;

	private readonly ulong[] mt = new ulong[312];

	private int mti = 313;

	public MT19937()
	{
		Seed(5489uL);
	}

	public MT19937(ulong seed)
	{
		Seed(seed);
	}

	public void Seed(ulong seed)
	{
		mt[0] = seed;
		for (mti = 1; mti < 312; mti++)
		{
			mt[mti] = 6364136223846793005L * (mt[mti - 1] ^ (mt[mti - 1] >> 62)) + (ulong)mti;
		}
	}

	public ulong NextUInt64()
	{
		ulong[] array = new ulong[2] { 0uL, 13043109905998158313uL };
		ulong num;
		if (mti >= 312)
		{
			if (mti == 313)
			{
				Seed(5489uL);
			}
			int i;
			for (i = 0; i < 156; i++)
			{
				num = (mt[i] & 0xFFFFFFFF80000000uL) | (mt[i + 1] & 0x7FFFFFFF);
				mt[i] = mt[i + 156] ^ (num >> 1) ^ array[num & 1];
			}
			for (; i < 311; i++)
			{
				num = (mt[i] & 0xFFFFFFFF80000000uL) | (mt[i + 1] & 0x7FFFFFFF);
				mt[i] = mt[i + -156] ^ (num >> 1) ^ array[num & 1];
			}
			num = (mt[311] & 0xFFFFFFFF80000000uL) | (mt[0] & 0x7FFFFFFF);
			mt[311] = mt[155] ^ (num >> 1) ^ array[num & 1];
			mti = 0;
		}
		num = mt[mti++];
		num ^= (num >> 29) & 0x5555555555555555L;
		num ^= (num << 17) & 0x71D67FFFEDA60000L;
		num ^= (num << 37) & 0xFFF7EEE000000000uL;
		return num ^ (num >> 43);
	}

	public long NextInt63()
	{
		return (long)(NextUInt64() & 0x7FFFFFFFFFFFFFFFL);
	}
}
