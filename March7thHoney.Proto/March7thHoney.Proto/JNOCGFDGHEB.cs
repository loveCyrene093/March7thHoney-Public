using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JNOCGFDGHEB : IMessage<JNOCGFDGHEB>, IMessage, IEquatable<JNOCGFDGHEB>, IDeepCloneable<JNOCGFDGHEB>, IBufferMessage
{
	private static readonly MessageParser<JNOCGFDGHEB> _parser = new MessageParser<JNOCGFDGHEB>(() => new JNOCGFDGHEB());

	private UnknownFieldSet _unknownFields;

	public const int StopDescFieldNumber = 1;

	private string stopDesc_ = "";

	public const int EKPBOEEIPDAFieldNumber = 2;

	private uint eKPBOEEIPDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JNOCGFDGHEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JNOCGFDGHEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StopDesc
	{
		get
		{
			return stopDesc_;
		}
		set
		{
			stopDesc_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EKPBOEEIPDA
	{
		get
		{
			return eKPBOEEIPDA_;
		}
		set
		{
			eKPBOEEIPDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNOCGFDGHEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNOCGFDGHEB(JNOCGFDGHEB other)
		: this()
	{
		stopDesc_ = other.stopDesc_;
		eKPBOEEIPDA_ = other.eKPBOEEIPDA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNOCGFDGHEB Clone()
	{
		return new JNOCGFDGHEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JNOCGFDGHEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JNOCGFDGHEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StopDesc != other.StopDesc)
		{
			return false;
		}
		if (EKPBOEEIPDA != other.EKPBOEEIPDA)
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
		if (StopDesc.Length != 0)
		{
			num ^= StopDesc.GetHashCode();
		}
		if (EKPBOEEIPDA != 0)
		{
			num ^= EKPBOEEIPDA.GetHashCode();
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
		if (StopDesc.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(StopDesc);
		}
		if (EKPBOEEIPDA != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(EKPBOEEIPDA);
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
		if (StopDesc.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(StopDesc);
		}
		if (EKPBOEEIPDA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EKPBOEEIPDA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JNOCGFDGHEB other)
	{
		if (other != null)
		{
			if (other.StopDesc.Length != 0)
			{
				StopDesc = other.StopDesc;
			}
			if (other.EKPBOEEIPDA != 0)
			{
				EKPBOEEIPDA = other.EKPBOEEIPDA;
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
			case 10u:
				StopDesc = input.ReadString();
				break;
			case 16u:
				EKPBOEEIPDA = input.ReadUInt32();
				break;
			}
		}
	}
}
