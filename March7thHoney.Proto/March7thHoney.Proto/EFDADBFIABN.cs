using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EFDADBFIABN : IMessage<EFDADBFIABN>, IMessage, IEquatable<EFDADBFIABN>, IDeepCloneable<EFDADBFIABN>, IBufferMessage
{
	private static readonly MessageParser<EFDADBFIABN> _parser = new MessageParser<EFDADBFIABN>(() => new EFDADBFIABN());

	private UnknownFieldSet _unknownFields;

	public const int NALNNBECBPAFieldNumber = 2;

	private IDHCKCDAEBA nALNNBECBPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EFDADBFIABN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EFDADBFIABNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDHCKCDAEBA NALNNBECBPA
	{
		get
		{
			return nALNNBECBPA_;
		}
		set
		{
			nALNNBECBPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFDADBFIABN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFDADBFIABN(EFDADBFIABN other)
		: this()
	{
		nALNNBECBPA_ = ((other.nALNNBECBPA_ != null) ? other.nALNNBECBPA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFDADBFIABN Clone()
	{
		return new EFDADBFIABN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EFDADBFIABN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EFDADBFIABN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(NALNNBECBPA, other.NALNNBECBPA))
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
		if (nALNNBECBPA_ != null)
		{
			num ^= NALNNBECBPA.GetHashCode();
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
		if (nALNNBECBPA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(NALNNBECBPA);
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
		if (nALNNBECBPA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(NALNNBECBPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EFDADBFIABN other)
	{
		if (other == null)
		{
			return;
		}
		if (other.nALNNBECBPA_ != null)
		{
			if (nALNNBECBPA_ == null)
			{
				NALNNBECBPA = new IDHCKCDAEBA();
			}
			NALNNBECBPA.MergeFrom(other.NALNNBECBPA);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (nALNNBECBPA_ == null)
			{
				NALNNBECBPA = new IDHCKCDAEBA();
			}
			input.ReadMessage(NALNNBECBPA);
		}
	}
}
