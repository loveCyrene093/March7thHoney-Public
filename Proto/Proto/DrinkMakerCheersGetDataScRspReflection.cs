using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DrinkMakerCheersGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DrinkMakerCheersGetDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJEcmlua01ha2VyQ2hlZXJzR2V0RGF0YVNjUnNwLnByb3RvGhFOQ0lGREVI";
		buffer[1] = "Q01CSy5wcm90byJ8ChxEcmlua01ha2VyQ2hlZXJzR2V0RGF0YVNjUnNwEhMK";
		buffer[2] = "C0hLRUFCSkxFSVBNGAMgASgNEg8KB3JldGNvZGUYByABKA0SEwoLRUVER0JK";
		buffer[3] = "RkVFQ0EYCCABKA0SIQoLTUZFUEFFS09QTk4YCyADKAsyDC5OQ0lGREVIQ01C";
		buffer[4] = "S0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NCIFDEHCMBKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DrinkMakerCheersGetDataScRsp), DrinkMakerCheersGetDataScRsp.Parser, new string[4] { "HKEABJLEIPM", "Retcode", "EEDGBJFEECA", "MFEPAEKOPNN" }, null, null, null, null)
		}));
	}
}
