using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LMHFOFIEIMN : IMessage<LMHFOFIEIMN>, IMessage, IEquatable<LMHFOFIEIMN>, IDeepCloneable<LMHFOFIEIMN>, IBufferMessage
{
	private static readonly MessageParser<LMHFOFIEIMN> _parser = new MessageParser<LMHFOFIEIMN>(() => new LMHFOFIEIMN());

	private UnknownFieldSet _unknownFields;

	public const int OOPOADNHABKFieldNumber = 5;

	private uint oOPOADNHABK_;

	public const int DiceSlotIdFieldNumber = 11;

	private uint diceSlotId_;

	public const int NJMONGKLJJCFieldNumber = 15;

	private long nJMONGKLJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LMHFOFIEIMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LMHFOFIEIMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OOPOADNHABK
	{
		get
		{
			return oOPOADNHABK_;
		}
		set
		{
			oOPOADNHABK_ = value;
		}
	}

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
	public long NJMONGKLJJC
	{
		get
		{
			return nJMONGKLJJC_;
		}
		set
		{
			nJMONGKLJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHFOFIEIMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHFOFIEIMN(LMHFOFIEIMN other)
		: this()
	{
		oOPOADNHABK_ = other.oOPOADNHABK_;
		diceSlotId_ = other.diceSlotId_;
		nJMONGKLJJC_ = other.nJMONGKLJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMHFOFIEIMN Clone()
	{
		return new LMHFOFIEIMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LMHFOFIEIMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LMHFOFIEIMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OOPOADNHABK != other.OOPOADNHABK)
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (NJMONGKLJJC != other.NJMONGKLJJC)
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
		if (OOPOADNHABK != 0)
		{
			num ^= OOPOADNHABK.GetHashCode();
		}
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (NJMONGKLJJC != 0L)
		{
			num ^= NJMONGKLJJC.GetHashCode();
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
		if (OOPOADNHABK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(OOPOADNHABK);
		}
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DiceSlotId);
		}
		if (NJMONGKLJJC != 0L)
		{
			output.WriteRawTag(120);
			output.WriteInt64(NJMONGKLJJC);
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
		if (OOPOADNHABK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OOPOADNHABK);
		}
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (NJMONGKLJJC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(NJMONGKLJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LMHFOFIEIMN other)
	{
		if (other != null)
		{
			if (other.OOPOADNHABK != 0)
			{
				OOPOADNHABK = other.OOPOADNHABK;
			}
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.NJMONGKLJJC != 0L)
			{
				NJMONGKLJJC = other.NJMONGKLJJC;
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
			case 40u:
				OOPOADNHABK = input.ReadUInt32();
				break;
			case 88u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 120u:
				NJMONGKLJJC = input.ReadInt64();
				break;
			}
		}
	}
}
