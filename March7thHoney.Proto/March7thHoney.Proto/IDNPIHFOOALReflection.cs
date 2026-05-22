using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDNPIHFOOALReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDNPIHFOOALReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRE5QSUhGT09BTC5wcm90bxoRUExJR0lBRk5MQ0IucHJvdG8iMAoLSURO" + "UElIRk9PQUwSIQoLRUxMRUxKRkdEUEgYASABKA4yDC5QTElHSUFGTkxDQkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PLIGIAFNLCBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDNPIHFOOAL), IDNPIHFOOAL.Parser, new string[1] { "ELLELJFGDPH" }, null, null, null, null)
		}));
	}
}
