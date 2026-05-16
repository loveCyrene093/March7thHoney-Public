using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityGroupInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityGroupInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChpTY2VuZUVudGl0eUdyb3VwSW5mby5wcm90bxoVU2NlbmVFbnRpdHlJbmZv";
		buffer[1] = "LnByb3RvIs8BChRTY2VuZUVudGl0eUdyb3VwSW5mbxIQCghncm91cF9pZBgC";
		buffer[2] = "IAEoDRI7CgtPUExKREZPT01HRhgIIAMoCzImLlNjZW5lRW50aXR5R3JvdXBJ";
		buffer[3] = "bmZvLk9QTEpERk9PTUdGRW50cnkSJQoLZW50aXR5X2xpc3QYDCADKAsyEC5T";
		buffer[4] = "Y2VuZUVudGl0eUluZm8SDQoFc3RhdGUYDyABKA0aMgoQT1BMSkRGT09NR0ZF";
		buffer[5] = "bnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBQhaqAhNNYXJj";
		buffer[6] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneEntityInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEntityGroupInfo), SceneEntityGroupInfo.Parser, new string[4] { "GroupId", "OPLJDFOOMGF", "EntityList", "State" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
