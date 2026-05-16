using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PunkLordMonsterInfoScNotify : IMessage<PunkLordMonsterInfoScNotify>, IMessage, IEquatable<PunkLordMonsterInfoScNotify>, IDeepCloneable<PunkLordMonsterInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<PunkLordMonsterInfoScNotify> _parser = new MessageParser<PunkLordMonsterInfoScNotify>(() => new PunkLordMonsterInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 7;

	private INPBGNJMNKJ reason_;

	public const int BasicInfoFieldNumber = 8;

	private PunkLordMonsterBasicInfo basicInfo_;

	public const int FHPOILIMKIIFieldNumber = 11;

	private PHOCECJOBHH fHPOILIMKII_;

	public const int GDBIIMNJLBAFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_gDBIIMNJLBA_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> gDBIIMNJLBA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PunkLordMonsterInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PunkLordMonsterInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public INPBGNJMNKJ Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterBasicInfo BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHOCECJOBHH FHPOILIMKII
	{
		get
		{
			return fHPOILIMKII_;
		}
		set
		{
			fHPOILIMKII_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GDBIIMNJLBA => gDBIIMNJLBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterInfoScNotify(PunkLordMonsterInfoScNotify other)
		: this()
	{
		reason_ = other.reason_;
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		fHPOILIMKII_ = ((other.fHPOILIMKII_ != null) ? other.fHPOILIMKII_.Clone() : null);
		gDBIIMNJLBA_ = other.gDBIIMNJLBA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PunkLordMonsterInfoScNotify Clone()
	{
		return new PunkLordMonsterInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PunkLordMonsterInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PunkLordMonsterInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (!object.Equals(FHPOILIMKII, other.FHPOILIMKII))
		{
			return false;
		}
		if (!gDBIIMNJLBA_.Equals(other.gDBIIMNJLBA_))
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
		if (Reason != INPBGNJMNKJ.Pcpdhelpkem)
		{
			num ^= Reason.GetHashCode();
		}
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (fHPOILIMKII_ != null)
		{
			num ^= FHPOILIMKII.GetHashCode();
		}
		num ^= gDBIIMNJLBA_.GetHashCode();
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
		if (Reason != INPBGNJMNKJ.Pcpdhelpkem)
		{
			output.WriteRawTag(56);
			output.WriteEnum((int)Reason);
		}
		if (basicInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(BasicInfo);
		}
		if (fHPOILIMKII_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FHPOILIMKII);
		}
		gDBIIMNJLBA_.WriteTo(ref output, _repeated_gDBIIMNJLBA_codec);
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
		if (Reason != INPBGNJMNKJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (fHPOILIMKII_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHPOILIMKII);
		}
		num += gDBIIMNJLBA_.CalculateSize(_repeated_gDBIIMNJLBA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PunkLordMonsterInfoScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Reason != INPBGNJMNKJ.Pcpdhelpkem)
		{
			Reason = other.Reason;
		}
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new PunkLordMonsterBasicInfo();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		if (other.fHPOILIMKII_ != null)
		{
			if (fHPOILIMKII_ == null)
			{
				FHPOILIMKII = new PHOCECJOBHH();
			}
			FHPOILIMKII.MergeFrom(other.FHPOILIMKII);
		}
		gDBIIMNJLBA_.Add(other.gDBIIMNJLBA_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 56u:
				Reason = (INPBGNJMNKJ)input.ReadEnum();
				break;
			case 66u:
				if (basicInfo_ == null)
				{
					BasicInfo = new PunkLordMonsterBasicInfo();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 90u:
				if (fHPOILIMKII_ == null)
				{
					FHPOILIMKII = new PHOCECJOBHH();
				}
				input.ReadMessage(FHPOILIMKII);
				break;
			case 96u:
			case 98u:
				gDBIIMNJLBA_.AddEntriesFrom(ref input, _repeated_gDBIIMNJLBA_codec);
				break;
			}
		}
	}
}
