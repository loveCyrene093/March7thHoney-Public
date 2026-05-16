using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKOIHOMFMDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKOIHOMFMDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFS09JSE9NRk1ERS5wcm90bxoRRkdNUEVFTUFIS0UucHJvdG8iSgoLRUtP" + "SUhPTUZNREUSGgoEdHlwZRgHIAEoDjIMLkZHTVBFRU1BSEtFEhMKC0VET0RD" + "TE1BRklMGAkgASgIEgoKAmlkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { FGMPEEMAHKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKOIHOMFMDE), EKOIHOMFMDE.Parser, new string[3] { "Type", "EDODCLMAFIL", "Id" }, null, null, null, null)
		}));
	}
}
