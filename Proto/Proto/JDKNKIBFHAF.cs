using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JDKNKIBFHAF : IMessage<JDKNKIBFHAF>, IMessage, IEquatable<JDKNKIBFHAF>, IDeepCloneable<JDKNKIBFHAF>, IBufferMessage
{
	private static readonly MessageParser<JDKNKIBFHAF> _parser = new MessageParser<JDKNKIBFHAF>(() => new JDKNKIBFHAF());

	private UnknownFieldSet _unknownFields;

	public const int BNMCKIPHPNBFieldNumber = 15;

	private DDEJHBJBMBH bNMCKIPHPNB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JDKNKIBFHAF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JDKNKIBFHAFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDEJHBJBMBH BNMCKIPHPNB
	{
		get
		{
			return bNMCKIPHPNB_;
		}
		set
		{
			bNMCKIPHPNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKNKIBFHAF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKNKIBFHAF(JDKNKIBFHAF other)
		: this()
	{
		bNMCKIPHPNB_ = ((other.bNMCKIPHPNB_ != null) ? other.bNMCKIPHPNB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JDKNKIBFHAF Clone()
	{
		return new JDKNKIBFHAF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JDKNKIBFHAF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JDKNKIBFHAF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BNMCKIPHPNB, other.BNMCKIPHPNB))
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
		if (bNMCKIPHPNB_ != null)
		{
			num ^= BNMCKIPHPNB.GetHashCode();
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
		if (bNMCKIPHPNB_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(BNMCKIPHPNB);
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
		if (bNMCKIPHPNB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BNMCKIPHPNB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JDKNKIBFHAF other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bNMCKIPHPNB_ != null)
		{
			if (bNMCKIPHPNB_ == null)
			{
				BNMCKIPHPNB = new DDEJHBJBMBH();
			}
			BNMCKIPHPNB.MergeFrom(other.BNMCKIPHPNB);
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
			if (num != 122)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (bNMCKIPHPNB_ == null)
			{
				BNMCKIPHPNB = new DDEJHBJBMBH();
			}
			input.ReadMessage(BNMCKIPHPNB);
		}
	}
}
