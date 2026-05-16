using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerRecordInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerRecordInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZQbGF5ZXJSZWNvcmRJbmZvLnByb3RvGhFCSktKS0dBR0RBQy5wcm90byLd";
		buffer[1] = "AQoQUGxheWVyUmVjb3JkSW5mbxITCgtNTUZHSVBQTkVFRhgDIAEoDRITCgtM";
		buffer[2] = "Q0VFS0JBSlBIQRgEIAEoDRITCgtLRUJPSk9JQk9LRRgGIAEoDRITCgtMQktD";
		buffer[3] = "SUVCR01BShgJIAEoDRIhCgtDRUFLT09BT0pMRhgKIAEoCzIMLkJKS0pLR0FH";
		buffer[4] = "REFDEhMKC0dQSkdMTEFOUElGGAsgASgNEhMKC0tIREpEQ0VMTlBGGAwgASgN";
		buffer[5] = "EhMKC01JTUlQRE1JUE5PGA0gASgNEhMKC01QTklLQkFGUEVNGA4gASgNQhaq";
		buffer[6] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BJKJKGAGDACReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerRecordInfo), PlayerRecordInfo.Parser, new string[9] { "MMFGIPPNEEF", "LCEEKBAJPHA", "KEBOJOIBOKE", "LBKCIEBGMAJ", "CEAKOOAOJLF", "GPJGLLANPIF", "KHDJDCELNPF", "MIMIPDMIPNO", "MPNIKBAFPEM" }, null, null, null, null)
		}));
	}
}
