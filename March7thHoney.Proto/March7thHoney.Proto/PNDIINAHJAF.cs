using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PNDIINAHJAF : IMessage<PNDIINAHJAF>, IMessage, IEquatable<PNDIINAHJAF>, IDeepCloneable<PNDIINAHJAF>, IBufferMessage
{
	private static readonly MessageParser<PNDIINAHJAF> _parser = new MessageParser<PNDIINAHJAF>(() => new PNDIINAHJAF());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	public const int DPELEIIAKAAFieldNumber = 1506;

	private JLFJKIDDKBG dPELEIIAKAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PNDIINAHJAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PNDIINAHJAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLFJKIDDKBG DPELEIIAKAA
	{
		get
		{
			return dPELEIIAKAA_;
		}
		set
		{
			dPELEIIAKAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDIINAHJAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDIINAHJAF(PNDIINAHJAF other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		dPELEIIAKAA_ = ((other.dPELEIIAKAA_ != null) ? other.dPELEIIAKAA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PNDIINAHJAF Clone()
	{
		return new PNDIINAHJAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PNDIINAHJAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PNDIINAHJAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(DPELEIIAKAA, other.DPELEIIAKAA))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (dPELEIIAKAA_ != null)
		{
			num ^= DPELEIIAKAA.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
		}
		if (dPELEIIAKAA_ != null)
		{
			output.WriteRawTag(146, 94);
			output.WriteMessage(DPELEIIAKAA);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (dPELEIIAKAA_ != null)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(DPELEIIAKAA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PNDIINAHJAF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.dPELEIIAKAA_ != null)
		{
			if (dPELEIIAKAA_ == null)
			{
				DPELEIIAKAA = new JLFJKIDDKBG();
			}
			DPELEIIAKAA.MergeFrom(other.DPELEIIAKAA);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			case 12050u:
				if (dPELEIIAKAA_ == null)
				{
					DPELEIIAKAA = new JLFJKIDDKBG();
				}
				input.ReadMessage(DPELEIIAKAA);
				break;
			}
		}
	}
}
