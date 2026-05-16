using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHFOGDPBOHNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHFOGDPBOHNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSEZPR0RQQk9ITi5wcm90bxoRS01MQ0VOTEFHTU4ucHJvdG8iZwoLTkhG" + "T0dEUEJPSE4SIQoLTkZGQUJNSk9PREUYAiABKA4yDC5LTUxDRU5MQUdNThIa" + "ChJvdXRzaWRlX3JlbGljX2xpc3QYBiADKA0SGQoRaW5zaWRlX3JlbGljX2xp" + "c3QYCyADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { KMLCENLAGMNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHFOGDPBOHN), NHFOGDPBOHN.Parser, new string[3] { "NFFABMJOODE", "OutsideRelicList", "InsideRelicList" }, null, null, null, null)
		}));
	}
}
