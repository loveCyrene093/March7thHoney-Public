using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ONJIOJDEECD : IMessage<ONJIOJDEECD>, IMessage, IEquatable<ONJIOJDEECD>, IDeepCloneable<ONJIOJDEECD>, IBufferMessage
{
	private static readonly MessageParser<ONJIOJDEECD> _parser = new MessageParser<ONJIOJDEECD>(() => new ONJIOJDEECD());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 9;

	private uint level_;

	public const int QueuePositionFieldNumber = 11;

	private uint queuePosition_;

	public const int JODGDFEEHOPFieldNumber = 13;

	private uint jODGDFEEHOP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ONJIOJDEECD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ONJIOJDEECDReflection.Descriptor.MessageTypes[0];

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
	public uint QueuePosition
	{
		get
		{
			return queuePosition_;
		}
		set
		{
			queuePosition_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JODGDFEEHOP
	{
		get
		{
			return jODGDFEEHOP_;
		}
		set
		{
			jODGDFEEHOP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONJIOJDEECD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONJIOJDEECD(ONJIOJDEECD other)
		: this()
	{
		level_ = other.level_;
		queuePosition_ = other.queuePosition_;
		jODGDFEEHOP_ = other.jODGDFEEHOP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ONJIOJDEECD Clone()
	{
		return new ONJIOJDEECD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ONJIOJDEECD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ONJIOJDEECD other)
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
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (JODGDFEEHOP != other.JODGDFEEHOP)
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (JODGDFEEHOP != 0)
		{
			num ^= JODGDFEEHOP.GetHashCode();
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
			output.WriteRawTag(72);
			output.WriteUInt32(Level);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(QueuePosition);
		}
		if (JODGDFEEHOP != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JODGDFEEHOP);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (JODGDFEEHOP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JODGDFEEHOP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ONJIOJDEECD other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.QueuePosition != 0)
			{
				QueuePosition = other.QueuePosition;
			}
			if (other.JODGDFEEHOP != 0)
			{
				JODGDFEEHOP = other.JODGDFEEHOP;
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
			case 72u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				QueuePosition = input.ReadUInt32();
				break;
			case 104u:
				JODGDFEEHOP = input.ReadUInt32();
				break;
			}
		}
	}
}
