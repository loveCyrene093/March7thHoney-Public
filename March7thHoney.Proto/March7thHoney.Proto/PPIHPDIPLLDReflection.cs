using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPIHPDIPLLDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPIHPDIPLLDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUElIUERJUExMRC5wcm90byI+CgtQUElIUERJUExMRBITCgtGT0VLRE1F" + "QUxLRhgIIAMoDRIaChJnYW1lX3N0b3J5X2xpbmVfaWQYCyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPIHPDIPLLD), PPIHPDIPLLD.Parser, new string[2] { "FOEKDMEALKF", "GameStoryLineId" }, null, null, null, null)
		}));
	}
}
