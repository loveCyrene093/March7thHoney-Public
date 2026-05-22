using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOADALEMDGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOADALEMDGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0FEQUxFTURHTC5wcm90bxoRSURITkpGUEFFR1AucHJvdG8iaAoLT09B" + "REFMRU1ER0wSDwoHYXJlYV9pZBgBIAEoDRIhCgtMUEpERU1PTURJRRgCIAMo" + "CzIMLklESE5KRlBBRUdQEhAKCHByb2dyZXNzGAcgASgNEhMKC09JR0hCT01G" + "R0dEGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { IDHNJFPAEGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOADALEMDGL), OOADALEMDGL.Parser, new string[4] { "AreaId", "LPJDEMOMDIE", "Progress", "OIGHBOMFGGD" }, null, null, null, null)
		}));
	}
}
