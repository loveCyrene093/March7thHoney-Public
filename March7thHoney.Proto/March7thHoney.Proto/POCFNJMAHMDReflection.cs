using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POCFNJMAHMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POCFNJMAHMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQT0NGTkpNQUhNRC5wcm90byJbCgtQT0NGTkpNQUhNRBINCgVsZXZlbBgC" + "IAEoDRITCgtQRU5MTUVJSklGSxgEIAEoDRITCgtNT09PUEFNQk9GSxgIIAEo" + "DRITCgtHRUZHT0lHSkhGShgNIAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(POCFNJMAHMD), POCFNJMAHMD.Parser, new string[4] { "Level", "PENLMEIJIFK", "MOOOPAMBOFK", "GEFGOIGJHFJ" }, null, null, null, null)
		}));
	}
}
