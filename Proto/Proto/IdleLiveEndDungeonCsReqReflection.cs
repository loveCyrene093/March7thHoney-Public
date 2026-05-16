using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveEndDungeonCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveEndDungeonCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1JZGxlTGl2ZUVuZER1bmdlb25Dc1JlcS5wcm90bxoRS0ZORkhJQUVLSU4u";
		buffer[1] = "cHJvdG8iZgoXSWRsZUxpdmVFbmREdW5nZW9uQ3NSZXESEwoLTERKS0VFUE5K";
		buffer[2] = "REMYByABKAgSIQoLTU5MQk1BTERQRUoYCCABKAsyDC5LRk5GSElBRUtJThIT";
		buffer[3] = "CgtJR0dLS0RQSkRCRRgPIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { KFNFHIAEKINReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveEndDungeonCsReq), IdleLiveEndDungeonCsReq.Parser, new string[3] { "LDJKEEPNJDC", "MNLBMALDPEJ", "IGGKKDPJDBE" }, null, null, null, null)
		}));
	}
}
