using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AAHBECICOENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AAHBECICOENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQUhCRUNJQ09FTi5wcm90bxoRTEJETUZGRE5GRFAucHJvdG8iagoLQUFI" + "QkVDSUNPRU4SIQoLREpES0FJRElBQUQYASABKA4yDC5MQkRNRkZETkZEUBIO" + "CgZtYXBfaWQYBiABKA0SEwoLRUlJQUdBQkFGRUMYCiABKA0SEwoLQ1BGQ0RP" + "Q0pGQkYYDyABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { LBDMFFDNFDPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AAHBECICOEN), AAHBECICOEN.Parser, new string[4] { "DJDKAIDIAAD", "MapId", "EIIAGABAFEC", "CPFCDOCJFBF" }, null, null, null, null)
		}));
	}
}
