using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOMPLKEILJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOMPLKEILJDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFBT01QTEtFSUxKRC5wcm90bxoPU3BCYXJJbmZvLnByb3RvInIKC0FPTVBM";
		buffer[1] = "S0VJTEpEEhMKC01IRVBCTkZKRElCGAEgASgNEhEKCWF2YXRhcl9pZBgDIAEo";
		buffer[2] = "DRIaCgZzcF9iYXIYCyABKAsyCi5TcEJhckluZm8SCgoCaHAYDCABKA0SEwoL";
		buffer[3] = "YXZhdGFyX3R5cGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[4] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SpBarInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOMPLKEILJD), AOMPLKEILJD.Parser, new string[5] { "MHEPBNFJDIB", "AvatarId", "SpBar", "Hp", "AvatarType" }, null, null, null, null)
		}));
	}
}
