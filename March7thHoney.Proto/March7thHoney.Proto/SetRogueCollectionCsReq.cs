using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetRogueCollectionCsReq : IMessage<SetRogueCollectionCsReq>, IMessage, IEquatable<SetRogueCollectionCsReq>, IDeepCloneable<SetRogueCollectionCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetRogueCollectionCsReq> _parser = new MessageParser<SetRogueCollectionCsReq>(() => new SetRogueCollectionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HJNAAMBAJMEFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_hJNAAMBAJME_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> hJNAAMBAJME_ = new RepeatedField<uint>();

	public const int PFJFFEFEBANFieldNumber = 5;

	private static readonly FieldCodec<AGLNLHOBDKI> _repeated_pFJFFEFEBAN_codec = FieldCodec.ForEnum(42u, (AGLNLHOBDKI x) => (int)x, (int x) => (AGLNLHOBDKI)x);

	private readonly RepeatedField<AGLNLHOBDKI> pFJFFEFEBAN_ = new RepeatedField<AGLNLHOBDKI>();

	public const int BCIIJGGJKHBFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_bCIIJGGJKHB_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> bCIIJGGJKHB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetRogueCollectionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetRogueCollectionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HJNAAMBAJME => hJNAAMBAJME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AGLNLHOBDKI> PFJFFEFEBAN => pFJFFEFEBAN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BCIIJGGJKHB => bCIIJGGJKHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionCsReq(SetRogueCollectionCsReq other)
		: this()
	{
		hJNAAMBAJME_ = other.hJNAAMBAJME_.Clone();
		pFJFFEFEBAN_ = other.pFJFFEFEBAN_.Clone();
		bCIIJGGJKHB_ = other.bCIIJGGJKHB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetRogueCollectionCsReq Clone()
	{
		return new SetRogueCollectionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetRogueCollectionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetRogueCollectionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hJNAAMBAJME_.Equals(other.hJNAAMBAJME_))
		{
			return false;
		}
		if (!pFJFFEFEBAN_.Equals(other.pFJFFEFEBAN_))
		{
			return false;
		}
		if (!bCIIJGGJKHB_.Equals(other.bCIIJGGJKHB_))
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
		num ^= hJNAAMBAJME_.GetHashCode();
		num ^= pFJFFEFEBAN_.GetHashCode();
		num ^= bCIIJGGJKHB_.GetHashCode();
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
		hJNAAMBAJME_.WriteTo(ref output, _repeated_hJNAAMBAJME_codec);
		pFJFFEFEBAN_.WriteTo(ref output, _repeated_pFJFFEFEBAN_codec);
		bCIIJGGJKHB_.WriteTo(ref output, _repeated_bCIIJGGJKHB_codec);
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
		num += hJNAAMBAJME_.CalculateSize(_repeated_hJNAAMBAJME_codec);
		num += pFJFFEFEBAN_.CalculateSize(_repeated_pFJFFEFEBAN_codec);
		num += bCIIJGGJKHB_.CalculateSize(_repeated_bCIIJGGJKHB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetRogueCollectionCsReq other)
	{
		if (other != null)
		{
			hJNAAMBAJME_.Add(other.hJNAAMBAJME_);
			pFJFFEFEBAN_.Add(other.pFJFFEFEBAN_);
			bCIIJGGJKHB_.Add(other.bCIIJGGJKHB_);
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
			case 8u:
			case 10u:
				hJNAAMBAJME_.AddEntriesFrom(ref input, _repeated_hJNAAMBAJME_codec);
				break;
			case 40u:
			case 42u:
				pFJFFEFEBAN_.AddEntriesFrom(ref input, _repeated_pFJFFEFEBAN_codec);
				break;
			case 88u:
			case 90u:
				bCIIJGGJKHB_.AddEntriesFrom(ref input, _repeated_bCIIJGGJKHB_codec);
				break;
			}
		}
	}
}
