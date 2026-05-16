using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFarmStageGachaInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFarmStageGachaInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBHZXRGYXJtU3RhZ2VHYWNoYUluZm9TY1JzcC5wcm90bxoYRmFybVN0YWdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "R2FjaGFJbmZvLnByb3RvImYKGkdldEZhcm1TdGFnZUdhY2hhSW5mb1NjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EjcKGmZhcm1fc3RhZ2VfZ2FjaGFfaW5mb19saXN0GAMgAygLMhMuRmFybVN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YWdlR2FjaGFJbmZvEg8KB3JldGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FarmStageGachaInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFarmStageGachaInfoScRsp), GetFarmStageGachaInfoScRsp.Parser, new string[2] { "FarmStageGachaInfoList", "Retcode" }, null, null, null, null)
		}));
	}
}
