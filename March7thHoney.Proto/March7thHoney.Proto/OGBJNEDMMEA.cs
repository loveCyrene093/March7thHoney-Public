using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGBJNEDMMEA : IMessage<OGBJNEDMMEA>, IMessage, IEquatable<OGBJNEDMMEA>, IDeepCloneable<OGBJNEDMMEA>, IBufferMessage
{
	private static readonly MessageParser<OGBJNEDMMEA> _parser = new MessageParser<OGBJNEDMMEA>(() => new OGBJNEDMMEA());

	private UnknownFieldSet _unknownFields;

	public const int LOIJLIKOMJNFieldNumber = 1;

	private uint lOIJLIKOMJN_;

	public const int MGNGPGPPIAAFieldNumber = 2;

	private uint mGNGPGPPIAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGBJNEDMMEA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGBJNEDMMEAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOIJLIKOMJN
	{
		get
		{
			return lOIJLIKOMJN_;
		}
		set
		{
			lOIJLIKOMJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGNGPGPPIAA
	{
		get
		{
			return mGNGPGPPIAA_;
		}
		set
		{
			mGNGPGPPIAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGBJNEDMMEA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGBJNEDMMEA(OGBJNEDMMEA other)
		: this()
	{
		lOIJLIKOMJN_ = other.lOIJLIKOMJN_;
		mGNGPGPPIAA_ = other.mGNGPGPPIAA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGBJNEDMMEA Clone()
	{
		return new OGBJNEDMMEA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGBJNEDMMEA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGBJNEDMMEA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOIJLIKOMJN != other.LOIJLIKOMJN)
		{
			return false;
		}
		if (MGNGPGPPIAA != other.MGNGPGPPIAA)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (LOIJLIKOMJN != 0)
		{
			num ^= LOIJLIKOMJN.GetHashCode();
		}
		if (MGNGPGPPIAA != 0)
		{
			num ^= MGNGPGPPIAA.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (LOIJLIKOMJN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LOIJLIKOMJN);
		}
		if (MGNGPGPPIAA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGNGPGPPIAA);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (LOIJLIKOMJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOIJLIKOMJN);
		}
		if (MGNGPGPPIAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGNGPGPPIAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGBJNEDMMEA other)
	{
		if (other != null)
		{
			if (other.LOIJLIKOMJN != 0)
			{
				LOIJLIKOMJN = other.LOIJLIKOMJN;
			}
			if (other.MGNGPGPPIAA != 0)
			{
				MGNGPGPPIAA = other.MGNGPGPPIAA;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				LOIJLIKOMJN = input.ReadUInt32();
				break;
			case 16u:
				MGNGPGPPIAA = input.ReadUInt32();
				break;
			}
		}
	}
}
