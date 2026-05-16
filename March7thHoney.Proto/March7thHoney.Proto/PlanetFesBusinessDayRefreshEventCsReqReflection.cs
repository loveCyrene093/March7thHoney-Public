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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CitQbGFuZXRGZXNCdXNpbmVzc0RheVJlZnJlc2hFdmVudENzUmVxLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ImYKJVBsYW5ldEZlc0J1c2luZXNzRGF5UmVmcmVzaEV2ZW50Q3NSZXESEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "REdBSE1KT0JETkUYASABKAgSEwoLR0FGUEVDR0dJQ0MYBSABKA0SEwoLUEhL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QUhBSExEQUUYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesBusinessDayRefreshEventCsReq), PlanetFesBusinessDayRefreshEventCsReq.Parser, new string[3] { "DGAHMJOBDNE", "GAFPECGGICC", "PHKAHAHLDAE" }, null, null, null, null)
		}));
	}
}
