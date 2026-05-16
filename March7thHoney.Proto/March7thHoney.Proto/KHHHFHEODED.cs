using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHHHFHEODED : IMessage<KHHHFHEODED>, IMessage, IEquatable<KHHHFHEODED>, IDeepCloneable<KHHHFHEODED>, IBufferMessage
{
	private static readonly MessageParser<KHHHFHEODED> _parser = new MessageParser<KHHHFHEODED>(() => new KHHHFHEODED());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 3;

	private uint uniqueId_;

	public const int LLNNPGEOFCDFieldNumber = 7;

	private EIPPGFCFJEO lLNNPGEOFCD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHHHFHEODED> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHHHFHEODEDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EIPPGFCFJEO LLNNPGEOFCD
	{
		get
		{
			return lLNNPGEOFCD_;
		}
		set
		{
			lLNNPGEOFCD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED(KHHHFHEODED other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		lLNNPGEOFCD_ = ((other.lLNNPGEOFCD_ != null) ? other.lLNNPGEOFCD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHHHFHEODED Clone()
	{
		return new KHHHFHEODED(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHHHFHEODED);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHHHFHEODED other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(LLNNPGEOFCD, other.LLNNPGEOFCD))
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (lLNNPGEOFCD_ != null)
		{
			num ^= LLNNPGEOFCD.GetHashCode();
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
		if (UniqueId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(UniqueId);
		}
		if (lLNNPGEOFCD_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(LLNNPGEOFCD);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (lLNNPGEOFCD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LLNNPGEOFCD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KHHHFHEODED other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.lLNNPGEOFCD_ != null)
		{
			if (lLNNPGEOFCD_ == null)
			{
				LLNNPGEOFCD = new EIPPGFCFJEO();
			}
			LLNNPGEOFCD.MergeFrom(other.LLNNPGEOFCD);
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
			case 24u:
				UniqueId = input.ReadUInt32();
				break;
			case 58u:
				if (lLNNPGEOFCD_ == null)
				{
					LLNNPGEOFCD = new EIPPGFCFJEO();
				}
				input.ReadMessage(LLNNPGEOFCD);
				break;
			}
		}
	}
}
