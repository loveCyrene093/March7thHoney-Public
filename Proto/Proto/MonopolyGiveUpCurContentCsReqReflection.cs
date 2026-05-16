using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGiveUpCurContentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGiveUpCurContentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNNb25vcG9seUdpdmVVcEN1ckNvbnRlbnRDc1JlcS5wcm90byIzCh1Nb25v" + "cG9seUdpdmVVcEN1ckNvbnRlbnRDc1JlcRISCgpjb250ZW50X2lkGAcgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGiveUpCurContentCsReq), MonopolyGiveUpCurContentCsReq.Parser, new string[1] { "ContentId" }, null, null, null, null)
		}));
	}
}
