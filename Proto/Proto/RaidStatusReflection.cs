using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RaidStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RaidStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChBSYWlkU3RhdHVzLnByb3RvKmkKClJhaWRTdGF0dXMSFAoQUkFJRF9TVEFU" + "VVNfTk9ORRAAEhUKEVJBSURfU1RBVFVTX0RPSU5HEAESFgoSUkFJRF9TVEFU" + "VVNfRklOSVNIEAISFgoSUkFJRF9TVEFUVVNfRkFJTEVEEANCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RaidStatus) }, null, null));
	}
}
