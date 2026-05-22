using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPFOHPLLOIJ : IMessage<DPFOHPLLOIJ>, IMessage, IEquatable<DPFOHPLLOIJ>, IDeepCloneable<DPFOHPLLOIJ>, IBufferMessage
{
	private static readonly MessageParser<DPFOHPLLOIJ> _parser = new MessageParser<DPFOHPLLOIJ>(() => new DPFOHPLLOIJ());

	private UnknownFieldSet _unknownFields;

	public const int QueuePositionFieldNumber = 2;

	private uint queuePosition_;

	public const int JPPGFLJHDHKFieldNumber = 13;

	private FDCENFPKJMO jPPGFLJHDHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPFOHPLLOIJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPFOHPLLOIJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FDCENFPKJMO JPPGFLJHDHK
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
	public DPFOHPLLOIJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFOHPLLOIJ(DPFOHPLLOIJ other)
		: this()
	{
		queuePosition_ = other.queuePosition_;
		jPPGFLJHDHK_ = ((other.jPPGFLJHDHK_ != null) ? other.jPPGFLJHDHK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPFOHPLLOIJ Clone()
	{
		return new DPFOHPLLOIJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPFOHPLLOIJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPFOHPLLOIJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (QueuePosition != other.QueuePosition)
		{
			return false;
		}
		if (!object.Equals(JPPGFLJHDHK, other.JPPGFLJHDHK))
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
		if (QueuePosition != 0)
		{
			num ^= QueuePosition.GetHashCode();
		}
		if (jPPGFLJHDHK_ != null)
		{
			num ^= JPPGFLJHDHK.GetHashCode();
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
		if (QueuePosition != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(QueuePosition);
		}
		if (jPPGFLJHDHK_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(JPPGFLJHDHK);
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
		if (QueuePosition != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QueuePosition);
		}
		if (jPPGFLJHDHK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JPPGFLJHDHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPFOHPLLOIJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.QueuePosition != 0)
		{
			QueuePosition = other.QueuePosition;
		}
		if (other.jPPGFLJHDHK_ != null)
		{
			if (jPPGFLJHDHK_ == null)
			{
				JPPGFLJHDHK = new FDCENFPKJMO();
			}
			JPPGFLJHDHK.MergeFrom(other.JPPGFLJHDHK);
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
			case 16u:
				QueuePosition = input.ReadUInt32();
				break;
			case 106u:
				if (jPPGFLJHDHK_ == null)
				{
					JPPGFLJHDHK = new FDCENFPKJMO();
				}
				input.ReadMessage(JPPGFLJHDHK);
				break;
			}
		}
	}
}
