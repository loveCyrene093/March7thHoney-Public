using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddRelicFilterPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddRelicFilterPlanCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch1BZGRSZWxpY0ZpbHRlclBsYW5Dc1JlcS5wcm90bxoRRk9GQkRCSkJFSkUu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "cHJvdG8aEU9CT0tESERPS0FELnByb3RvIpUBChdBZGRSZWxpY0ZpbHRlclBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "YW5Dc1JlcRIRCglpc19tYXJrZWQYBCABKAgSDAoEbmFtZRgFIAEoCRIhCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TUlITERQTVBPTRgGIAEoCzIMLk9CT0tESERPS0FEEiEKC0pISEhPTkpJS0dM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GAggASgLMgwuRk9GQkRCSkJFSkUSEwoLQkhQTEtIQU1CSUcYCSABKA1CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FOFBDBJBEJEReflection.Descriptor,
			OBOKDHDOKADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddRelicFilterPlanCsReq), AddRelicFilterPlanCsReq.Parser, new string[5] { "IsMarked", "Name", "HMIHLDPMPOM", "JHHHONJIKGL", "BHPLKHAMBIG" }, null, null, null, null)
		}));
	}
}
