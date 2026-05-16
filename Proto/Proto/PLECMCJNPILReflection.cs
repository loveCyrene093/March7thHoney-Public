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
		buffer[0] = "ChFQTEVDTUNKTlBJTC5wcm90bxoRQ09OS0RFTEhLR0IucHJvdG8aEUtLTkhJ";
		buffer[1] = "TUdOTVBHLnByb3RvGhFPR0JKTkVETU1FQS5wcm90byLvAQoLUExFQ01DSk5Q";
		buffer[2] = "SUwSDwoHcm9vbV9pZBgBIAEoCRITCgtKQUZOQ09NR0FCRxgCIAEoDRISCgpz";
		buffer[3] = "ZWN0aW9uX2lkGAMgASgNEiEKC3BsYXllcl9pbmZvGAQgASgLMgwuS0tOSElN";
		buffer[4] = "R05NUEcSIQoLRkdET0JCQkZLTU4YBSADKAsyDC5DT05LREVMSEtHQhITCgtI";
		buffer[5] = "Rk9DSElOUFBCQhgGIAMoDRITCgtETU5ESktQRUlKThgHIAMoDRITCgtGQ0lK";
		buffer[6] = "R0tQS0RLQxgIIAMoDRIhCgtNQ05LQkFLQ0FKQhgJIAMoCzIMLk9HQkpORURN";
		buffer[7] = "TUVBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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
