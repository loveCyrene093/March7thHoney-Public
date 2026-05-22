using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADMCMFIINIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADMCMFIINIHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRE1DTUZJSU5JSC5wcm90byJTCgtBRE1DTUZJSU5JSBITCgtNT0hPQkZQ" + "SlBNTBgBIAEoDRITCgtFT0dNSUhFUENHTRgCIAMoDRIKCgJpZBgJIAEoDRIO" + "CgZpc19uZXcYCiABKAhCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADMCMFIINIH), ADMCMFIINIH.Parser, new string[4] { "MOHOBFPJPML", "EOGMIHEPCGM", "Id", "IsNew" }, null, null, null, null)
		}));
	}
}
