using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientDownloadDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientDownloadDataScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDbGllbnREb3dubG9hZERhdGFTY05vdGlmeS5wcm90bxoYQ2xpZW50RG93" + "bmxvYWREYXRhLnByb3RvIkgKGkNsaWVudERvd25sb2FkRGF0YVNjTm90aWZ5" + "EioKDWRvd25sb2FkX2RhdGEYBSABKAsyEy5DbGllbnREb3dubG9hZERhdGFC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ClientDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientDownloadDataScNotify), ClientDownloadDataScNotify.Parser, new string[1] { "DownloadData" }, null, null, null, null)
		}));
	}
}
