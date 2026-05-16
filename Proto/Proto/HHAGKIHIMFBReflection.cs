using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHAGKIHIMFBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHAGKIHIMFBReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFISEFHS0lISU1GQi5wcm90bxoRSE5LTVBDUExJQkIucHJvdG8aEUtOR0xN";
		buffer[1] = "S0VKQkFCLnByb3RvGhFOT0pOTUFJQUNHQi5wcm90byLKAQoLSEhBR0tJSElN";
		buffer[2] = "RkISEwoLUEZES0tGUFBBQUEYBSADKA0SIQoLQkZBSERJTkpETUEYByADKAsy";
		buffer[3] = "DC5ITktNUENQTElCQhIhCgtLSUlDQ09GTElMThgIIAMoCzIMLktOR0xNS0VK";
		buffer[4] = "QkFCEiEKC0FBSkFPQ0dISEFBGAogAygLMgwuTk9KTk1BSUFDR0ISEwoLR0xH";
		buffer[5] = "T0hJTkJKTEUYDCABKA0SEwoLR0JMRUZBTUtJTEIYDSABKAgSEwoLRkdJUElD";
		buffer[6] = "SUpNREYYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			HNKMPCPLIBBReflection.Descriptor,
			KNGLMKEJBABReflection.Descriptor,
			NOJNMAIACGBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHAGKIHIMFB), HHAGKIHIMFB.Parser, new string[7] { "PFDKKFPPAAA", "BFAHDINJDMA", "KIICCOFLILN", "AAJAOCGHHAA", "GLGOHINBJLE", "GBLEFAMKILB", "FGIPICIJMDF" }, null, null, null, null)
		}));
	}
}
