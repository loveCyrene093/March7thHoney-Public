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
		buffer[0] = "ChFITExDREJMQ0lQSy5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8aEUZCQk1E";
		buffer[1] = "RkRPRUVGLnByb3RvIrgBCgtITExDREJMQ0lQSxIgCgppdGVtX3ZhbHVlGAYg";
		buffer[2] = "ASgLMgwuRUZFR0tESEVNRk4SMgoLSk9ORE9JSFBORUEYCCADKAsyHS5ITExD";
		buffer[3] = "REJMQ0lQSy5KT05ET0lIUE5FQUVudHJ5Eh8KCWl0ZW1fbGlzdBgNIAMoCzIM";
		buffer[4] = "LkZCQk1ERkRPRUVGGjIKEEpPTkRPSUhQTkVBRW50cnkSCwoDa2V5GAEgASgN";
		buffer[5] = "Eg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[6] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFEGKDHEMFNReflection.Descriptor,
			FBBMDFDOEEFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLLCDBLCIPK), HLLCDBLCIPK.Parser, new string[3] { "ItemValue", "JONDOIHPNEA", "ItemList" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
