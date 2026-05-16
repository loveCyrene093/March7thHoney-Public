using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHcmlkRmlnaHRHYW1lRGF0YS5wcm90bxobR3JpZEZpZ2h0R2FtZUl0ZW1J" + "bmZvLnByb3RvIkAKEUdyaWRGaWdodEdhbWVEYXRhEisKC1BHRk1JQ0hNSEZD" + "GAwgAygLMhYuR3JpZEZpZ2h0R2FtZUl0ZW1JbmZvQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GridFightGameItemInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameData), GridFightGameData.Parser, new string[1] { "PGFMICHMHFC" }, null, null, null, null)
		}));
	}
}
