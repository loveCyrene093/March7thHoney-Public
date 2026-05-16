using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncRogueHandbookDataUpdateScNotify : IMessage<SyncRogueHandbookDataUpdateScNotify>, IMessage, IEquatable<SyncRogueHandbookDataUpdateScNotify>, IDeepCloneable<SyncRogueHandbookDataUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncRogueHandbookDataUpdateScNotify> _parser = new MessageParser<SyncRogueHandbookDataUpdateScNotify>(() => new SyncRogueHandbookDataUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LJCKMEPACIDFieldNumber = 1;

	private static readonly FieldCodec<NJINCNAGALP> _repeated_lJCKMEPACID_codec = FieldCodec.ForMessage(10u, NJINCNAGALP.Parser);

	private readonly RepeatedField<NJINCNAGALP> lJCKMEPACID_ = new RepeatedField<NJINCNAGALP>();

	public const int HECHKEBKAJKFieldNumber = 4;

	private static readonly FieldCodec<PHDKMFDPABI> _repeated_hECHKEBKAJK_codec = FieldCodec.ForMessage(34u, PHDKMFDPABI.Parser);

	private readonly RepeatedField<PHDKMFDPABI> hECHKEBKAJK_ = new RepeatedField<PHDKMFDPABI>();

	public const int FFBNIHFGKENFieldNumber = 5;

	private static readonly FieldCodec<AKEKHLAEKBC> _repeated_fFBNIHFGKEN_codec = FieldCodec.ForMessage(42u, AKEKHLAEKBC.Parser);

	private readonly RepeatedField<AKEKHLAEKBC> fFBNIHFGKEN_ = new RepeatedField<AKEKHLAEKBC>();

	public const int FNMJMOIIDGCFieldNumber = 8;

	private static readonly FieldCodec<PNCBGGJKKAF> _repeated_fNMJMOIIDGC_codec = FieldCodec.ForMessage(66u, PNCBGGJKKAF.Parser);

	private readonly RepeatedField<PNCBGGJKKAF> fNMJMOIIDGC_ = new RepeatedField<PNCBGGJKKAF>();

	public const int FJNDFOHIJDPFieldNumber = 15;

	private static readonly FieldCodec<JABFAOAIEIG> _repeated_fJNDFOHIJDP_codec = FieldCodec.ForMessage(122u, JABFAOAIEIG.Parser);

	private readonly RepeatedField<JABFAOAIEIG> fJNDFOHIJDP_ = new RepeatedField<JABFAOAIEIG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncRogueHandbookDataUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncRogueHandbookDataUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NJINCNAGALP> LJCKMEPACID => lJCKMEPACID_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PHDKMFDPABI> HECHKEBKAJK => hECHKEBKAJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AKEKHLAEKBC> FFBNIHFGKEN => fFBNIHFGKEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PNCBGGJKKAF> FNMJMOIIDGC => fNMJMOIIDGC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JABFAOAIEIG> FJNDFOHIJDP => fJNDFOHIJDP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueHandbookDataUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueHandbookDataUpdateScNotify(SyncRogueHandbookDataUpdateScNotify other)
		: this()
	{
		lJCKMEPACID_ = other.lJCKMEPACID_.Clone();
		hECHKEBKAJK_ = other.hECHKEBKAJK_.Clone();
		fFBNIHFGKEN_ = other.fFBNIHFGKEN_.Clone();
		fNMJMOIIDGC_ = other.fNMJMOIIDGC_.Clone();
		fJNDFOHIJDP_ = other.fJNDFOHIJDP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncRogueHandbookDataUpdateScNotify Clone()
	{
		return new SyncRogueHandbookDataUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncRogueHandbookDataUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncRogueHandbookDataUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lJCKMEPACID_.Equals(other.lJCKMEPACID_))
		{
			return false;
		}
		if (!hECHKEBKAJK_.Equals(other.hECHKEBKAJK_))
		{
			return false;
		}
		if (!fFBNIHFGKEN_.Equals(other.fFBNIHFGKEN_))
		{
			return false;
		}
		if (!fNMJMOIIDGC_.Equals(other.fNMJMOIIDGC_))
		{
			return false;
		}
		if (!fJNDFOHIJDP_.Equals(other.fJNDFOHIJDP_))
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
		num ^= lJCKMEPACID_.GetHashCode();
		num ^= hECHKEBKAJK_.GetHashCode();
		num ^= fFBNIHFGKEN_.GetHashCode();
		num ^= fNMJMOIIDGC_.GetHashCode();
		num ^= fJNDFOHIJDP_.GetHashCode();
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
		lJCKMEPACID_.WriteTo(ref output, _repeated_lJCKMEPACID_codec);
		hECHKEBKAJK_.WriteTo(ref output, _repeated_hECHKEBKAJK_codec);
		fFBNIHFGKEN_.WriteTo(ref output, _repeated_fFBNIHFGKEN_codec);
		fNMJMOIIDGC_.WriteTo(ref output, _repeated_fNMJMOIIDGC_codec);
		fJNDFOHIJDP_.WriteTo(ref output, _repeated_fJNDFOHIJDP_codec);
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
		num += lJCKMEPACID_.CalculateSize(_repeated_lJCKMEPACID_codec);
		num += hECHKEBKAJK_.CalculateSize(_repeated_hECHKEBKAJK_codec);
		num += fFBNIHFGKEN_.CalculateSize(_repeated_fFBNIHFGKEN_codec);
		num += fNMJMOIIDGC_.CalculateSize(_repeated_fNMJMOIIDGC_codec);
		num += fJNDFOHIJDP_.CalculateSize(_repeated_fJNDFOHIJDP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncRogueHandbookDataUpdateScNotify other)
	{
		if (other != null)
		{
			lJCKMEPACID_.Add(other.lJCKMEPACID_);
			hECHKEBKAJK_.Add(other.hECHKEBKAJK_);
			fFBNIHFGKEN_.Add(other.fFBNIHFGKEN_);
			fNMJMOIIDGC_.Add(other.fNMJMOIIDGC_);
			fJNDFOHIJDP_.Add(other.fJNDFOHIJDP_);
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
			case 10u:
				lJCKMEPACID_.AddEntriesFrom(ref input, _repeated_lJCKMEPACID_codec);
				break;
			case 34u:
				hECHKEBKAJK_.AddEntriesFrom(ref input, _repeated_hECHKEBKAJK_codec);
				break;
			case 42u:
				fFBNIHFGKEN_.AddEntriesFrom(ref input, _repeated_fFBNIHFGKEN_codec);
				break;
			case 66u:
				fNMJMOIIDGC_.AddEntriesFrom(ref input, _repeated_fNMJMOIIDGC_codec);
				break;
			case 122u:
				fJNDFOHIJDP_.AddEntriesFrom(ref input, _repeated_fJNDFOHIJDP_codec);
				break;
			}
		}
	}
}
