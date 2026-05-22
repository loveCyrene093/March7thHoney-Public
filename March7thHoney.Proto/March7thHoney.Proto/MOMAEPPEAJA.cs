using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MOMAEPPEAJA : IMessage<MOMAEPPEAJA>, IMessage, IEquatable<MOMAEPPEAJA>, IDeepCloneable<MOMAEPPEAJA>, IBufferMessage
{
	private static readonly MessageParser<MOMAEPPEAJA> _parser = new MessageParser<MOMAEPPEAJA>(() => new MOMAEPPEAJA());

	private UnknownFieldSet _unknownFields;

	public const int MAONHDCCHPEFieldNumber = 12;

	private NJBHKLCKHBK mAONHDCCHPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MOMAEPPEAJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MOMAEPPEAJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJBHKLCKHBK MAONHDCCHPE
	{
		get
		{
			return mAONHDCCHPE_;
		}
		set
		{
			mAONHDCCHPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOMAEPPEAJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOMAEPPEAJA(MOMAEPPEAJA other)
		: this()
	{
		mAONHDCCHPE_ = ((other.mAONHDCCHPE_ != null) ? other.mAONHDCCHPE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MOMAEPPEAJA Clone()
	{
		return new MOMAEPPEAJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MOMAEPPEAJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MOMAEPPEAJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MAONHDCCHPE, other.MAONHDCCHPE))
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
		if (mAONHDCCHPE_ != null)
		{
			num ^= MAONHDCCHPE.GetHashCode();
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
		if (mAONHDCCHPE_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(MAONHDCCHPE);
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
		if (mAONHDCCHPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MAONHDCCHPE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MOMAEPPEAJA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mAONHDCCHPE_ != null)
		{
			if (mAONHDCCHPE_ == null)
			{
				MAONHDCCHPE = new NJBHKLCKHBK();
			}
			MAONHDCCHPE.MergeFrom(other.MAONHDCCHPE);
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
			if (mAONHDCCHPE_ == null)
			{
				MAONHDCCHPE = new NJBHKLCKHBK();
			}
			input.ReadMessage(MAONHDCCHPE);
		}
	}
}
