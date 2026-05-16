using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NPLEDHFMFDMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NPLEDHFMFDMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOUExFREhGTUZETS5wcm90byIwCgtOUExFREhGTUZETRITCgtIQ0pQRE5E" + "T0hBTRgBIAEoDRIMCgRzbG90GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NPLEDHFMFDM), NPLEDHFMFDM.Parser, new string[2] { "HCJPDNDOHAM", "Slot" }, null, null, null, null)
		}));
	}
}
