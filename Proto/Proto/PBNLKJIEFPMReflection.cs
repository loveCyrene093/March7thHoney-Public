using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBNLKJIEFPMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBNLKJIEFPMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQk5MS0pJRUZQTS5wcm90bxoOSXRlbUxpc3QucHJvdG8iVwoLUEJOTEtK" + "SUVGUE0SEwoLSU5GS0NITU5OS0oYBSADKA0SHgoLSU5BQU9IS0VPT0UYByAB" + "KAsyCS5JdGVtTGlzdBITCgtOT09IT0VPQ1BLRRgOIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBNLKJIEFPM), PBNLKJIEFPM.Parser, new string[3] { "INFKCHMNNKJ", "INAAOHKEOOE", "NOOHOEOCPKE" }, null, null, null, null)
		}));
	}
}
