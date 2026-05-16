using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KIEEFAOCOCC : IMessage<KIEEFAOCOCC>, IMessage, IEquatable<KIEEFAOCOCC>, IDeepCloneable<KIEEFAOCOCC>, IBufferMessage
{
	private static readonly MessageParser<KIEEFAOCOCC> _parser = new MessageParser<KIEEFAOCOCC>(() => new KIEEFAOCOCC());

	private UnknownFieldSet _unknownFields;

	public const int MDNOKJEALNPFieldNumber = 1;

	private CGLILDEBBIH mDNOKJEALNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KIEEFAOCOCC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KIEEFAOCOCCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGLILDEBBIH MDNOKJEALNP
	{
		get
		{
			return mDNOKJEALNP_;
		}
		set
		{
			mDNOKJEALNP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEEFAOCOCC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEEFAOCOCC(KIEEFAOCOCC other)
		: this()
	{
		mDNOKJEALNP_ = ((other.mDNOKJEALNP_ != null) ? other.mDNOKJEALNP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KIEEFAOCOCC Clone()
	{
		return new KIEEFAOCOCC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KIEEFAOCOCC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KIEEFAOCOCC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MDNOKJEALNP, other.MDNOKJEALNP))
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
		if (mDNOKJEALNP_ != null)
		{
			num ^= MDNOKJEALNP.GetHashCode();
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
		if (mDNOKJEALNP_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MDNOKJEALNP);
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
		if (mDNOKJEALNP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MDNOKJEALNP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KIEEFAOCOCC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mDNOKJEALNP_ != null)
		{
			if (mDNOKJEALNP_ == null)
			{
				MDNOKJEALNP = new CGLILDEBBIH();
			}
			MDNOKJEALNP.MergeFrom(other.MDNOKJEALNP);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (mDNOKJEALNP_ == null)
			{
				MDNOKJEALNP = new CGLILDEBBIH();
			}
			input.ReadMessage(MDNOKJEALNP);
		}
	}
}
