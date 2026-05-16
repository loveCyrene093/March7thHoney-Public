using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GameplayCounterTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GameplayCounterTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHYW1lcGxheUNvdW50ZXJUeXBlLnByb3RvKl0KE0dhbWVwbGF5Q291bnRl" + "clR5cGUSGQoVR0FNRVBMQVlfQ09VTlRFUl9OT05FEAASKwolR0FNRVBMQVlf" + "Q09VTlRFUl9NT05TVEVSX1NORUFLX1ZJU0lPThDBixFCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GameplayCounterType) }, null, null));
	}
}
