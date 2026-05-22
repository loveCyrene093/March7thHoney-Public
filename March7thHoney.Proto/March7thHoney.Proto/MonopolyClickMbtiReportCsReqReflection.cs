using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyClickMbtiReportCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyClickMbtiReportCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNb25vcG9seUNsaWNrTWJ0aVJlcG9ydENzUmVxLnByb3RvIh4KHE1vbm9w" + "b2x5Q2xpY2tNYnRpUmVwb3J0Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyClickMbtiReportCsReq), MonopolyClickMbtiReportCsReq.Parser, null, null, null, null, null)
		}));
	}
}
