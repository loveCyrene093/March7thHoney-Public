using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGameCreateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGameCreateScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBNb25vcG9seUdhbWVDcmVhdGVTY05vdGlmeS5wcm90bxoRQkFGUE5DUEhO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkYucHJvdG8aEUtIQ0hQUExPRkpOLnByb3RvImIKGk1vbm9wb2x5R2FtZUNy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZWF0ZVNjTm90aWZ5EiEKC0JNS0FFRkFLTkZKGAggASgLMgwuS0hDSFBQTE9G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Sk4SIQoLRERMRkxQS05MUEwYCyABKAsyDC5CQUZQTkNQSE5GRkIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BAFPNCPHNFFReflection.Descriptor,
			KHCHPPLOFJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGameCreateScNotify), MonopolyGameCreateScNotify.Parser, new string[2] { "BMKAEFAKNFJ", "DDLFLPKNLPL" }, null, null, null, null)
		}));
	}
}
