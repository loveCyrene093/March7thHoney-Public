using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EPPJHNIHAFL : IMessage<EPPJHNIHAFL>, IMessage, IEquatable<EPPJHNIHAFL>, IDeepCloneable<EPPJHNIHAFL>, IBufferMessage
{
	private static readonly MessageParser<EPPJHNIHAFL> _parser = new MessageParser<EPPJHNIHAFL>(() => new EPPJHNIHAFL());

	private UnknownFieldSet _unknownFields;

	public const int JPPGFLJHDHKFieldNumber = 5;

	private ICOMMCAJDLI jPPGFLJHDHK_;

	public const int QueuePositionFieldNumber = 12;

	private uint queuePosition_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EPPJHNIHAFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EPPJHNIHAFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICOMMCAJDLI JPPGFLJHDHK
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
	public EPPJHNIHAFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPJHNIHAFL(EPPJHNIHAFL other)
		: this()
	{
		jPPGFLJHDHK_ = ((other.jPPGFLJHDHK_ != null) ? other.jPPGFLJHDHK_.Clone() : null);
		queuePosition_ = other.queuePosition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPPJHNIHAFL Clone()
	{
		return new EPPJHNIHAFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EPPJHNIHAFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EPPJHNIHAFL other)
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
			output.WriteRawTag(42);
			output.WriteMessage(JPPGFLJHDHK);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(96);
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
	public void MergeFrom(EPPJHNIHAFL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jPPGFLJHDHK_ != null)
		{
			if (jPPGFLJHDHK_ == null)
			{
				JPPGFLJHDHK = new ICOMMCAJDLI();
			}
			JPPGFLJHDHK.MergeFrom(other.JPPGFLJHDHK);
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
			case 42u:
				if (jPPGFLJHDHK_ == null)
				{
					JPPGFLJHDHK = new ICOMMCAJDLI();
				}
				input.ReadMessage(JPPGFLJHDHK);
				break;
			case 96u:
				QueuePosition = input.ReadUInt32();
				break;
			}
		}
	}
}
