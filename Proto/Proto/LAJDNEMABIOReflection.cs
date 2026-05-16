using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LAJDNEMABIOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LAJDNEMABIOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQUpETkVNQUJJTy5wcm90bxoRSURITkpGUEFFR1AucHJvdG8iRQoLTEFK" + "RE5FTUFCSU8SEwoLRUVJQkhNUENBUEsYAyABKA0SIQoLTFBKREVNT01ESUUY" + "DyADKAsyDC5JREhOSkZQQUVHUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IDHNJFPAEGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LAJDNEMABIO), LAJDNEMABIO.Parser, new string[2] { "EEIBHMPCAPK", "LPJDEMOMDIE" }, null, null, null, null)
		}));
	}
}
