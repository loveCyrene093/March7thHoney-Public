using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientObjDownloadDataScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientObjDownloadDataScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDbGllbnRPYmpEb3dubG9hZERhdGFTY05vdGlmeS5wcm90bxobQ2xpZW50" + "T2JqRG93bmxvYWREYXRhLnByb3RvIkUKHUNsaWVudE9iakRvd25sb2FkRGF0" + "YVNjTm90aWZ5EiQKBGRhdGEYDSABKAsyFi5DbGllbnRPYmpEb3dubG9hZERh" + "dGFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ClientObjDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjDownloadDataScNotify), ClientObjDownloadDataScNotify.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
