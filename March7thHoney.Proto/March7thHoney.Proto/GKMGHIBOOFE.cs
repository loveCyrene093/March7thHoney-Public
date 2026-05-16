using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GKMGHIBOOFE : IMessage<GKMGHIBOOFE>, IMessage, IEquatable<GKMGHIBOOFE>, IDeepCloneable<GKMGHIBOOFE>, IBufferMessage
{
	private static readonly MessageParser<GKMGHIBOOFE> _parser = new MessageParser<GKMGHIBOOFE>(() => new GKMGHIBOOFE());

	private UnknownFieldSet _unknownFields;

	public const int KDIDNELEDJDFieldNumber = 4;

	private static readonly FieldCodec<AGAOJNNBALA> _repeated_kDIDNELEDJD_codec = FieldCodec.ForMessage(34u, AGAOJNNBALA.Parser);

	private readonly RepeatedField<AGAOJNNBALA> kDIDNELEDJD_ = new RepeatedField<AGAOJNNBALA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GKMGHIBOOFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GKMGHIBOOFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AGAOJNNBALA> KDIDNELEDJD => kDIDNELEDJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKMGHIBOOFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKMGHIBOOFE(GKMGHIBOOFE other)
		: this()
	{
		kDIDNELEDJD_ = other.kDIDNELEDJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GKMGHIBOOFE Clone()
	{
		return new GKMGHIBOOFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GKMGHIBOOFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GKMGHIBOOFE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kDIDNELEDJD_.Equals(other.kDIDNELEDJD_))
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
		num ^= kDIDNELEDJD_.GetHashCode();
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
		kDIDNELEDJD_.WriteTo(ref output, _repeated_kDIDNELEDJD_codec);
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
		num += kDIDNELEDJD_.CalculateSize(_repeated_kDIDNELEDJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GKMGHIBOOFE other)
	{
		if (other != null)
		{
			kDIDNELEDJD_.Add(other.kDIDNELEDJD_);
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				kDIDNELEDJD_.AddEntriesFrom(ref input, _repeated_kDIDNELEDJD_codec);
			}
		}
	}
}
