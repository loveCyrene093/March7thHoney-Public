using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DAPDOHOADDB : IMessage<DAPDOHOADDB>, IMessage, IEquatable<DAPDOHOADDB>, IDeepCloneable<DAPDOHOADDB>, IBufferMessage
{
	private static readonly MessageParser<DAPDOHOADDB> _parser = new MessageParser<DAPDOHOADDB>(() => new DAPDOHOADDB());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 4;

	private uint pos_;

	public const int NLOCDHMLGJHFieldNumber = 8;

	private uint nLOCDHMLGJH_;

	public const int CountFieldNumber = 9;

	private uint count_;

	public const int BOFOOKJCJGGFieldNumber = 11;

	private uint bOFOOKJCJGG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DAPDOHOADDB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DAPDOHOADDBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOFOOKJCJGG
	{
		get
		{
			return bOFOOKJCJGG_;
		}
		set
		{
			bOFOOKJCJGG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAPDOHOADDB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAPDOHOADDB(DAPDOHOADDB other)
		: this()
	{
		pos_ = other.pos_;
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		count_ = other.count_;
		bOFOOKJCJGG_ = other.bOFOOKJCJGG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DAPDOHOADDB Clone()
	{
		return new DAPDOHOADDB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DAPDOHOADDB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DAPDOHOADDB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (BOFOOKJCJGG != other.BOFOOKJCJGG)
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
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (BOFOOKJCJGG != 0)
		{
			num ^= BOFOOKJCJGG.GetHashCode();
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
		if (Pos != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Pos);
		}
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		if (Count != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Count);
		}
		if (BOFOOKJCJGG != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BOFOOKJCJGG);
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
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (BOFOOKJCJGG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOFOOKJCJGG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DAPDOHOADDB other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
			}
			if (other.Count != 0)
			{
				Count = other.Count;
			}
			if (other.BOFOOKJCJGG != 0)
			{
				BOFOOKJCJGG = other.BOFOOKJCJGG;
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
				Pos = input.ReadUInt32();
				break;
			case 64u:
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 72u:
				Count = input.ReadUInt32();
				break;
			case 88u:
				BOFOOKJCJGG = input.ReadUInt32();
				break;
			}
		}
	}
}
