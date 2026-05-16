using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetElationActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetElationActivityDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFHZXRFbGF0aW9uQWN0aXZpdHlEYXRhU2NSc3AucHJvdG8aHkVsYXRpb25B";
		buffer[1] = "Y3Rpdml0eUxldmVsRGF0YS5wcm90byJiChtHZXRFbGF0aW9uQWN0aXZpdHlE";
		buffer[2] = "YXRhU2NSc3ASMgoPbGV2ZWxfZGF0YV9saXN0GAYgAygLMhkuRWxhdGlvbkFj";
		buffer[3] = "dGl2aXR5TGV2ZWxEYXRhEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ElationActivityLevelDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetElationActivityDataScRsp), GetElationActivityDataScRsp.Parser, new string[2] { "LevelDataList", "Retcode" }, null, null, null, null)
		}));
	}
}
