using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetElfRestaurantDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetElfRestaurantDataScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "Ch9HZXRFbGZSZXN0YXVyYW50RGF0YVNjUnNwLnByb3RvGhFBRk9FQ0RISlBJ";
		buffer[1] = "SS5wcm90bxoRQkJDTExOUERJQUgucHJvdG8aEUJDTkpNR0NFR0FBLnByb3Rv";
		buffer[2] = "GhFNRkxESEJKTkVPTy5wcm90bxoRTkNQQ0FJS0FKR0QucHJvdG8i2wEKGUdl";
		buffer[3] = "dEVsZlJlc3RhdXJhbnREYXRhU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIhCgtM";
		buffer[4] = "SUJLUE1NR0dMShgDIAEoCzIMLkFGT0VDREhKUElJEiEKC0JOSkJGUENEQUZF";
		buffer[5] = "GAcgASgLMgwuQkNOSk1HQ0VHQUESIQoLT0NHTk9BQ0xKQUoYCCABKAsyDC5O";
		buffer[6] = "Q1BDQUlLQUpHRBIhCgtEQ0lETElGTU5MQRgLIAEoCzIMLkJCQ0xMTlBESUFI";
		buffer[7] = "EiEKC0tJSUlOR0pMRUhHGAwgASgLMgwuTUZMREhCSk5FT09CFqoCE01hcmNo";
		buffer[8] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			AFOECDHJPIIReflection.Descriptor,
			BBCLLNPDIAHReflection.Descriptor,
			BCNJMGCEGAAReflection.Descriptor,
			MFLDHBJNEOOReflection.Descriptor,
			NCPCAIKAJGDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetElfRestaurantDataScRsp), GetElfRestaurantDataScRsp.Parser, new string[6] { "Retcode", "LIBKPMMGGLJ", "BNJBFPCDAFE", "OCGNOACLJAJ", "DCIDLIFMNLA", "KIIINGJLEHG" }, null, null, null, null)
		}));
	}
}
