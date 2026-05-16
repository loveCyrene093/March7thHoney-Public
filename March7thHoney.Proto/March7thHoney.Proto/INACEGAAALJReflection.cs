using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INACEGAAALJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INACEGAAALJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTkFDRUdBQUFMSi5wcm90byI8CgtJTkFDRUdBQUFMShITCgtGTEVPQ01F" + "RkFOSBgIIAEoDRIYChB1bmxvY2tfdGltZXN0YW1wGA4gASgDQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INACEGAAALJ), INACEGAAALJ.Parser, new string[2] { "FLEOCMEFANH", "UnlockTimestamp" }, null, null, null, null)
		}));
	}
}
