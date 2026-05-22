using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveOpenChestReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveOpenChestReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpJZGxlTGl2ZU9wZW5DaGVzdFJlcS5wcm90byIrChRJZGxlTGl2ZU9wZW5D" + "aGVzdFJlcRITCgtJUENPRUdHQUpMSxgBIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveOpenChestReq), IdleLiveOpenChestReq.Parser, new string[1] { "IPCOEGGAJLK" }, null, null, null, null)
		}));
	}
}
