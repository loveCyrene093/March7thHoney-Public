using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientDownloadDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientDownloadDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDbGllbnREb3dubG9hZERhdGEucHJvdG8iVgoSQ2xpZW50RG93bmxvYWRE" + "YXRhEg8KB3ZlcnNpb24YASABKA0SDAoEdGltZRgCIAEoAxIMCgRkYXRhGAMg" + "ASgMEhMKC0VGS0NNRklKR0lKGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientDownloadData), ClientDownloadData.Parser, new string[4] { "Version", "Time", "Data", "EFKCMFIJGIJ" }, null, null, null, null)
		}));
	}
}
