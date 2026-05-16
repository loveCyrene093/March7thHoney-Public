using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HPMJCOCCBJJ : IMessage<HPMJCOCCBJJ>, IMessage, IEquatable<HPMJCOCCBJJ>, IDeepCloneable<HPMJCOCCBJJ>, IBufferMessage
{
	private static readonly MessageParser<HPMJCOCCBJJ> _parser = new MessageParser<HPMJCOCCBJJ>(() => new HPMJCOCCBJJ());

	private UnknownFieldSet _unknownFields;

	public const int CCNHIHHGBDPFieldNumber = 14;

	private PINBJNLCIAH cCNHIHHGBDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HPMJCOCCBJJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HPMJCOCCBJJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PINBJNLCIAH CCNHIHHGBDP
	{
		get
		{
			return cCNHIHHGBDP_;
		}
		set
		{
			cCNHIHHGBDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPMJCOCCBJJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPMJCOCCBJJ(HPMJCOCCBJJ other)
		: this()
	{
		cCNHIHHGBDP_ = ((other.cCNHIHHGBDP_ != null) ? other.cCNHIHHGBDP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HPMJCOCCBJJ Clone()
	{
		return new HPMJCOCCBJJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HPMJCOCCBJJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HPMJCOCCBJJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CCNHIHHGBDP, other.CCNHIHHGBDP))
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
		if (cCNHIHHGBDP_ != null)
		{
			num ^= CCNHIHHGBDP.GetHashCode();
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
		if (cCNHIHHGBDP_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(CCNHIHHGBDP);
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
		if (cCNHIHHGBDP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CCNHIHHGBDP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HPMJCOCCBJJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.cCNHIHHGBDP_ != null)
		{
			if (cCNHIHHGBDP_ == null)
			{
				CCNHIHHGBDP = new PINBJNLCIAH();
			}
			CCNHIHHGBDP.MergeFrom(other.CCNHIHHGBDP);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (cCNHIHHGBDP_ == null)
			{
				CCNHIHHGBDP = new PINBJNLCIAH();
			}
			input.ReadMessage(CCNHIHHGBDP);
		}
	}
}
