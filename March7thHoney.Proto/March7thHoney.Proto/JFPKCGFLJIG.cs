using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JFPKCGFLJIG : IMessage<JFPKCGFLJIG>, IMessage, IEquatable<JFPKCGFLJIG>, IDeepCloneable<JFPKCGFLJIG>, IBufferMessage
{
	private static readonly MessageParser<JFPKCGFLJIG> _parser = new MessageParser<JFPKCGFLJIG>(() => new JFPKCGFLJIG());

	private UnknownFieldSet _unknownFields;

	public const int BONGOBNBCIMFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_bONGOBNBCIM_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> bONGOBNBCIM_ = new RepeatedField<uint>();

	public const int OFHCNGHJFHIFieldNumber = 8;

	private uint oFHCNGHJFHI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JFPKCGFLJIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JFPKCGFLJIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BONGOBNBCIM => bONGOBNBCIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OFHCNGHJFHI
	{
		get
		{
			return oFHCNGHJFHI_;
		}
		set
		{
			oFHCNGHJFHI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPKCGFLJIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPKCGFLJIG(JFPKCGFLJIG other)
		: this()
	{
		bONGOBNBCIM_ = other.bONGOBNBCIM_.Clone();
		oFHCNGHJFHI_ = other.oFHCNGHJFHI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPKCGFLJIG Clone()
	{
		return new JFPKCGFLJIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JFPKCGFLJIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JFPKCGFLJIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bONGOBNBCIM_.Equals(other.bONGOBNBCIM_))
		{
			return false;
		}
		if (OFHCNGHJFHI != other.OFHCNGHJFHI)
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
		num ^= bONGOBNBCIM_.GetHashCode();
		if (OFHCNGHJFHI != 0)
		{
			num ^= OFHCNGHJFHI.GetHashCode();
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
		bONGOBNBCIM_.WriteTo(ref output, _repeated_bONGOBNBCIM_codec);
		if (OFHCNGHJFHI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(OFHCNGHJFHI);
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
		num += bONGOBNBCIM_.CalculateSize(_repeated_bONGOBNBCIM_codec);
		if (OFHCNGHJFHI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OFHCNGHJFHI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JFPKCGFLJIG other)
	{
		if (other != null)
		{
			bONGOBNBCIM_.Add(other.bONGOBNBCIM_);
			if (other.OFHCNGHJFHI != 0)
			{
				OFHCNGHJFHI = other.OFHCNGHJFHI;
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
			case 48u:
			case 50u:
				bONGOBNBCIM_.AddEntriesFrom(ref input, _repeated_bONGOBNBCIM_codec);
				break;
			case 64u:
				OFHCNGHJFHI = input.ReadUInt32();
				break;
			}
		}
	}
}
