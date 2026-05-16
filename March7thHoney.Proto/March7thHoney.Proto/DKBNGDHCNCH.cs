using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DKBNGDHCNCH : IMessage<DKBNGDHCNCH>, IMessage, IEquatable<DKBNGDHCNCH>, IDeepCloneable<DKBNGDHCNCH>, IBufferMessage
{
	private static readonly MessageParser<DKBNGDHCNCH> _parser = new MessageParser<DKBNGDHCNCH>(() => new DKBNGDHCNCH());

	private UnknownFieldSet _unknownFields;

	public const int PNOCKMEMHLKFieldNumber = 3;

	private uint pNOCKMEMHLK_;

	public const int KKIOIFLJEELFieldNumber = 6;

	private uint kKIOIFLJEEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DKBNGDHCNCH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DKBNGDHCNCHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNOCKMEMHLK
	{
		get
		{
			return pNOCKMEMHLK_;
		}
		set
		{
			pNOCKMEMHLK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKIOIFLJEEL
	{
		get
		{
			return kKIOIFLJEEL_;
		}
		set
		{
			kKIOIFLJEEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNGDHCNCH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNGDHCNCH(DKBNGDHCNCH other)
		: this()
	{
		pNOCKMEMHLK_ = other.pNOCKMEMHLK_;
		kKIOIFLJEEL_ = other.kKIOIFLJEEL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DKBNGDHCNCH Clone()
	{
		return new DKBNGDHCNCH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DKBNGDHCNCH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DKBNGDHCNCH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNOCKMEMHLK != other.PNOCKMEMHLK)
		{
			return false;
		}
		if (KKIOIFLJEEL != other.KKIOIFLJEEL)
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
		if (PNOCKMEMHLK != 0)
		{
			num ^= PNOCKMEMHLK.GetHashCode();
		}
		if (KKIOIFLJEEL != 0)
		{
			num ^= KKIOIFLJEEL.GetHashCode();
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
		if (PNOCKMEMHLK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PNOCKMEMHLK);
		}
		if (KKIOIFLJEEL != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(KKIOIFLJEEL);
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
		if (PNOCKMEMHLK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNOCKMEMHLK);
		}
		if (KKIOIFLJEEL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKIOIFLJEEL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DKBNGDHCNCH other)
	{
		if (other != null)
		{
			if (other.PNOCKMEMHLK != 0)
			{
				PNOCKMEMHLK = other.PNOCKMEMHLK;
			}
			if (other.KKIOIFLJEEL != 0)
			{
				KKIOIFLJEEL = other.KKIOIFLJEEL;
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
				PNOCKMEMHLK = input.ReadUInt32();
				break;
			case 48u:
				KKIOIFLJEEL = input.ReadUInt32();
				break;
			}
		}
	}
}
