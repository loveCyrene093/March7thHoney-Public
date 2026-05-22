using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLLCDBLCIPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLLCDBLCIPKReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFITExDREJMQ0lQSy5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8aEUZCQk1E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RkRPRUVGLnByb3RvIrgBCgtITExDREJMQ0lQSxIgCgppdGVtX3ZhbHVlGAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ASgLMgwuRUZFR0tESEVNRk4SMgoLSk9ORE9JSFBORUEYCCADKAsyHS5ITExD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "REJMQ0lQSy5KT05ET0lIUE5FQUVudHJ5Eh8KCWl0ZW1fbGlzdBgNIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "LkZCQk1ERkRPRUVGGjIKEEpPTkRPSUhQTkVBRW50cnkSCwoDa2V5GAEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Eg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			EFEGKDHEMFNReflection.Descriptor,
			FBBMDFDOEEFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLLCDBLCIPK), HLLCDBLCIPK.Parser, new string[3] { "ItemValue", "JONDOIHPNEA", "ItemList" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
