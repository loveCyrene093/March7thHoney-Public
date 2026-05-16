using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFightCakeRaceTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFightCakeRaceTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDbWRGaWdodENha2VSYWNlVHlwZS5wcm90byozChRDbWRGaWdodENha2VS" + "YWNlVHlwZRIbChdBS1BFRkVQTENGQV9QQ1BESEVMUEtFTRAAQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFightCakeRaceType) }, null, null));
	}
}
