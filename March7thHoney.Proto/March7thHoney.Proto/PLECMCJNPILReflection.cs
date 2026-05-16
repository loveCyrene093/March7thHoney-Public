using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLECMCJNPILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLECMCJNPILReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFQTEVDTUNKTlBJTC5wcm90bxoRQ09OS0RFTEhLR0IucHJvdG8aEUtLTkhJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "TUdOTVBHLnByb3RvGhFPR0JKTkVETU1FQS5wcm90byLvAQoLUExFQ01DSk5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "SUwSDwoHcm9vbV9pZBgBIAEoCRITCgtKQUZOQ09NR0FCRxgCIAEoDRISCgpz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "ZWN0aW9uX2lkGAMgASgNEiEKC3BsYXllcl9pbmZvGAQgASgLMgwuS0tOSElN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "R05NUEcSIQoLRkdET0JCQkZLTU4YBSADKAsyDC5DT05LREVMSEtHQhITCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "Rk9DSElOUFBCQhgGIAMoDRITCgtETU5ESktQRUlKThgHIAMoDRITCgtGQ0lK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "R0tQS0RLQxgIIAMoDRIhCgtNQ05LQkFLQ0FKQhgJIAMoCzIMLk9HQkpORURN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "TUVBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			CONKDELHKGBReflection.Descriptor,
			KKNHIMGNMPGReflection.Descriptor,
			OGBJNEDMMEAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLECMCJNPIL), PLECMCJNPIL.Parser, new string[9] { "RoomId", "JAFNCOMGABG", "SectionId", "PlayerInfo", "FGDOBBBFKMN", "HFOCHINPPBB", "DMNDJKPEIJN", "FCIJGKPKDKC", "MCNKBAKCAJB" }, null, null, null, null)
		}));
	}
}
