using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCPPEBGEKHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCPPEBGEKHCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQ1BQRUJHRUtIQy5wcm90byJHCgtKQ1BQRUJHRUtIQxITCgtET0FPUEJC" + "SUdQTxgBIAEoDRINCgVsZXZlbBgCIAEoDRIUCgx0b3RhbF9kYW1hZ2UYAyAB" + "KAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCPPEBGEKHC), JCPPEBGEKHC.Parser, new string[3] { "DOAOPBBIGPO", "Level", "TotalDamage" }, null, null, null, null)
		}));
	}
}
