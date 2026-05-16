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
		buffer[0] = "ChFNQUdIRUZFRUxBQi5wcm90bxoRSkVCTEFBR0NOSE4ucHJvdG8aEU9HTkpO";
		buffer[1] = "QkJCUElGLnByb3RvItEBCgtNQUdIRUZFRUxBQhITCgtFSk9NRkFIRU1OSBgC";
		buffer[2] = "IAMoDRIhCgtyZWNvcmRfaW5mbxgDIAEoCzIMLkpFQkxBQUdDTkhOEhMKC0FE";
		buffer[3] = "S0JFT1BOQklPGAQgASgIEg8KB2FyZWFfaWQYCSABKA0SEwoLR0ZOQ0tCR05M";
		buffer[4] = "TkMYDCABKA0SFwoPaXNfdGFrZW5fcmV3YXJkGA0gASgIEiEKC0VDQ0dKRE1P";
		buffer[5] = "R0FOGA4gASgLMgwuT0dOSk5CQkJQSUYSEwoLQ0VCUEFKQUFKUFAYDyABKAhC";
		buffer[6] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			JEBLAAGCNHNReflection.Descriptor,
			OGNJNBBBPIFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MAGHEFEELAB), MAGHEFEELAB.Parser, new string[8] { "EJOMFAHEMNH", "RecordInfo", "ADKBEOPNBIO", "AreaId", "GFNCKBGNLNC", "IsTakenReward", "ECCGJDMOGAN", "CEBPAJAAJPP" }, null, null, null, null)
		}));
	}
}
