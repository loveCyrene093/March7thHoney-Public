using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CHDLBDDHKDJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CHDLBDDHKDJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFDSERMQkRESEtESi5wcm90bxoRSEFCRkxNSkVFS0wucHJvdG8ieQoLQ0hE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TEJEREhLREoSEQoJYXZhdGFyX2lkGAEgASgNEiEKC0hMSENLUFBOUE5IGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgLMgwuSEFCRkxNSkVFS0wSIQoLQk5ER0dORE1FTUMYAyABKAsyDC5IQUJG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TE1KRUVLTBIRCglzdG9wX2Rlc2MYBCABKAlCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HABFLMJEEKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CHDLBDDHKDJ), CHDLBDDHKDJ.Parser, new string[4] { "AvatarId", "HLHCKPPNPNH", "BNDGGNDMEMC", "StopDesc" }, null, null, null, null)
		}));
	}
}
