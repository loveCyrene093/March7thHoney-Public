using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMFFAIMHEOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMFFAIMHEOOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUZGQUlNSEVPTy5wcm90byI3CgtFTUZGQUlNSEVPTxITCgtFSUNFQkpQ" + "TUhNQxgHIAEoDRITCgtJTk9ESEZGT0VIThgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMFFAIMHEOO), EMFFAIMHEOO.Parser, new string[2] { "EICEBJPMHMC", "INODHFFOEHN" }, null, null, null, null)
		}));
	}
}
