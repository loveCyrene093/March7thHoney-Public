using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EECJMIOAFFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EECJMIOAFFGReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFFRUNKTUlPQUZGRy5wcm90bxoRRk9GQkRCSkJFSkUucHJvdG8aEU9CT0tE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "SERPS0FELnByb3RvIrMBCgtFRUNKTUlPQUZGRxIhCgtITUlITERQTVBPTRgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IAEoCzIMLk9CT0tESERPS0FEEhMKC0JIUExLSEFNQklHGAUgASgNEhMKC0VL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "TEtIUEdEUE9MGAYgASgDEgwKBG5hbWUYByABKAkSEwoLS0tHSUVFTkNPSUMY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "CSABKA0SEQoJaXNfbWFya2VkGAsgASgIEiEKC0pISEhPTkpJS0dMGA4gASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "MgwuRk9GQkRCSkJFSkVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			FOFBDBJBEJEReflection.Descriptor,
			OBOKDHDOKADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EECJMIOAFFG), EECJMIOAFFG.Parser, new string[7] { "HMIHLDPMPOM", "BHPLKHAMBIG", "EKLKHPGDPOL", "Name", "KKGIEENCOIC", "IsMarked", "JHHHONJIKGL" }, null, null, null, null)
		}));
	}
}
