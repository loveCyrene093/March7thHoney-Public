using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EACKMFHNKCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EACKMFHNKCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQUNLTUZITktDQi5wcm90bxoOSXRlbUxpc3QucHJvdG8iYwoLRUFDS01G" + "SE5LQ0ISDwoHcmV0Y29kZRgCIAEoDRITCgtDT09PRkZLSURNQxgDIAEoDRIc" + "CglpdGVtX2xpc3QYCSABKAsyCS5JdGVtTGlzdBIQCghncm91cF9pZBgKIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EACKMFHNKCB), EACKMFHNKCB.Parser, new string[4] { "Retcode", "COOOFFKIDMC", "ItemList", "GroupId" }, null, null, null, null)
		}));
	}
}
