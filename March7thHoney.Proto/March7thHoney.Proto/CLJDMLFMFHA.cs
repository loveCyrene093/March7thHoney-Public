using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CLJDMLFMFHA : IMessage<CLJDMLFMFHA>, IMessage, IEquatable<CLJDMLFMFHA>, IDeepCloneable<CLJDMLFMFHA>, IBufferMessage
{
	private static readonly MessageParser<CLJDMLFMFHA> _parser = new MessageParser<CLJDMLFMFHA>(() => new CLJDMLFMFHA());

	private UnknownFieldSet _unknownFields;

	public const int DiceSlotIdFieldNumber = 3;

	private uint diceSlotId_;

	public const int CCOGFKLOFKLFieldNumber = 10;

	private uint cCOGFKLOFKL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CLJDMLFMFHA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CLJDMLFMFHAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiceSlotId
	{
		get
		{
			return diceSlotId_;
		}
		set
		{
			diceSlotId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCOGFKLOFKL
	{
		get
		{
			return cCOGFKLOFKL_;
		}
		set
		{
			cCOGFKLOFKL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJDMLFMFHA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJDMLFMFHA(CLJDMLFMFHA other)
		: this()
	{
		diceSlotId_ = other.diceSlotId_;
		cCOGFKLOFKL_ = other.cCOGFKLOFKL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CLJDMLFMFHA Clone()
	{
		return new CLJDMLFMFHA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CLJDMLFMFHA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CLJDMLFMFHA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (CCOGFKLOFKL != other.CCOGFKLOFKL)
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
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (CCOGFKLOFKL != 0)
		{
			num ^= CCOGFKLOFKL.GetHashCode();
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
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DiceSlotId);
		}
		if (CCOGFKLOFKL != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(CCOGFKLOFKL);
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
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (CCOGFKLOFKL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCOGFKLOFKL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CLJDMLFMFHA other)
	{
		if (other != null)
		{
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.CCOGFKLOFKL != 0)
			{
				CCOGFKLOFKL = other.CCOGFKLOFKL;
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
			case 24u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 80u:
				CCOGFKLOFKL = input.ReadUInt32();
				break;
			}
		}
	}
}
