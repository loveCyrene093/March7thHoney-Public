using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientObjUploadScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientObjUploadScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDbGllbnRPYmpVcGxvYWRTY1JzcC5wcm90bxobQ2xpZW50T2JqRG93bmxv" + "YWREYXRhLnByb3RvIk0KFENsaWVudE9ialVwbG9hZFNjUnNwEg8KB3JldGNv" + "ZGUYCiABKA0SJAoEZGF0YRgNIAEoCzIWLkNsaWVudE9iakRvd25sb2FkRGF0" + "YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ClientObjDownloadDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjUploadScRsp), ClientObjUploadScRsp.Parser, new string[2] { "Retcode", "Data" }, null, null, null, null)
		}));
	}
}
