using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFAHMBOGMAN : IMessage<DFAHMBOGMAN>, IMessage, IEquatable<DFAHMBOGMAN>, IDeepCloneable<DFAHMBOGMAN>, IBufferMessage
{
	private static readonly MessageParser<DFAHMBOGMAN> _parser = new MessageParser<DFAHMBOGMAN>(() => new DFAHMBOGMAN());

	private UnknownFieldSet _unknownFields;

	public const int CKOOKFNBPAFFieldNumber = 10;

	private HEHMFNLHOJI cKOOKFNBPAF_;

	public const int QueuePositionFieldNumber = 14;

	private uint queuePosition_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFAHMBOGMAN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFAHMBOGMANReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEHMFNLHOJI CKOOKFNBPAF
	{
		get
		{
			return cKOOKFNBPAF_;
		}
		set
		{
			cKOOKFNBPAF_ = value;
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
	public DFAHMBOGMAN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAHMBOGMAN(DFAHMBOGMAN other)
		: this()
	{
		cKOOKFNBPAF_ = ((other.cKOOKFNBPAF_ != null) ? other.cKOOKFNBPAF_.Clone() : null);
		queuePosition_ = other.queuePosition_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFAHMBOGMAN Clone()
	{
		return new DFAHMBOGMAN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFAHMBOGMAN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFAHMBOGMAN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CKOOKFNBPAF, other.CKOOKFNBPAF))
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
		if (cKOOKFNBPAF_ != null)
		{
			num ^= CKOOKFNBPAF.GetHashCode();
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
		if (cKOOKFNBPAF_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(CKOOKFNBPAF);
		}
		if (QueuePosition != 0)
		{
			output.WriteRawTag(112);
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
		if (cKOOKFNBPAF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CKOOKFNBPAF);
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
	public void MergeFrom(DFAHMBOGMAN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cKOOKFNBPAF_ != null)
		{
			if (cKOOKFNBPAF_ == null)
			{
				CKOOKFNBPAF = new HEHMFNLHOJI();
			}
			CKOOKFNBPAF.MergeFrom(other.CKOOKFNBPAF);
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
			case 82u:
				if (cKOOKFNBPAF_ == null)
				{
					CKOOKFNBPAF = new HEHMFNLHOJI();
				}
				input.ReadMessage(CKOOKFNBPAF);
				break;
			case 112u:
				QueuePosition = input.ReadUInt32();
				break;
			}
		}
	}
}
