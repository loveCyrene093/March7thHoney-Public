using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GONNGMKDODMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GONNGMKDODMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHT05OR01LRE9ETS5wcm90byJGCgtHT05OR01LRE9ETRIRCgl1bmlxdWVf" + "aWQYBSABKAQSDwoHYnVmZl9pZBgMIAEoDRITCgtISE1HRk1QSUNBSxgNIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GONNGMKDODM), GONNGMKDODM.Parser, new string[3] { "UniqueId", "BuffId", "HHMGFMPICAK" }, null, null, null, null)
		}));
	}
}
