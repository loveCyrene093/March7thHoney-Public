using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ILLBNKFBNBP : IMessage<ILLBNKFBNBP>, IMessage, IEquatable<ILLBNKFBNBP>, IDeepCloneable<ILLBNKFBNBP>, IBufferMessage
{
	private static readonly MessageParser<ILLBNKFBNBP> _parser = new MessageParser<ILLBNKFBNBP>(() => new ILLBNKFBNBP());

	private UnknownFieldSet _unknownFields;

	public const int DOAOPBBIGPOFieldNumber = 4;

	private uint dOAOPBBIGPO_;

	public const int LevelFieldNumber = 15;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ILLBNKFBNBP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ILLBNKFBNBPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAOPBBIGPO
	{
		get
		{
			return dOAOPBBIGPO_;
		}
		set
		{
			dOAOPBBIGPO_ = value;
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
	public ILLBNKFBNBP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP(ILLBNKFBNBP other)
		: this()
	{
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP Clone()
	{
		return new ILLBNKFBNBP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ILLBNKFBNBP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ILLBNKFBNBP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DOAOPBBIGPO != other.DOAOPBBIGPO)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (DOAOPBBIGPO != 0)
		{
			num ^= DOAOPBBIGPO.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (DOAOPBBIGPO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DOAOPBBIGPO);
		}
		if (Level != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Level);
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
		if (DOAOPBBIGPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOAOPBBIGPO);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ILLBNKFBNBP other)
	{
		if (other != null)
		{
			if (other.DOAOPBBIGPO != 0)
			{
				DOAOPBBIGPO = other.DOAOPBBIGPO;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
				DOAOPBBIGPO = input.ReadUInt32();
				break;
			case 120u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
