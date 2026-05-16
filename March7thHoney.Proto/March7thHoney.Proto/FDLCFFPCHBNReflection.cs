using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FDLCFFPCHBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FDLCFFPCHBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRExDRkZQQ0hCTi5wcm90byJICgtGRExDRkZQQ0hCThITCgtQT0NJRk5M" + "RUZIThgBIAEoDRITCgtDT0VCSEtGSkpHTxgGIAEoDRIPCgdidWZmX2lkGA4g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FDLCFFPCHBN), FDLCFFPCHBN.Parser, new string[3] { "POCIFNLEFHN", "COEBHKFJJGO", "BuffId" }, null, null, null, null)
		}));
	}
}
