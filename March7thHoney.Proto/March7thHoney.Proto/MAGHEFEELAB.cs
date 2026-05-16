using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MAGHEFEELAB : IMessage<MAGHEFEELAB>, IMessage, IEquatable<MAGHEFEELAB>, IDeepCloneable<MAGHEFEELAB>, IBufferMessage
{
	private static readonly MessageParser<MAGHEFEELAB> _parser = new MessageParser<MAGHEFEELAB>(() => new MAGHEFEELAB());

	private UnknownFieldSet _unknownFields;

	public const int EJOMFAHEMNHFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_eJOMFAHEMNH_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> eJOMFAHEMNH_ = new RepeatedField<uint>();

	public const int RecordInfoFieldNumber = 3;

	private JEBLAAGCNHN recordInfo_;

	public const int ADKBEOPNBIOFieldNumber = 4;

	private bool aDKBEOPNBIO_;

	public const int AreaIdFieldNumber = 9;

	private uint areaId_;

	public const int GFNCKBGNLNCFieldNumber = 12;

	private uint gFNCKBGNLNC_;

	public const int IsTakenRewardFieldNumber = 13;

	private bool isTakenReward_;

	public const int ECCGJDMOGANFieldNumber = 14;

	private OGNJNBBBPIF eCCGJDMOGAN_;

	public const int CEBPAJAAJPPFieldNumber = 15;

	private bool cEBPAJAAJPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MAGHEFEELAB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MAGHEFEELABReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EJOMFAHEMNH => eJOMFAHEMNH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEBLAAGCNHN RecordInfo
	{
		get
		{
			return recordInfo_;
		}
		set
		{
			recordInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ADKBEOPNBIO
	{
		get
		{
			return aDKBEOPNBIO_;
		}
		set
		{
			aDKBEOPNBIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFNCKBGNLNC
	{
		get
		{
			return gFNCKBGNLNC_;
		}
		set
		{
			gFNCKBGNLNC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsTakenReward
	{
		get
		{
			return isTakenReward_;
		}
		set
		{
			isTakenReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGNJNBBBPIF ECCGJDMOGAN
	{
		get
		{
			return eCCGJDMOGAN_;
		}
		set
		{
			eCCGJDMOGAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CEBPAJAAJPP
	{
		get
		{
			return cEBPAJAAJPP_;
		}
		set
		{
			cEBPAJAAJPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGHEFEELAB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGHEFEELAB(MAGHEFEELAB other)
		: this()
	{
		eJOMFAHEMNH_ = other.eJOMFAHEMNH_.Clone();
		recordInfo_ = ((other.recordInfo_ != null) ? other.recordInfo_.Clone() : null);
		aDKBEOPNBIO_ = other.aDKBEOPNBIO_;
		areaId_ = other.areaId_;
		gFNCKBGNLNC_ = other.gFNCKBGNLNC_;
		isTakenReward_ = other.isTakenReward_;
		eCCGJDMOGAN_ = ((other.eCCGJDMOGAN_ != null) ? other.eCCGJDMOGAN_.Clone() : null);
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MAGHEFEELAB Clone()
	{
		return new MAGHEFEELAB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MAGHEFEELAB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MAGHEFEELAB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!eJOMFAHEMNH_.Equals(other.eJOMFAHEMNH_))
		{
			return false;
		}
		if (!object.Equals(RecordInfo, other.RecordInfo))
		{
			return false;
		}
		if (ADKBEOPNBIO != other.ADKBEOPNBIO)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (GFNCKBGNLNC != other.GFNCKBGNLNC)
		{
			return false;
		}
		if (IsTakenReward != other.IsTakenReward)
		{
			return false;
		}
		if (!object.Equals(ECCGJDMOGAN, other.ECCGJDMOGAN))
		{
			return false;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
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
		num ^= eJOMFAHEMNH_.GetHashCode();
		if (recordInfo_ != null)
		{
			num ^= RecordInfo.GetHashCode();
		}
		if (ADKBEOPNBIO)
		{
			num ^= ADKBEOPNBIO.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (GFNCKBGNLNC != 0)
		{
			num ^= GFNCKBGNLNC.GetHashCode();
		}
		if (IsTakenReward)
		{
			num ^= IsTakenReward.GetHashCode();
		}
		if (eCCGJDMOGAN_ != null)
		{
			num ^= ECCGJDMOGAN.GetHashCode();
		}
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
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
		eJOMFAHEMNH_.WriteTo(ref output, _repeated_eJOMFAHEMNH_codec);
		if (recordInfo_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RecordInfo);
		}
		if (ADKBEOPNBIO)
		{
			output.WriteRawTag(32);
			output.WriteBool(ADKBEOPNBIO);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AreaId);
		}
		if (GFNCKBGNLNC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GFNCKBGNLNC);
		}
		if (IsTakenReward)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsTakenReward);
		}
		if (eCCGJDMOGAN_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(ECCGJDMOGAN);
		}
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(120);
			output.WriteBool(CEBPAJAAJPP);
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
		num += eJOMFAHEMNH_.CalculateSize(_repeated_eJOMFAHEMNH_codec);
		if (recordInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RecordInfo);
		}
		if (ADKBEOPNBIO)
		{
			num += 2;
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (GFNCKBGNLNC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFNCKBGNLNC);
		}
		if (IsTakenReward)
		{
			num += 2;
		}
		if (eCCGJDMOGAN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ECCGJDMOGAN);
		}
		if (CEBPAJAAJPP)
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
	public void MergeFrom(MAGHEFEELAB other)
	{
		if (other == null)
		{
			return;
		}
		eJOMFAHEMNH_.Add(other.eJOMFAHEMNH_);
		if (other.recordInfo_ != null)
		{
			if (recordInfo_ == null)
			{
				RecordInfo = new JEBLAAGCNHN();
			}
			RecordInfo.MergeFrom(other.RecordInfo);
		}
		if (other.ADKBEOPNBIO)
		{
			ADKBEOPNBIO = other.ADKBEOPNBIO;
		}
		if (other.AreaId != 0)
		{
			AreaId = other.AreaId;
		}
		if (other.GFNCKBGNLNC != 0)
		{
			GFNCKBGNLNC = other.GFNCKBGNLNC;
		}
		if (other.IsTakenReward)
		{
			IsTakenReward = other.IsTakenReward;
		}
		if (other.eCCGJDMOGAN_ != null)
		{
			if (eCCGJDMOGAN_ == null)
			{
				ECCGJDMOGAN = new OGNJNBBBPIF();
			}
			ECCGJDMOGAN.MergeFrom(other.ECCGJDMOGAN);
		}
		if (other.CEBPAJAAJPP)
		{
			CEBPAJAAJPP = other.CEBPAJAAJPP;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 16u:
			case 18u:
				eJOMFAHEMNH_.AddEntriesFrom(ref input, _repeated_eJOMFAHEMNH_codec);
				break;
			case 26u:
				if (recordInfo_ == null)
				{
					RecordInfo = new JEBLAAGCNHN();
				}
				input.ReadMessage(RecordInfo);
				break;
			case 32u:
				ADKBEOPNBIO = input.ReadBool();
				break;
			case 72u:
				AreaId = input.ReadUInt32();
				break;
			case 96u:
				GFNCKBGNLNC = input.ReadUInt32();
				break;
			case 104u:
				IsTakenReward = input.ReadBool();
				break;
			case 114u:
				if (eCCGJDMOGAN_ == null)
				{
					ECCGJDMOGAN = new OGNJNBBBPIF();
				}
				input.ReadMessage(ECCGJDMOGAN);
				break;
			case 120u:
				CEBPAJAAJPP = input.ReadBool();
				break;
			}
		}
	}
}
