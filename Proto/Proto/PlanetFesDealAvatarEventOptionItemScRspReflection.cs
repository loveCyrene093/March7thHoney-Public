using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesDealAvatarEventOptionItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesDealAvatarEventOptionItemScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ci1QbGFuZXRGZXNEZWFsQXZhdGFyRXZlbnRPcHRpb25JdGVtU2NSc3AucHJv";
		buffer[1] = "dG8aEUhMTENEQkxDSVBLLnByb3RvGhFKSVBBQ0RFSktKQy5wcm90byK6AQon";
		buffer[2] = "UGxhbmV0RmVzRGVhbEF2YXRhckV2ZW50T3B0aW9uSXRlbVNjUnNwEhMKC0lD";
		buffer[3] = "T0dBSEZGQ0xEGAEgASgIEhMKC0FBSUpLSUJPTk9PGAcgASgNEhwKBnJld2Fy";
		buffer[4] = "ZBgJIAEoCzIMLkhMTENEQkxDSVBLEhMKC0VFTU5ER0lQQklDGAogASgNEiEK";
		buffer[5] = "C0RJSEVDSUlLRUxFGAwgASgLMgwuSklQQUNERUpLSkMSDwoHcmV0Y29kZRgN";
		buffer[6] = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HLLCDBLCIPKReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesDealAvatarEventOptionItemScRsp), PlanetFesDealAvatarEventOptionItemScRsp.Parser, new string[6] { "ICOGAHFFCLD", "AAIJKIBONOO", "Reward", "EEMNDGIPBIC", "DIHECIIKELE", "Retcode" }, null, null, null, null)
		}));
	}
}
