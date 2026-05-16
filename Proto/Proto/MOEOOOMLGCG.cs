using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MOEOOOMLGCG : IMessage<MOEOOOMLGCG>, IMessage, IEquatable<MOEOOOMLGCG>, IDeepCloneable<MOEOOOMLGCG>, IBufferMessage
{
	private static readonly MessageParser<MOEOOOMLGCG> _parser = new MessageParser<MOEOOOMLGCG>(() => new MOEOOOMLGCG());

	private UnknownFieldSet _unknownFields;

	public const int JPPGFLJHDHKFieldNumber = 1;

	private DFAGKMFOENB jPPGFLJHDHK_;

	public const int SourceFieldNumber = 4;

	private KCFFOHMDHCK source_;

	public const int QueuePositionFieldNumber = 10;

	private uint queuePosition_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MOEOOOMLGCG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MOEOOOMLGCGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAGKMFOENB JPPGFLJHDHK
	{
		get
		{
			return jPPGFLJHDHK_;
		}
		set
		{
			jPPGFLJHDHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KCFFOHMDHCK Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
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
	public MOEOOOMLGCG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOEOOOMLGCG(MOEOOOMLGCG other)
		: this()
	{
		jPPGFLJHDHK_ = ((other.jPPGFLJHDHK_ != null) ? other.jPPGFLJHDHK_.Clone() : null);
		source_ = other.source_;
		queuePosition_ = other.queuePosition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOEOOOMLGCG Clone()
	{
		return new MOEOOOMLGCG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MOEOOOMLGCG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MOEOOOMLGCG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JPPGFLJHDHK, other.JPPGFLJHDHK))
		{
			return false;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (QueuePosition != other.QueuePosition)
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
		if (jPPGFLJHDHK_ != null)
		{
			num ^= JPPGFLJHDHK.GetHashCode();
		}
		if (Source != KCFFOHMDHCK.Pcpdhelpkem)
		{
			num ^= Source.GetHashCode();
		}
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
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
		if (jPPGFLJHDHK_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JPPGFLJHDHK);
		}
		if (Source != KCFFOHMDHCK.Pcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Source);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(QueuePosition);
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
		if (jPPGFLJHDHK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JPPGFLJHDHK);
		}
		if (Source != KCFFOHMDHCK.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MOEOOOMLGCG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jPPGFLJHDHK_ != null)
		{
			if (jPPGFLJHDHK_ == null)
			{
				JPPGFLJHDHK = new DFAGKMFOENB();
			}
			JPPGFLJHDHK.MergeFrom(other.JPPGFLJHDHK);
		}
		if (other.Source != KCFFOHMDHCK.Pcpdhelpkem)
		{
			Source = other.Source;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (jPPGFLJHDHK_ == null)
				{
					JPPGFLJHDHK = new DFAGKMFOENB();
				}
				input.ReadMessage(JPPGFLJHDHK);
				break;
			case 32u:
				Source = (KCFFOHMDHCK)input.ReadEnum();
				break;
			case 80u:
				QueuePosition = input.ReadUInt32();
				break;
			}
		}
	}
}
