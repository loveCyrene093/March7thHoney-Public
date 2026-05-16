using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFKGECLBCDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFKGECLBCDKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFERktHRUNMQkNESy5wcm90bxofR3JpZEZpZ2h0RXF1aXBUcmFja1NvdXJj";
		buffer[1] = "ZS5wcm90byK2AQoLREZLR0VDTEJDREsSKgoGc291cmNlGAEgASgOMhouR3Jp";
		buffer[2] = "ZEZpZ2h0RXF1aXBUcmFja1NvdXJjZRITCgtFREdFSElETERCRhgDIAEoCBIT";
		buffer[3] = "CgtCQ0dDR0hFUERFQRgKIAEoDRIeChZ0cmFja19lcXVpcHBlZF9pZF9saXN0";
		buffer[4] = "GAwgAygNEhMKC0ZBTk9MTk9NSEZJGA0gASgNEhwKFGdyaWRfZmlnaHRfaXRl";
		buffer[5] = "bV9saXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightEquipTrackSourceReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFKGECLBCDK), DFKGECLBCDK.Parser, new string[6] { "Source", "EDGEHIDLDBF", "BCGCGHEPDEA", "TrackEquippedIdList", "FANOLNOMHFI", "GridFightItemList" }, null, null, null, null)
		}));
	}
}
