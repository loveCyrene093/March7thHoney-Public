using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OKEPFGMNJAOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OKEPFGMNJAOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPS0VQRkdNTkpBTy5wcm90bxoXTWlzc2lvblN5bmNSZWNvcmQucHJvdG8i" + "UgoLT0tFUEZHTU5KQU8SIAoEdHlwZRgDIAEoDjISLk1pc3Npb25TeW5jUmVj" + "b3JkEgoKAmlkGAQgASgNEhUKDWRpc3BsYXlfdmFsdWUYCyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { MissionSyncRecordReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OKEPFGMNJAO), OKEPFGMNJAO.Parser, new string[3] { "Type", "Id", "DisplayValue" }, null, null, null, null)
		}));
	}
}
