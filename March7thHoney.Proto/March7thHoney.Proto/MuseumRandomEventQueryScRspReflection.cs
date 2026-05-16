using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MuseumRandomEventQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MuseumRandomEventQueryScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNldW1SYW5kb21FdmVudFF1ZXJ5U2NSc3AucHJvdG8aEUtOTk9EQVBB" + "S0pBLnByb3RvIlEKG011c2V1bVJhbmRvbUV2ZW50UXVlcnlTY1JzcBIhCgtM" + "Sk1GR0RGQkxDSxgEIAEoCzIMLktOTk9EQVBBS0pBEg8KB3JldGNvZGUYCCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KNNODAPAKJAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MuseumRandomEventQueryScRsp), MuseumRandomEventQueryScRsp.Parser, new string[2] { "LJMFGDFBLCK", "Retcode" }, null, null, null, null)
		}));
	}
}
