using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INCJNJGEHCDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INCJNJGEHCDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTkNKTkpHRUhDRC5wcm90byJdCgtJTkNKTkpHRUhDRBITCgtGRkVBQ1BE" + "RkFKSBgCIAEoCRITCgtDRU9GRE1DSkFQShgIIAEoDRITCgtHQk1CTUZGTktF" + "SBgOIAEoDRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INCJNJGEHCD), INCJNJGEHCD.Parser, new string[4] { "FFEACPDFAJH", "CEOFDMCJAPJ", "GBMBMFFNKEH", "Retcode" }, null, null, null, null)
		}));
	}
}
