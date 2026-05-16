using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APHLJPLBOIF : IMessage<APHLJPLBOIF>, IMessage, IEquatable<APHLJPLBOIF>, IDeepCloneable<APHLJPLBOIF>, IBufferMessage
{
	private static readonly MessageParser<APHLJPLBOIF> _parser = new MessageParser<APHLJPLBOIF>(() => new APHLJPLBOIF());

	private UnknownFieldSet _unknownFields;

	public const int PNJHMGNEJJIFieldNumber = 6;

	private uint pNJHMGNEJJI_;

	public const int ALFHNEHOBJAFieldNumber = 7;

	private BGCEJDCHKBA aLFHNEHOBJA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APHLJPLBOIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APHLJPLBOIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNJHMGNEJJI
	{
		get
		{
			return pNJHMGNEJJI_;
		}
		set
		{
			pNJHMGNEJJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGCEJDCHKBA ALFHNEHOBJA
	{
		get
		{
			return aLFHNEHOBJA_;
		}
		set
		{
			aLFHNEHOBJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHLJPLBOIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHLJPLBOIF(APHLJPLBOIF other)
		: this()
	{
		pNJHMGNEJJI_ = other.pNJHMGNEJJI_;
		aLFHNEHOBJA_ = other.aLFHNEHOBJA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APHLJPLBOIF Clone()
	{
		return new APHLJPLBOIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APHLJPLBOIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APHLJPLBOIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PNJHMGNEJJI != other.PNJHMGNEJJI)
		{
			return false;
		}
		if (ALFHNEHOBJA != other.ALFHNEHOBJA)
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
		if (PNJHMGNEJJI != 0)
		{
			num ^= PNJHMGNEJJI.GetHashCode();
		}
		if (ALFHNEHOBJA != BGCEJDCHKBA.Pcpdhelpkem)
		{
			num ^= ALFHNEHOBJA.GetHashCode();
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
		if (PNJHMGNEJJI != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PNJHMGNEJJI);
		}
		if (ALFHNEHOBJA != BGCEJDCHKBA.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)ALFHNEHOBJA);
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
		if (PNJHMGNEJJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNJHMGNEJJI);
		}
		if (ALFHNEHOBJA != BGCEJDCHKBA.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ALFHNEHOBJA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APHLJPLBOIF other)
	{
		if (other != null)
		{
			if (other.PNJHMGNEJJI != 0)
			{
				PNJHMGNEJJI = other.PNJHMGNEJJI;
			}
			if (other.ALFHNEHOBJA != BGCEJDCHKBA.Pcpdhelpkem)
			{
				ALFHNEHOBJA = other.ALFHNEHOBJA;
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
				PNJHMGNEJJI = input.ReadUInt32();
				break;
			case 56u:
				ALFHNEHOBJA = (BGCEJDCHKBA)input.ReadEnum();
				break;
			}
		}
	}
}
