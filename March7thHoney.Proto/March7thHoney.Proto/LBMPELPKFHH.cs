using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBMPELPKFHH : IMessage<LBMPELPKFHH>, IMessage, IEquatable<LBMPELPKFHH>, IDeepCloneable<LBMPELPKFHH>, IBufferMessage
{
	private static readonly MessageParser<LBMPELPKFHH> _parser = new MessageParser<LBMPELPKFHH>(() => new LBMPELPKFHH());

	private UnknownFieldSet _unknownFields;

	public const int NCONIGHJEDIFieldNumber = 1;

	private static readonly FieldCodec<NNKJBNNANJK> _repeated_nCONIGHJEDI_codec = FieldCodec.ForMessage(10u, NNKJBNNANJK.Parser);

	private readonly RepeatedField<NNKJBNNANJK> nCONIGHJEDI_ = new RepeatedField<NNKJBNNANJK>();

	public const int IFCGNOFNDMAFieldNumber = 2;

	private string iFCGNOFNDMA_ = "";

	public const int DebugExtraInfoFieldNumber = 3;

	private string debugExtraInfo_ = "";

	public const int BKLOAECPOEDFieldNumber = 4;

	private static readonly FieldCodec<CCLGJGDLADE> _repeated_bKLOAECPOED_codec = FieldCodec.ForMessage(34u, CCLGJGDLADE.Parser);

	private readonly RepeatedField<CCLGJGDLADE> bKLOAECPOED_ = new RepeatedField<CCLGJGDLADE>();

	public const int PlaneIdFieldNumber = 5;

	private uint planeId_;

	public const int FloorIdFieldNumber = 6;

	private uint floorId_;

	public const int FAPCFAHKKFOFieldNumber = 7;

	private uint fAPCFAHKKFO_;

	public const int BOLNNBOOIOIFieldNumber = 8;

	private uint bOLNNBOOIOI_;

	public const int MEPDPCNHCAEFieldNumber = 9;

	private NNJGJIJEJCL mEPDPCNHCAE_;

	public const int AOJLDOLMEGKFieldNumber = 10;

	private uint aOJLDOLMEGK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBMPELPKFHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBMPELPKFHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NNKJBNNANJK> NCONIGHJEDI => nCONIGHJEDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IFCGNOFNDMA
	{
		get
		{
			return iFCGNOFNDMA_;
		}
		set
		{
			iFCGNOFNDMA_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DebugExtraInfo
	{
		get
		{
			return debugExtraInfo_;
		}
		set
		{
			debugExtraInfo_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCLGJGDLADE> BKLOAECPOED => bKLOAECPOED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FAPCFAHKKFO
	{
		get
		{
			return fAPCFAHKKFO_;
		}
		set
		{
			fAPCFAHKKFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BOLNNBOOIOI
	{
		get
		{
			return bOLNNBOOIOI_;
		}
		set
		{
			bOLNNBOOIOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NNJGJIJEJCL MEPDPCNHCAE
	{
		get
		{
			return mEPDPCNHCAE_;
		}
		set
		{
			mEPDPCNHCAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AOJLDOLMEGK
	{
		get
		{
			return aOJLDOLMEGK_;
		}
		set
		{
			aOJLDOLMEGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPELPKFHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPELPKFHH(LBMPELPKFHH other)
		: this()
	{
		nCONIGHJEDI_ = other.nCONIGHJEDI_.Clone();
		iFCGNOFNDMA_ = other.iFCGNOFNDMA_;
		debugExtraInfo_ = other.debugExtraInfo_;
		bKLOAECPOED_ = other.bKLOAECPOED_.Clone();
		planeId_ = other.planeId_;
		floorId_ = other.floorId_;
		fAPCFAHKKFO_ = other.fAPCFAHKKFO_;
		bOLNNBOOIOI_ = other.bOLNNBOOIOI_;
		mEPDPCNHCAE_ = ((other.mEPDPCNHCAE_ != null) ? other.mEPDPCNHCAE_.Clone() : null);
		aOJLDOLMEGK_ = other.aOJLDOLMEGK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBMPELPKFHH Clone()
	{
		return new LBMPELPKFHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBMPELPKFHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBMPELPKFHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nCONIGHJEDI_.Equals(other.nCONIGHJEDI_))
		{
			return false;
		}
		if (IFCGNOFNDMA != other.IFCGNOFNDMA)
		{
			return false;
		}
		if (DebugExtraInfo != other.DebugExtraInfo)
		{
			return false;
		}
		if (!bKLOAECPOED_.Equals(other.bKLOAECPOED_))
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
		{
			return false;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (FAPCFAHKKFO != other.FAPCFAHKKFO)
		{
			return false;
		}
		if (BOLNNBOOIOI != other.BOLNNBOOIOI)
		{
			return false;
		}
		if (!object.Equals(MEPDPCNHCAE, other.MEPDPCNHCAE))
		{
			return false;
		}
		if (AOJLDOLMEGK != other.AOJLDOLMEGK)
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
		num ^= nCONIGHJEDI_.GetHashCode();
		if (IFCGNOFNDMA.Length != 0)
		{
			num ^= IFCGNOFNDMA.GetHashCode();
		}
		if (DebugExtraInfo.Length != 0)
		{
			num ^= DebugExtraInfo.GetHashCode();
		}
		num ^= bKLOAECPOED_.GetHashCode();
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
		}
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (FAPCFAHKKFO != 0)
		{
			num ^= FAPCFAHKKFO.GetHashCode();
		}
		if (BOLNNBOOIOI != 0)
		{
			num ^= BOLNNBOOIOI.GetHashCode();
		}
		if (mEPDPCNHCAE_ != null)
		{
			num ^= MEPDPCNHCAE.GetHashCode();
		}
		if (AOJLDOLMEGK != 0)
		{
			num ^= AOJLDOLMEGK.GetHashCode();
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
		nCONIGHJEDI_.WriteTo(ref output, _repeated_nCONIGHJEDI_codec);
		if (IFCGNOFNDMA.Length != 0)
		{
			output.WriteRawTag(18);
			output.WriteString(IFCGNOFNDMA);
		}
		if (DebugExtraInfo.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(DebugExtraInfo);
		}
		bKLOAECPOED_.WriteTo(ref output, _repeated_bKLOAECPOED_codec);
		if (PlaneId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PlaneId);
		}
		if (FloorId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(FloorId);
		}
		if (FAPCFAHKKFO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FAPCFAHKKFO);
		}
		if (BOLNNBOOIOI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BOLNNBOOIOI);
		}
		if (mEPDPCNHCAE_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MEPDPCNHCAE);
		}
		if (AOJLDOLMEGK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AOJLDOLMEGK);
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
		num += nCONIGHJEDI_.CalculateSize(_repeated_nCONIGHJEDI_codec);
		if (IFCGNOFNDMA.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(IFCGNOFNDMA);
		}
		if (DebugExtraInfo.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DebugExtraInfo);
		}
		num += bKLOAECPOED_.CalculateSize(_repeated_bKLOAECPOED_codec);
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (FAPCFAHKKFO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FAPCFAHKKFO);
		}
		if (BOLNNBOOIOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BOLNNBOOIOI);
		}
		if (mEPDPCNHCAE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MEPDPCNHCAE);
		}
		if (AOJLDOLMEGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AOJLDOLMEGK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBMPELPKFHH other)
	{
		if (other == null)
		{
			return;
		}
		nCONIGHJEDI_.Add(other.nCONIGHJEDI_);
		if (other.IFCGNOFNDMA.Length != 0)
		{
			IFCGNOFNDMA = other.IFCGNOFNDMA;
		}
		if (other.DebugExtraInfo.Length != 0)
		{
			DebugExtraInfo = other.DebugExtraInfo;
		}
		bKLOAECPOED_.Add(other.bKLOAECPOED_);
		if (other.PlaneId != 0)
		{
			PlaneId = other.PlaneId;
		}
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		if (other.FAPCFAHKKFO != 0)
		{
			FAPCFAHKKFO = other.FAPCFAHKKFO;
		}
		if (other.BOLNNBOOIOI != 0)
		{
			BOLNNBOOIOI = other.BOLNNBOOIOI;
		}
		if (other.mEPDPCNHCAE_ != null)
		{
			if (mEPDPCNHCAE_ == null)
			{
				MEPDPCNHCAE = new NNJGJIJEJCL();
			}
			MEPDPCNHCAE.MergeFrom(other.MEPDPCNHCAE);
		}
		if (other.AOJLDOLMEGK != 0)
		{
			AOJLDOLMEGK = other.AOJLDOLMEGK;
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
			case 10u:
				nCONIGHJEDI_.AddEntriesFrom(ref input, _repeated_nCONIGHJEDI_codec);
				break;
			case 18u:
				IFCGNOFNDMA = input.ReadString();
				break;
			case 26u:
				DebugExtraInfo = input.ReadString();
				break;
			case 34u:
				bKLOAECPOED_.AddEntriesFrom(ref input, _repeated_bKLOAECPOED_codec);
				break;
			case 40u:
				PlaneId = input.ReadUInt32();
				break;
			case 48u:
				FloorId = input.ReadUInt32();
				break;
			case 56u:
				FAPCFAHKKFO = input.ReadUInt32();
				break;
			case 64u:
				BOLNNBOOIOI = input.ReadUInt32();
				break;
			case 74u:
				if (mEPDPCNHCAE_ == null)
				{
					MEPDPCNHCAE = new NNJGJIJEJCL();
				}
				input.ReadMessage(MEPDPCNHCAE);
				break;
			case 80u:
				AOJLDOLMEGK = input.ReadUInt32();
				break;
			}
		}
	}
}
