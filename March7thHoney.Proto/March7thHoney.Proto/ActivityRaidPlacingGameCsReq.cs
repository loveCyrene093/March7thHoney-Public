using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivityRaidPlacingGameCsReq : IMessage<ActivityRaidPlacingGameCsReq>, IMessage, IEquatable<ActivityRaidPlacingGameCsReq>, IDeepCloneable<ActivityRaidPlacingGameCsReq>, IBufferMessage
{
	public enum DLOMKFLEEICOneofCase
	{
		None = 0,
		MFMHHAPPPJJ = 1,
		OBPNDKPPFGG = 12
	}

	private static readonly MessageParser<ActivityRaidPlacingGameCsReq> _parser = new MessageParser<ActivityRaidPlacingGameCsReq>(() => new ActivityRaidPlacingGameCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FCDCFAMOHAEFieldNumber = 11;

	private AlleyPlacingShip fCDCFAMOHAE_;

	public const int MFMHHAPPPJJFieldNumber = 1;

	public const int OBPNDKPPFGGFieldNumber = 12;

	private object dLOMKFLEEIC_;

	private DLOMKFLEEICOneofCase dLOMKFLEEICCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivityRaidPlacingGameCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ActivityRaidPlacingGameCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AlleyPlacingShip FCDCFAMOHAE
	{
		get
		{
			return fCDCFAMOHAE_;
		}
		set
		{
			fCDCFAMOHAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFMHHAPPPJJ
	{
		get
		{
			if (!HasMFMHHAPPPJJ)
			{
				return 0u;
			}
			return (uint)dLOMKFLEEIC_;
		}
		set
		{
			dLOMKFLEEIC_ = value;
			dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.MFMHHAPPPJJ;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMFMHHAPPPJJ => dLOMKFLEEICCase_ == DLOMKFLEEICOneofCase.MFMHHAPPPJJ;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OBPNDKPPFGG
	{
		get
		{
			if (!HasOBPNDKPPFGG)
			{
				return 0u;
			}
			return (uint)dLOMKFLEEIC_;
		}
		set
		{
			dLOMKFLEEIC_ = value;
			dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.OBPNDKPPFGG;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOBPNDKPPFGG => dLOMKFLEEICCase_ == DLOMKFLEEICOneofCase.OBPNDKPPFGG;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLOMKFLEEICOneofCase DLOMKFLEEICCase => dLOMKFLEEICCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameCsReq(ActivityRaidPlacingGameCsReq other)
		: this()
	{
		fCDCFAMOHAE_ = ((other.fCDCFAMOHAE_ != null) ? other.fCDCFAMOHAE_.Clone() : null);
		switch (other.DLOMKFLEEICCase)
		{
		case DLOMKFLEEICOneofCase.MFMHHAPPPJJ:
			MFMHHAPPPJJ = other.MFMHHAPPPJJ;
			break;
		case DLOMKFLEEICOneofCase.OBPNDKPPFGG:
			OBPNDKPPFGG = other.OBPNDKPPFGG;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityRaidPlacingGameCsReq Clone()
	{
		return new ActivityRaidPlacingGameCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearMFMHHAPPPJJ()
	{
		if (HasMFMHHAPPPJJ)
		{
			ClearDLOMKFLEEIC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearOBPNDKPPFGG()
	{
		if (HasOBPNDKPPFGG)
		{
			ClearDLOMKFLEEIC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDLOMKFLEEIC()
	{
		dLOMKFLEEICCase_ = DLOMKFLEEICOneofCase.None;
		dLOMKFLEEIC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ActivityRaidPlacingGameCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivityRaidPlacingGameCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FCDCFAMOHAE, other.FCDCFAMOHAE))
		{
			return false;
		}
		if (MFMHHAPPPJJ != other.MFMHHAPPPJJ)
		{
			return false;
		}
		if (OBPNDKPPFGG != other.OBPNDKPPFGG)
		{
			return false;
		}
		if (DLOMKFLEEICCase != other.DLOMKFLEEICCase)
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
		if (fCDCFAMOHAE_ != null)
		{
			num ^= FCDCFAMOHAE.GetHashCode();
		}
		if (HasMFMHHAPPPJJ)
		{
			num ^= MFMHHAPPPJJ.GetHashCode();
		}
		if (HasOBPNDKPPFGG)
		{
			num ^= OBPNDKPPFGG.GetHashCode();
		}
		num ^= (int)dLOMKFLEEICCase_;
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
		if (HasMFMHHAPPPJJ)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MFMHHAPPPJJ);
		}
		if (fCDCFAMOHAE_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FCDCFAMOHAE);
		}
		if (HasOBPNDKPPFGG)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OBPNDKPPFGG);
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
		if (fCDCFAMOHAE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FCDCFAMOHAE);
		}
		if (HasMFMHHAPPPJJ)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFMHHAPPPJJ);
		}
		if (HasOBPNDKPPFGG)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBPNDKPPFGG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ActivityRaidPlacingGameCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fCDCFAMOHAE_ != null)
		{
			if (fCDCFAMOHAE_ == null)
			{
				FCDCFAMOHAE = new AlleyPlacingShip();
			}
			FCDCFAMOHAE.MergeFrom(other.FCDCFAMOHAE);
		}
		switch (other.DLOMKFLEEICCase)
		{
		case DLOMKFLEEICOneofCase.MFMHHAPPPJJ:
			MFMHHAPPPJJ = other.MFMHHAPPPJJ;
			break;
		case DLOMKFLEEICOneofCase.OBPNDKPPFGG:
			OBPNDKPPFGG = other.OBPNDKPPFGG;
			break;
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
			case 8u:
				MFMHHAPPPJJ = input.ReadUInt32();
				break;
			case 90u:
				if (fCDCFAMOHAE_ == null)
				{
					FCDCFAMOHAE = new AlleyPlacingShip();
				}
				input.ReadMessage(FCDCFAMOHAE);
				break;
			case 96u:
				OBPNDKPPFGG = input.ReadUInt32();
				break;
			}
		}
	}
}
