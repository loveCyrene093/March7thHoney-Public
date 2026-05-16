using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDBLKOGKHEE : IMessage<KDBLKOGKHEE>, IMessage, IEquatable<KDBLKOGKHEE>, IDeepCloneable<KDBLKOGKHEE>, IBufferMessage
{
	private static readonly MessageParser<KDBLKOGKHEE> _parser = new MessageParser<KDBLKOGKHEE>(() => new KDBLKOGKHEE());

	private UnknownFieldSet _unknownFields;

	public const int DICCEIAFIJBFieldNumber = 2;

	private SwordTrainingDailyPhaseType dICCEIAFIJB_;

	public const int EDKJPBBDCBGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_eDKJPBBDCBG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> eDKJPBBDCBG_ = new RepeatedField<uint>();

	public const int PIGEOFBCNCNFieldNumber = 9;

	private static readonly FieldCodec<DGCGFFLKKAA> _repeated_pIGEOFBCNCN_codec = FieldCodec.ForMessage(74u, DGCGFFLKKAA.Parser);

	private readonly RepeatedField<DGCGFFLKKAA> pIGEOFBCNCN_ = new RepeatedField<DGCGFFLKKAA>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDBLKOGKHEE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDBLKOGKHEEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingDailyPhaseType DICCEIAFIJB
	{
		get
		{
			return dICCEIAFIJB_;
		}
		set
		{
			dICCEIAFIJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EDKJPBBDCBG => eDKJPBBDCBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DGCGFFLKKAA> PIGEOFBCNCN => pIGEOFBCNCN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDBLKOGKHEE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDBLKOGKHEE(KDBLKOGKHEE other)
		: this()
	{
		dICCEIAFIJB_ = other.dICCEIAFIJB_;
		eDKJPBBDCBG_ = other.eDKJPBBDCBG_.Clone();
		pIGEOFBCNCN_ = other.pIGEOFBCNCN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDBLKOGKHEE Clone()
	{
		return new KDBLKOGKHEE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KDBLKOGKHEE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDBLKOGKHEE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DICCEIAFIJB != other.DICCEIAFIJB)
		{
			return false;
		}
		if (!eDKJPBBDCBG_.Equals(other.eDKJPBBDCBG_))
		{
			return false;
		}
		if (!pIGEOFBCNCN_.Equals(other.pIGEOFBCNCN_))
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
		if (DICCEIAFIJB != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			num ^= DICCEIAFIJB.GetHashCode();
		}
		num ^= eDKJPBBDCBG_.GetHashCode();
		num ^= pIGEOFBCNCN_.GetHashCode();
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
		if (DICCEIAFIJB != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)DICCEIAFIJB);
		}
		eDKJPBBDCBG_.WriteTo(ref output, _repeated_eDKJPBBDCBG_codec);
		pIGEOFBCNCN_.WriteTo(ref output, _repeated_pIGEOFBCNCN_codec);
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
		if (DICCEIAFIJB != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)DICCEIAFIJB);
		}
		num += eDKJPBBDCBG_.CalculateSize(_repeated_eDKJPBBDCBG_codec);
		num += pIGEOFBCNCN_.CalculateSize(_repeated_pIGEOFBCNCN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KDBLKOGKHEE other)
	{
		if (other != null)
		{
			if (other.DICCEIAFIJB != SwordTrainingDailyPhaseType.MmkjjkboneaPcpdhelpkem)
			{
				DICCEIAFIJB = other.DICCEIAFIJB;
			}
			eDKJPBBDCBG_.Add(other.eDKJPBBDCBG_);
			pIGEOFBCNCN_.Add(other.pIGEOFBCNCN_);
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
			case 16u:
				DICCEIAFIJB = (SwordTrainingDailyPhaseType)input.ReadEnum();
				break;
			case 32u:
			case 34u:
				eDKJPBBDCBG_.AddEntriesFrom(ref input, _repeated_eDKJPBBDCBG_codec);
				break;
			case 74u:
				pIGEOFBCNCN_.AddEntriesFrom(ref input, _repeated_pIGEOFBCNCN_codec);
				break;
			}
		}
	}
}
