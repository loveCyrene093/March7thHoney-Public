using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DEOMNEOMPFE : IMessage<DEOMNEOMPFE>, IMessage, IEquatable<DEOMNEOMPFE>, IDeepCloneable<DEOMNEOMPFE>, IBufferMessage
{
	private static readonly MessageParser<DEOMNEOMPFE> _parser = new MessageParser<DEOMNEOMPFE>(() => new DEOMNEOMPFE());

	private UnknownFieldSet _unknownFields;

	public const int NJKEOGNHENKFieldNumber = 4;

	private uint nJKEOGNHENK_;

	public const int LevelFieldNumber = 5;

	private uint level_;

	public const int IsPerfectFieldNumber = 8;

	private bool isPerfect_;

	public const int ILHDBHMAAMOFieldNumber = 12;

	private uint iLHDBHMAAMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DEOMNEOMPFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DEOMNEOMPFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NJKEOGNHENK
	{
		get
		{
			return nJKEOGNHENK_;
		}
		set
		{
			nJKEOGNHENK_ = value;
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
	public bool IsPerfect
	{
		get
		{
			return isPerfect_;
		}
		set
		{
			isPerfect_ = value;
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
	public DEOMNEOMPFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEOMNEOMPFE(DEOMNEOMPFE other)
		: this()
	{
		nJKEOGNHENK_ = other.nJKEOGNHENK_;
		level_ = other.level_;
		isPerfect_ = other.isPerfect_;
		iLHDBHMAAMO_ = other.iLHDBHMAAMO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEOMNEOMPFE Clone()
	{
		return new DEOMNEOMPFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DEOMNEOMPFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DEOMNEOMPFE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NJKEOGNHENK != other.NJKEOGNHENK)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (IsPerfect != other.IsPerfect)
		{
			return false;
		}
		if (ILHDBHMAAMO != other.ILHDBHMAAMO)
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
		if (NJKEOGNHENK != 0)
		{
			num ^= NJKEOGNHENK.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (IsPerfect)
		{
			num ^= IsPerfect.GetHashCode();
		}
		if (ILHDBHMAAMO != 0)
		{
			num ^= ILHDBHMAAMO.GetHashCode();
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
		if (NJKEOGNHENK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(NJKEOGNHENK);
		}
		if (Level != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Level);
		}
		if (IsPerfect)
		{
			output.WriteRawTag(64);
			output.WriteBool(IsPerfect);
		}
		if (ILHDBHMAAMO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ILHDBHMAAMO);
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
		if (NJKEOGNHENK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NJKEOGNHENK);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (IsPerfect)
		{
			num += 2;
		}
		if (ILHDBHMAAMO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILHDBHMAAMO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DEOMNEOMPFE other)
	{
		if (other != null)
		{
			if (other.NJKEOGNHENK != 0)
			{
				NJKEOGNHENK = other.NJKEOGNHENK;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.IsPerfect)
			{
				IsPerfect = other.IsPerfect;
			}
			if (other.ILHDBHMAAMO != 0)
			{
				ILHDBHMAAMO = other.ILHDBHMAAMO;
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
			case 32u:
				NJKEOGNHENK = input.ReadUInt32();
				break;
			case 40u:
				Level = input.ReadUInt32();
				break;
			case 64u:
				IsPerfect = input.ReadBool();
				break;
			case 96u:
				ILHDBHMAAMO = input.ReadUInt32();
				break;
			}
		}
	}
}
