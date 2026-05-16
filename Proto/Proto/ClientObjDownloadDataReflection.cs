using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientObjDownloadDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientObjDownloadDataReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtDbGllbnRPYmpEb3dubG9hZERhdGEucHJvdG8aGENsaWVudERvd25sb2Fk";
		buffer[1] = "RGF0YS5wcm90byKGAQoVQ2xpZW50T2JqRG93bmxvYWREYXRhEg8KB3NjX2lu";
		buffer[2] = "Zm8YASABKAwSNQoYY2xpZW50X29ial9kb3dubG9hZF9kYXRhGAIgASgLMhMu";
		buffer[3] = "Q2xpZW50RG93bmxvYWREYXRhEiUKCGR5bl9jb2RlGAMgAygLMhMuQ2xpZW50";
		buffer[4] = "RG93bmxvYWREYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ClientDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjDownloadData), ClientObjDownloadData.Parser, new string[3] { "ScInfo", "ClientObjDownloadData_", "DynCode" }, null, null, null, null)
		}));
	}
}
