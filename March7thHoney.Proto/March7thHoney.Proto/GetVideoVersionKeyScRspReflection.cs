using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetVideoVersionKeyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetVideoVersionKeyScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch1HZXRWaWRlb1ZlcnNpb25LZXlTY1JzcC5wcm90bxoSVmlkZW9LZXlJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "LnByb3RvIosBChdHZXRWaWRlb1ZlcnNpb25LZXlTY1JzcBIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GAUgASgNEjMKHGFjdGl2aXR5X3ZpZGVvX2tleV9pbmZvX2xpc3QYBiADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DS5WaWRlb0tleUluZm8SKgoTdmlkZW9fa2V5X2luZm9fbGlzdBgIIAMoCzIN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlZpZGVvS2V5SW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { VideoKeyInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetVideoVersionKeyScRsp), GetVideoVersionKeyScRsp.Parser, new string[3] { "Retcode", "ActivityVideoKeyInfoList", "VideoKeyInfoList" }, null, null, null, null)
		}));
	}
}
