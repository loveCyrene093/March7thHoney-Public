using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONDOIAABCDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONDOIAABCDGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTkRPSUFBQkNERy5wcm90byI3CgtPTkRPSUFBQkNERxITCgtBTUFERkpO" + "SE1GRhgFIAEoDRITCgtIT0hBTlBKTkFOQRgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONDOIAABCDG), ONDOIAABCDG.Parser, new string[2] { "AMADFJNHMFF", "HOHANPJNANA" }, null, null, null, null)
		}));
	}
}
