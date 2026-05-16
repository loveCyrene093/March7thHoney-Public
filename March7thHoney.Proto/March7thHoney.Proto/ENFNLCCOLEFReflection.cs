using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENFNLCCOLEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENFNLCCOLEFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkZOTENDT0xFRi5wcm90byJFCgtFTkZOTENDT0xFRhIhChlkcmVzc19l" + "cXVpcG1lbnRfdW5pcXVlX2lkGAogASgNEhMKC09IT0tCS0VMRk9LGA8gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENFNLCCOLEF), ENFNLCCOLEF.Parser, new string[2] { "DressEquipmentUniqueId", "OHOKBKELFOK" }, null, null, null, null)
		}));
	}
}
