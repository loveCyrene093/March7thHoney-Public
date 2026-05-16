using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AJAFOEHDCII : IMessage<AJAFOEHDCII>, IMessage, IEquatable<AJAFOEHDCII>, IDeepCloneable<AJAFOEHDCII>, IBufferMessage
{
	private static readonly MessageParser<AJAFOEHDCII> _parser = new MessageParser<AJAFOEHDCII>(() => new AJAFOEHDCII());

	private UnknownFieldSet _unknownFields;

	public const int KKKBCPGOFLBFieldNumber = 9;

	private LGOPLIAFLCK kKKBCPGOFLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AJAFOEHDCII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AJAFOEHDCIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LGOPLIAFLCK KKKBCPGOFLB
	{
		get
		{
			return kKKBCPGOFLB_;
		}
		set
		{
			kKKBCPGOFLB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJAFOEHDCII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJAFOEHDCII(AJAFOEHDCII other)
		: this()
	{
		kKKBCPGOFLB_ = ((other.kKKBCPGOFLB_ != null) ? other.kKKBCPGOFLB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AJAFOEHDCII Clone()
	{
		return new AJAFOEHDCII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AJAFOEHDCII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AJAFOEHDCII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(KKKBCPGOFLB, other.KKKBCPGOFLB))
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
		if (kKKBCPGOFLB_ != null)
		{
			num ^= KKKBCPGOFLB.GetHashCode();
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
		if (kKKBCPGOFLB_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(KKKBCPGOFLB);
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
		if (kKKBCPGOFLB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKKBCPGOFLB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AJAFOEHDCII other)
	{
		if (other == null)
		{
			return;
		}
		if (other.kKKBCPGOFLB_ != null)
		{
			if (kKKBCPGOFLB_ == null)
			{
				KKKBCPGOFLB = new LGOPLIAFLCK();
			}
			KKKBCPGOFLB.MergeFrom(other.KKKBCPGOFLB);
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
			if (num != 74)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (kKKBCPGOFLB_ == null)
			{
				KKKBCPGOFLB = new LGOPLIAFLCK();
			}
			input.ReadMessage(KKKBCPGOFLB);
		}
	}
}
