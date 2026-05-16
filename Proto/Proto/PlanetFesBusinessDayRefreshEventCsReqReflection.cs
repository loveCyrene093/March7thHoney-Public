using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesBusinessDayRefreshEventCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesBusinessDayRefreshEventCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitQbGFuZXRGZXNCdXNpbmVzc0RheVJlZnJlc2hFdmVudENzUmVxLnByb3Rv";
		buffer[1] = "ImYKJVBsYW5ldEZlc0J1c2luZXNzRGF5UmVmcmVzaEV2ZW50Q3NSZXESEwoL";
		buffer[2] = "REdBSE1KT0JETkUYASABKAgSEwoLR0FGUEVDR0dJQ0MYBSABKA0SEwoLUEhL";
		buffer[3] = "QUhBSExEQUUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesBusinessDayRefreshEventCsReq), PlanetFesBusinessDayRefreshEventCsReq.Parser, new string[3] { "DGAHMJOBDNE", "GAFPECGGICC", "PHKAHAHLDAE" }, null, null, null, null)
		}));
	}
}
