using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MAGHEFEELABReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MAGHEFEELABReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFNQUdIRUZFRUxBQi5wcm90bxoRSkVCTEFBR0NOSE4ucHJvdG8aEU9HTkpO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "QkJCUElGLnByb3RvItEBCgtNQUdIRUZFRUxBQhITCgtFSk9NRkFIRU1OSBgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IAMoDRIhCgtyZWNvcmRfaW5mbxgDIAEoCzIMLkpFQkxBQUdDTkhOEhMKC0FE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "S0JFT1BOQklPGAQgASgIEg8KB2FyZWFfaWQYCSABKA0SEwoLR0ZOQ0tCR05M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "TkMYDCABKA0SFwoPaXNfdGFrZW5fcmV3YXJkGA0gASgIEiEKC0VDQ0dKRE1P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "R0FOGA4gASgLMgwuT0dOSk5CQkJQSUYSEwoLQ0VCUEFKQUFKUFAYDyABKAhC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			JEBLAAGCNHNReflection.Descriptor,
			OGNJNBBBPIFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MAGHEFEELAB), MAGHEFEELAB.Parser, new string[8] { "EJOMFAHEMNH", "RecordInfo", "ADKBEOPNBIO", "AreaId", "GFNCKBGNLNC", "IsTakenReward", "ECCGJDMOGAN", "CEBPAJAAJPP" }, null, null, null, null)
		}));
	}
}
