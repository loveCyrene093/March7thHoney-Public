using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCPPEBGEKHC : IMessage<JCPPEBGEKHC>, IMessage, IEquatable<JCPPEBGEKHC>, IDeepCloneable<JCPPEBGEKHC>, IBufferMessage
{
	private static readonly MessageParser<JCPPEBGEKHC> _parser = new MessageParser<JCPPEBGEKHC>(() => new JCPPEBGEKHC());

	private UnknownFieldSet _unknownFields;

	public const int DOAOPBBIGPOFieldNumber = 1;

	private uint dOAOPBBIGPO_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int TotalDamageFieldNumber = 3;

	private double totalDamage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCPPEBGEKHC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCPPEBGEKHCReflection.Descriptor.MessageTypes[0];

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
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCPPEBGEKHC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCPPEBGEKHC(JCPPEBGEKHC other)
		: this()
	{
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		level_ = other.level_;
		totalDamage_ = other.totalDamage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCPPEBGEKHC Clone()
	{
		return new JCPPEBGEKHC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCPPEBGEKHC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCPPEBGEKHC other)
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
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
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
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
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
			output.WriteRawTag(8);
			output.WriteUInt32(DOAOPBBIGPO);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(TotalDamage);
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
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCPPEBGEKHC other)
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
			if (other.TotalDamage != 0.0)
			{
				TotalDamage = other.TotalDamage;
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
				DOAOPBBIGPO = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 25u:
				TotalDamage = input.ReadDouble();
				break;
			}
		}
	}
}
