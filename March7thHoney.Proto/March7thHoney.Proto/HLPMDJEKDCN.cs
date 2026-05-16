using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HLPMDJEKDCN : IMessage<HLPMDJEKDCN>, IMessage, IEquatable<HLPMDJEKDCN>, IDeepCloneable<HLPMDJEKDCN>, IBufferMessage
{
	private static readonly MessageParser<HLPMDJEKDCN> _parser = new MessageParser<HLPMDJEKDCN>(() => new HLPMDJEKDCN());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 5;

	private uint level_;

	public const int INCHLHNKHCHFieldNumber = 7;

	private uint iNCHLHNKHCH_;

	public const int JHINDFPAMNLFieldNumber = 15;

	private uint jHINDFPAMNL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HLPMDJEKDCN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HLPMDJEKDCNReflection.Descriptor.MessageTypes[0];

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
	public uint INCHLHNKHCH
	{
		get
		{
			return iNCHLHNKHCH_;
		}
		set
		{
			iNCHLHNKHCH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHINDFPAMNL
	{
		get
		{
			return jHINDFPAMNL_;
		}
		set
		{
			jHINDFPAMNL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLPMDJEKDCN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLPMDJEKDCN(HLPMDJEKDCN other)
		: this()
	{
		level_ = other.level_;
		iNCHLHNKHCH_ = other.iNCHLHNKHCH_;
		jHINDFPAMNL_ = other.jHINDFPAMNL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLPMDJEKDCN Clone()
	{
		return new HLPMDJEKDCN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HLPMDJEKDCN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HLPMDJEKDCN other)
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
		if (INCHLHNKHCH != other.INCHLHNKHCH)
		{
			return false;
		}
		if (JHINDFPAMNL != other.JHINDFPAMNL)
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
		if (INCHLHNKHCH != 0)
		{
			num ^= INCHLHNKHCH.GetHashCode();
		}
		if (JHINDFPAMNL != 0)
		{
			num ^= JHINDFPAMNL.GetHashCode();
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
			output.WriteRawTag(40);
			output.WriteUInt32(Level);
		}
		if (INCHLHNKHCH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(INCHLHNKHCH);
		}
		if (JHINDFPAMNL != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JHINDFPAMNL);
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
		if (INCHLHNKHCH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INCHLHNKHCH);
		}
		if (JHINDFPAMNL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHINDFPAMNL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HLPMDJEKDCN other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.INCHLHNKHCH != 0)
			{
				INCHLHNKHCH = other.INCHLHNKHCH;
			}
			if (other.JHINDFPAMNL != 0)
			{
				JHINDFPAMNL = other.JHINDFPAMNL;
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
			case 40u:
				Level = input.ReadUInt32();
				break;
			case 56u:
				INCHLHNKHCH = input.ReadUInt32();
				break;
			case 120u:
				JHINDFPAMNL = input.ReadUInt32();
				break;
			}
		}
	}
}
