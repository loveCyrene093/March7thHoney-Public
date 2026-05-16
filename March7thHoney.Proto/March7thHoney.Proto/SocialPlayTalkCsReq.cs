using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SocialPlayTalkCsReq : IMessage<SocialPlayTalkCsReq>, IMessage, IEquatable<SocialPlayTalkCsReq>, IDeepCloneable<SocialPlayTalkCsReq>, IBufferMessage
{
	private static readonly MessageParser<SocialPlayTalkCsReq> _parser = new MessageParser<SocialPlayTalkCsReq>(() => new SocialPlayTalkCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NGPGKFELCEDFieldNumber = 12;

	private GFLKDHPBAMJ nGPGKFELCED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SocialPlayTalkCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SocialPlayTalkCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFLKDHPBAMJ NGPGKFELCED
	{
		get
		{
			return nGPGKFELCED_;
		}
		set
		{
			nGPGKFELCED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkCsReq(SocialPlayTalkCsReq other)
		: this()
	{
		nGPGKFELCED_ = ((other.nGPGKFELCED_ != null) ? other.nGPGKFELCED_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialPlayTalkCsReq Clone()
	{
		return new SocialPlayTalkCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SocialPlayTalkCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SocialPlayTalkCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NGPGKFELCED, other.NGPGKFELCED))
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
		if (nGPGKFELCED_ != null)
		{
			num ^= NGPGKFELCED.GetHashCode();
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
		if (nGPGKFELCED_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(NGPGKFELCED);
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
		if (nGPGKFELCED_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NGPGKFELCED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SocialPlayTalkCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nGPGKFELCED_ != null)
		{
			if (nGPGKFELCED_ == null)
			{
				NGPGKFELCED = new GFLKDHPBAMJ();
			}
			NGPGKFELCED.MergeFrom(other.NGPGKFELCED);
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
			if (num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nGPGKFELCED_ == null)
			{
				NGPGKFELCED = new GFLKDHPBAMJ();
			}
			input.ReadMessage(NGPGKFELCED);
		}
	}
}
