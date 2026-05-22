using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GeneralVirtualItemDataNotify : IMessage<GeneralVirtualItemDataNotify>, IMessage, IEquatable<GeneralVirtualItemDataNotify>, IDeepCloneable<GeneralVirtualItemDataNotify>, IBufferMessage
{
	private static readonly MessageParser<GeneralVirtualItemDataNotify> _parser = new MessageParser<GeneralVirtualItemDataNotify>(() => new GeneralVirtualItemDataNotify());

	private UnknownFieldSet _unknownFields;

	public const int KCJCBBKKCGIFieldNumber = 3;

	private static readonly FieldCodec<PileItem> _repeated_kCJCBBKKCGI_codec = FieldCodec.ForMessage(26u, PileItem.Parser);

	private readonly RepeatedField<PileItem> kCJCBBKKCGI_ = new RepeatedField<PileItem>();

	public const int NONMONPHBPEFieldNumber = 13;

	private bool nONMONPHBPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GeneralVirtualItemDataNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GeneralVirtualItemDataNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PileItem> KCJCBBKKCGI => kCJCBBKKCGI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NONMONPHBPE
	{
		get
		{
			return nONMONPHBPE_;
		}
		set
		{
			nONMONPHBPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GeneralVirtualItemDataNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GeneralVirtualItemDataNotify(GeneralVirtualItemDataNotify other)
		: this()
	{
		kCJCBBKKCGI_ = other.kCJCBBKKCGI_.Clone();
		nONMONPHBPE_ = other.nONMONPHBPE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GeneralVirtualItemDataNotify Clone()
	{
		return new GeneralVirtualItemDataNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GeneralVirtualItemDataNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GeneralVirtualItemDataNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kCJCBBKKCGI_.Equals(other.kCJCBBKKCGI_))
		{
			return false;
		}
		if (NONMONPHBPE != other.NONMONPHBPE)
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
		num ^= kCJCBBKKCGI_.GetHashCode();
		if (NONMONPHBPE)
		{
			num ^= NONMONPHBPE.GetHashCode();
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
		kCJCBBKKCGI_.WriteTo(ref output, _repeated_kCJCBBKKCGI_codec);
		if (NONMONPHBPE)
		{
			output.WriteRawTag(104);
			output.WriteBool(NONMONPHBPE);
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
		num += kCJCBBKKCGI_.CalculateSize(_repeated_kCJCBBKKCGI_codec);
		if (NONMONPHBPE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GeneralVirtualItemDataNotify other)
	{
		if (other != null)
		{
			kCJCBBKKCGI_.Add(other.kCJCBBKKCGI_);
			if (other.NONMONPHBPE)
			{
				NONMONPHBPE = other.NONMONPHBPE;
			}
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				kCJCBBKKCGI_.AddEntriesFrom(ref input, _repeated_kCJCBBKKCGI_codec);
				break;
			case 104u:
				NONMONPHBPE = input.ReadBool();
				break;
			}
		}
	}
}
