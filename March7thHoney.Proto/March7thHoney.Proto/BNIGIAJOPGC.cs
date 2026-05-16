using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BNIGIAJOPGC : IMessage<BNIGIAJOPGC>, IMessage, IEquatable<BNIGIAJOPGC>, IDeepCloneable<BNIGIAJOPGC>, IBufferMessage
{
	private static readonly MessageParser<BNIGIAJOPGC> _parser = new MessageParser<BNIGIAJOPGC>(() => new BNIGIAJOPGC());

	private UnknownFieldSet _unknownFields;

	public const int CEEGGCPPAFJFieldNumber = 1;

	private uint cEEGGCPPAFJ_;

	public const int ILHDBHMAAMOFieldNumber = 6;

	private uint iLHDBHMAAMO_;

	public const int LevelFieldNumber = 13;

	private uint level_;

	public const int TypeFieldNumber = 14;

	private MovieRacingType type_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BNIGIAJOPGC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BNIGIAJOPGCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEEGGCPPAFJ
	{
		get
		{
			return cEEGGCPPAFJ_;
		}
		set
		{
			cEEGGCPPAFJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILHDBHMAAMO
	{
		get
		{
			return iLHDBHMAAMO_;
		}
		set
		{
			iLHDBHMAAMO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MovieRacingType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIGIAJOPGC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIGIAJOPGC(BNIGIAJOPGC other)
		: this()
	{
		cEEGGCPPAFJ_ = other.cEEGGCPPAFJ_;
		iLHDBHMAAMO_ = other.iLHDBHMAAMO_;
		level_ = other.level_;
		type_ = other.type_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BNIGIAJOPGC Clone()
	{
		return new BNIGIAJOPGC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BNIGIAJOPGC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BNIGIAJOPGC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEEGGCPPAFJ != other.CEEGGCPPAFJ)
		{
			return false;
		}
		if (ILHDBHMAAMO != other.ILHDBHMAAMO)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Type != other.Type)
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
		if (CEEGGCPPAFJ != 0)
		{
			num ^= CEEGGCPPAFJ.GetHashCode();
		}
		if (ILHDBHMAAMO != 0)
		{
			num ^= ILHDBHMAAMO.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Type != MovieRacingType.PkhiclehjklHnkdhpkcgeo)
		{
			num ^= Type.GetHashCode();
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
		if (CEEGGCPPAFJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CEEGGCPPAFJ);
		}
		if (ILHDBHMAAMO != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ILHDBHMAAMO);
		}
		if (Level != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Level);
		}
		if (Type != MovieRacingType.PkhiclehjklHnkdhpkcgeo)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Type);
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
		if (CEEGGCPPAFJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEEGGCPPAFJ);
		}
		if (ILHDBHMAAMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILHDBHMAAMO);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Type != MovieRacingType.PkhiclehjklHnkdhpkcgeo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BNIGIAJOPGC other)
	{
		if (other != null)
		{
			if (other.CEEGGCPPAFJ != 0)
			{
				CEEGGCPPAFJ = other.CEEGGCPPAFJ;
			}
			if (other.ILHDBHMAAMO != 0)
			{
				ILHDBHMAAMO = other.ILHDBHMAAMO;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Type != MovieRacingType.PkhiclehjklHnkdhpkcgeo)
			{
				Type = other.Type;
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
				CEEGGCPPAFJ = input.ReadUInt32();
				break;
			case 48u:
				ILHDBHMAAMO = input.ReadUInt32();
				break;
			case 104u:
				Level = input.ReadUInt32();
				break;
			case 112u:
				Type = (MovieRacingType)input.ReadEnum();
				break;
			}
		}
	}
}
