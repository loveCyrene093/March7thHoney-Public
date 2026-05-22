using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NCHLPKDHEGA : IMessage<NCHLPKDHEGA>, IMessage, IEquatable<NCHLPKDHEGA>, IDeepCloneable<NCHLPKDHEGA>, IBufferMessage
{
	private static readonly MessageParser<NCHLPKDHEGA> _parser = new MessageParser<NCHLPKDHEGA>(() => new NCHLPKDHEGA());

	private UnknownFieldSet _unknownFields;

	public const int DPHOAPPCBHBFieldNumber = 1;

	private uint dPHOAPPCBHB_;

	public const int LevelFieldNumber = 2;

	private uint level_;

	public const int ExpFieldNumber = 3;

	private uint exp_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NCHLPKDHEGA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NCHLPKDHEGAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DPHOAPPCBHB
	{
		get
		{
			return dPHOAPPCBHB_;
		}
		set
		{
			dPHOAPPCBHB_ = value;
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
	public NCHLPKDHEGA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLPKDHEGA(NCHLPKDHEGA other)
		: this()
	{
		dPHOAPPCBHB_ = other.dPHOAPPCBHB_;
		level_ = other.level_;
		exp_ = other.exp_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCHLPKDHEGA Clone()
	{
		return new NCHLPKDHEGA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NCHLPKDHEGA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NCHLPKDHEGA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DPHOAPPCBHB != other.DPHOAPPCBHB)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (Exp != other.Exp)
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
		if (DPHOAPPCBHB != 0)
		{
			num ^= DPHOAPPCBHB.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
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
		if (DPHOAPPCBHB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DPHOAPPCBHB);
		}
		if (Level != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Level);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Exp);
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
		if (DPHOAPPCBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DPHOAPPCBHB);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NCHLPKDHEGA other)
	{
		if (other != null)
		{
			if (other.DPHOAPPCBHB != 0)
			{
				DPHOAPPCBHB = other.DPHOAPPCBHB;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
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
				DPHOAPPCBHB = input.ReadUInt32();
				break;
			case 16u:
				Level = input.ReadUInt32();
				break;
			case 24u:
				Exp = input.ReadUInt32();
				break;
			}
		}
	}
}
