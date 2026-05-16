using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LIEEDGOEGMK : IMessage<LIEEDGOEGMK>, IMessage, IEquatable<LIEEDGOEGMK>, IDeepCloneable<LIEEDGOEGMK>, IBufferMessage
{
	private static readonly MessageParser<LIEEDGOEGMK> _parser = new MessageParser<LIEEDGOEGMK>(() => new LIEEDGOEGMK());

	private UnknownFieldSet _unknownFields;

	public const int GoldFieldNumber = 8;

	private uint gold_;

	public const int CPMOOKFKBEGFieldNumber = 14;

	private uint cPMOOKFKBEG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LIEEDGOEGMK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LIEEDGOEGMKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CPMOOKFKBEG
	{
		get
		{
			return cPMOOKFKBEG_;
		}
		set
		{
			cPMOOKFKBEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIEEDGOEGMK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIEEDGOEGMK(LIEEDGOEGMK other)
		: this()
	{
		gold_ = other.gold_;
		cPMOOKFKBEG_ = other.cPMOOKFKBEG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LIEEDGOEGMK Clone()
	{
		return new LIEEDGOEGMK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LIEEDGOEGMK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LIEEDGOEGMK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (CPMOOKFKBEG != other.CPMOOKFKBEG)
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
		if (Gold != 0)
		{
			num ^= Gold.GetHashCode();
		}
		if (CPMOOKFKBEG != 0)
		{
			num ^= CPMOOKFKBEG.GetHashCode();
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
		if (Gold != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Gold);
		}
		if (CPMOOKFKBEG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CPMOOKFKBEG);
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
		if (Gold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (CPMOOKFKBEG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CPMOOKFKBEG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LIEEDGOEGMK other)
	{
		if (other != null)
		{
			if (other.Gold != 0)
			{
				Gold = other.Gold;
			}
			if (other.CPMOOKFKBEG != 0)
			{
				CPMOOKFKBEG = other.CPMOOKFKBEG;
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
			case 64u:
				Gold = input.ReadUInt32();
				break;
			case 112u:
				CPMOOKFKBEG = input.ReadUInt32();
				break;
			}
		}
	}
}
