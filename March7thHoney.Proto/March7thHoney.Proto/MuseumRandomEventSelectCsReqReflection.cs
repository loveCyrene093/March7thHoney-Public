using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MuseumRandomEventSelectCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MuseumRandomEventSelectCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNdXNldW1SYW5kb21FdmVudFNlbGVjdENzUmVxLnByb3RvIkUKHE11c2V1" + "bVJhbmRvbUV2ZW50U2VsZWN0Q3NSZXESEAoIZXZlbnRfaWQYBiABKA0SEwoL" + "SUxIQUJGSktFR0QYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MuseumRandomEventSelectCsReq), MuseumRandomEventSelectCsReq.Parser, new string[2] { "EventId", "ILHABFJKEGD" }, null, null, null, null)
		}));
	}
}
