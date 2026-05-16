using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJDBHCKMLIL : IMessage<MJDBHCKMLIL>, IMessage, IEquatable<MJDBHCKMLIL>, IDeepCloneable<MJDBHCKMLIL>, IBufferMessage
{
	private static readonly MessageParser<MJDBHCKMLIL> _parser = new MessageParser<MJDBHCKMLIL>(() => new MJDBHCKMLIL());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 10;

	private uint level_;

	public const int CIDDJKPGMDIFieldNumber = 11;

	private PONPHHDBEJJ cIDDJKPGMDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJDBHCKMLIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJDBHCKMLILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public PONPHHDBEJJ CIDDJKPGMDI
	{
		get
		{
			return cIDDJKPGMDI_;
		}
		set
		{
			cIDDJKPGMDI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJDBHCKMLIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJDBHCKMLIL(MJDBHCKMLIL other)
		: this()
	{
		level_ = other.level_;
		cIDDJKPGMDI_ = other.cIDDJKPGMDI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJDBHCKMLIL Clone()
	{
		return new MJDBHCKMLIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJDBHCKMLIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJDBHCKMLIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (CIDDJKPGMDI != other.CIDDJKPGMDI)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (CIDDJKPGMDI != PONPHHDBEJJ.Oeglclnjkec)
		{
			num ^= CIDDJKPGMDI.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Level);
		}
		if (CIDDJKPGMDI != PONPHHDBEJJ.Oeglclnjkec)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)CIDDJKPGMDI);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (CIDDJKPGMDI != PONPHHDBEJJ.Oeglclnjkec)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CIDDJKPGMDI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJDBHCKMLIL other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.CIDDJKPGMDI != PONPHHDBEJJ.Oeglclnjkec)
			{
				CIDDJKPGMDI = other.CIDDJKPGMDI;
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
			case 80u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				CIDDJKPGMDI = (PONPHHDBEJJ)input.ReadEnum();
				break;
			}
		}
	}
}
