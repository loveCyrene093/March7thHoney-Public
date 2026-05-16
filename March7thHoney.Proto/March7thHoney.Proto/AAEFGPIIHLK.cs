using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AAEFGPIIHLK : IMessage<AAEFGPIIHLK>, IMessage, IEquatable<AAEFGPIIHLK>, IDeepCloneable<AAEFGPIIHLK>, IBufferMessage
{
	private static readonly MessageParser<AAEFGPIIHLK> _parser = new MessageParser<AAEFGPIIHLK>(() => new AAEFGPIIHLK());

	private UnknownFieldSet _unknownFields;

	public const int MOOOPAMBOFKFieldNumber = 1;

	private uint mOOOPAMBOFK_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int DDAOBFJFMLLFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_dDAOBFJFMLL_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> dDAOBFJFMLL_ = new RepeatedField<uint>();

	public const int NBBHIHAOLJEFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_nBBHIHAOLJE_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> nBBHIHAOLJE_ = new RepeatedField<uint>();

	public const int ExpFieldNumber = 13;

	private uint exp_;

	public const int LGHOOKMNMCLFieldNumber = 15;

	private uint lGHOOKMNMCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AAEFGPIIHLK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AAEFGPIIHLKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOOOPAMBOFK
	{
		get
		{
			return mOOOPAMBOFK_;
		}
		set
		{
			mOOOPAMBOFK_ = value;
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
	public RepeatedField<uint> DDAOBFJFMLL => dDAOBFJFMLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NBBHIHAOLJE => nBBHIHAOLJE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAEFGPIIHLK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAEFGPIIHLK(AAEFGPIIHLK other)
		: this()
	{
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		level_ = other.level_;
		dDAOBFJFMLL_ = other.dDAOBFJFMLL_.Clone();
		nBBHIHAOLJE_ = other.nBBHIHAOLJE_.Clone();
		exp_ = other.exp_;
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AAEFGPIIHLK Clone()
	{
		return new AAEFGPIIHLK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AAEFGPIIHLK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AAEFGPIIHLK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (!dDAOBFJFMLL_.Equals(other.dDAOBFJFMLL_))
		{
			return false;
		}
		if (!nBBHIHAOLJE_.Equals(other.nBBHIHAOLJE_))
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
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
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		num ^= dDAOBFJFMLL_.GetHashCode();
		num ^= nBBHIHAOLJE_.GetHashCode();
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
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
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		dDAOBFJFMLL_.WriteTo(ref output, _repeated_dDAOBFJFMLL_codec);
		nBBHIHAOLJE_.WriteTo(ref output, _repeated_nBBHIHAOLJE_codec);
		if (Exp != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Exp);
		}
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(LGHOOKMNMCL);
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
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		num += dDAOBFJFMLL_.CalculateSize(_repeated_dDAOBFJFMLL_codec);
		num += nBBHIHAOLJE_.CalculateSize(_repeated_nBBHIHAOLJE_codec);
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AAEFGPIIHLK other)
	{
		if (other != null)
		{
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			dDAOBFJFMLL_.Add(other.dDAOBFJFMLL_);
			nBBHIHAOLJE_.Add(other.nBBHIHAOLJE_);
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
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
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				dDAOBFJFMLL_.AddEntriesFrom(ref input, _repeated_dDAOBFJFMLL_codec);
				break;
			case 88u:
			case 90u:
				nBBHIHAOLJE_.AddEntriesFrom(ref input, _repeated_nBBHIHAOLJE_codec);
				break;
			case 104u:
				Exp = input.ReadUInt32();
				break;
			case 120u:
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			}
		}
	}
}
