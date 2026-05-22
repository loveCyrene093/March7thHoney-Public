using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BCJFAIHEBEM : IMessage<BCJFAIHEBEM>, IMessage, IEquatable<BCJFAIHEBEM>, IDeepCloneable<BCJFAIHEBEM>, IBufferMessage
{
	private static readonly MessageParser<BCJFAIHEBEM> _parser = new MessageParser<BCJFAIHEBEM>(() => new BCJFAIHEBEM());

	private UnknownFieldSet _unknownFields;

	public const int KHHNOHPEOIAFieldNumber = 2;

	private static readonly FieldCodec<BMOEEKGCJAD> _repeated_kHHNOHPEOIA_codec = FieldCodec.ForMessage(18u, BMOEEKGCJAD.Parser);

	private readonly RepeatedField<BMOEEKGCJAD> kHHNOHPEOIA_ = new RepeatedField<BMOEEKGCJAD>();

	public const int AHGEKIBPHLDFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_aHGEKIBPHLD_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> aHGEKIBPHLD_ = new RepeatedField<uint>();

	public const int ADILPIMEOADFieldNumber = 10;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_aDILPIMEOAD_codec = FieldCodec.ForMessage(82u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> aDILPIMEOAD_ = new RepeatedField<GKDEKJKOIJN>();

	public const int GridFightEquipmentListFieldNumber = 15;

	private static readonly FieldCodec<BMOEEKGCJAD> _repeated_gridFightEquipmentList_codec = FieldCodec.ForMessage(122u, BMOEEKGCJAD.Parser);

	private readonly RepeatedField<BMOEEKGCJAD> gridFightEquipmentList_ = new RepeatedField<BMOEEKGCJAD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BCJFAIHEBEM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BCJFAIHEBEMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BMOEEKGCJAD> KHHNOHPEOIA => kHHNOHPEOIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AHGEKIBPHLD => aHGEKIBPHLD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> ADILPIMEOAD => aDILPIMEOAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BMOEEKGCJAD> GridFightEquipmentList => gridFightEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCJFAIHEBEM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCJFAIHEBEM(BCJFAIHEBEM other)
		: this()
	{
		kHHNOHPEOIA_ = other.kHHNOHPEOIA_.Clone();
		aHGEKIBPHLD_ = other.aHGEKIBPHLD_.Clone();
		aDILPIMEOAD_ = other.aDILPIMEOAD_.Clone();
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BCJFAIHEBEM Clone()
	{
		return new BCJFAIHEBEM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BCJFAIHEBEM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BCJFAIHEBEM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kHHNOHPEOIA_.Equals(other.kHHNOHPEOIA_))
		{
			return false;
		}
		if (!aHGEKIBPHLD_.Equals(other.aHGEKIBPHLD_))
		{
			return false;
		}
		if (!aDILPIMEOAD_.Equals(other.aDILPIMEOAD_))
		{
			return false;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
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
		num ^= kHHNOHPEOIA_.GetHashCode();
		num ^= aHGEKIBPHLD_.GetHashCode();
		num ^= aDILPIMEOAD_.GetHashCode();
		num ^= gridFightEquipmentList_.GetHashCode();
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
		kHHNOHPEOIA_.WriteTo(ref output, _repeated_kHHNOHPEOIA_codec);
		aHGEKIBPHLD_.WriteTo(ref output, _repeated_aHGEKIBPHLD_codec);
		aDILPIMEOAD_.WriteTo(ref output, _repeated_aDILPIMEOAD_codec);
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
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
		num += kHHNOHPEOIA_.CalculateSize(_repeated_kHHNOHPEOIA_codec);
		num += aHGEKIBPHLD_.CalculateSize(_repeated_aHGEKIBPHLD_codec);
		num += aDILPIMEOAD_.CalculateSize(_repeated_aDILPIMEOAD_codec);
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BCJFAIHEBEM other)
	{
		if (other != null)
		{
			kHHNOHPEOIA_.Add(other.kHHNOHPEOIA_);
			aHGEKIBPHLD_.Add(other.aHGEKIBPHLD_);
			aDILPIMEOAD_.Add(other.aDILPIMEOAD_);
			gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
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
			case 18u:
				kHHNOHPEOIA_.AddEntriesFrom(ref input, _repeated_kHHNOHPEOIA_codec);
				break;
			case 48u:
			case 50u:
				aHGEKIBPHLD_.AddEntriesFrom(ref input, _repeated_aHGEKIBPHLD_codec);
				break;
			case 82u:
				aDILPIMEOAD_.AddEntriesFrom(ref input, _repeated_aDILPIMEOAD_codec);
				break;
			case 122u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			}
		}
	}
}
