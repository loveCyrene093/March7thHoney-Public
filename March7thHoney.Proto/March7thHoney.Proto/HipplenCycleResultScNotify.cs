using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HipplenCycleResultScNotify : IMessage<HipplenCycleResultScNotify>, IMessage, IEquatable<HipplenCycleResultScNotify>, IDeepCloneable<HipplenCycleResultScNotify>, IBufferMessage
{
	private static readonly MessageParser<HipplenCycleResultScNotify> _parser = new MessageParser<HipplenCycleResultScNotify>(() => new HipplenCycleResultScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MPEMBDAGJJOFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_mPEMBDAGJJO_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> mPEMBDAGJJO_ = new RepeatedField<uint>();

	public const int DKPCDLDDONGFieldNumber = 2;

	private uint dKPCDLDDONG_;

	public const int IGNLJNLMPHHFieldNumber = 7;

	private static readonly FieldCodec<OBCJLDDEBHL> _repeated_iGNLJNLMPHH_codec = FieldCodec.ForMessage(58u, OBCJLDDEBHL.Parser);

	private readonly RepeatedField<OBCJLDDEBHL> iGNLJNLMPHH_ = new RepeatedField<OBCJLDDEBHL>();

	public const int IPOEIGADLJNFieldNumber = 8;

	private uint iPOEIGADLJN_;

	public const int GridFightTraitInfoFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitInfo_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> gridFightTraitInfo_ = new RepeatedField<uint>();

	public const int DGFGNMJALGJFieldNumber = 11;

	private DGKNDMAHMAP dGFGNMJALGJ_;

	public const int EENEEPKCJPHFieldNumber = 13;

	private static readonly FieldCodec<OBCJLDDEBHL> _repeated_eENEEPKCJPH_codec = FieldCodec.ForMessage(106u, OBCJLDDEBHL.Parser);

	private readonly RepeatedField<OBCJLDDEBHL> eENEEPKCJPH_ = new RepeatedField<OBCJLDDEBHL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HipplenCycleResultScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HipplenCycleResultScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MPEMBDAGJJO => mPEMBDAGJJO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DKPCDLDDONG
	{
		get
		{
			return dKPCDLDDONG_;
		}
		set
		{
			dKPCDLDDONG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBCJLDDEBHL> IGNLJNLMPHH => iGNLJNLMPHH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPOEIGADLJN
	{
		get
		{
			return iPOEIGADLJN_;
		}
		set
		{
			iPOEIGADLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightTraitInfo => gridFightTraitInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DGKNDMAHMAP DGFGNMJALGJ
	{
		get
		{
			return dGFGNMJALGJ_;
		}
		set
		{
			dGFGNMJALGJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OBCJLDDEBHL> EENEEPKCJPH => eENEEPKCJPH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenCycleResultScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenCycleResultScNotify(HipplenCycleResultScNotify other)
		: this()
	{
		mPEMBDAGJJO_ = other.mPEMBDAGJJO_.Clone();
		dKPCDLDDONG_ = other.dKPCDLDDONG_;
		iGNLJNLMPHH_ = other.iGNLJNLMPHH_.Clone();
		iPOEIGADLJN_ = other.iPOEIGADLJN_;
		gridFightTraitInfo_ = other.gridFightTraitInfo_.Clone();
		dGFGNMJALGJ_ = ((other.dGFGNMJALGJ_ != null) ? other.dGFGNMJALGJ_.Clone() : null);
		eENEEPKCJPH_ = other.eENEEPKCJPH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HipplenCycleResultScNotify Clone()
	{
		return new HipplenCycleResultScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HipplenCycleResultScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HipplenCycleResultScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mPEMBDAGJJO_.Equals(other.mPEMBDAGJJO_))
		{
			return false;
		}
		if (DKPCDLDDONG != other.DKPCDLDDONG)
		{
			return false;
		}
		if (!iGNLJNLMPHH_.Equals(other.iGNLJNLMPHH_))
		{
			return false;
		}
		if (IPOEIGADLJN != other.IPOEIGADLJN)
		{
			return false;
		}
		if (!gridFightTraitInfo_.Equals(other.gridFightTraitInfo_))
		{
			return false;
		}
		if (!object.Equals(DGFGNMJALGJ, other.DGFGNMJALGJ))
		{
			return false;
		}
		if (!eENEEPKCJPH_.Equals(other.eENEEPKCJPH_))
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
		num ^= mPEMBDAGJJO_.GetHashCode();
		if (DKPCDLDDONG != 0)
		{
			num ^= DKPCDLDDONG.GetHashCode();
		}
		num ^= iGNLJNLMPHH_.GetHashCode();
		if (IPOEIGADLJN != 0)
		{
			num ^= IPOEIGADLJN.GetHashCode();
		}
		num ^= gridFightTraitInfo_.GetHashCode();
		if (dGFGNMJALGJ_ != null)
		{
			num ^= DGFGNMJALGJ.GetHashCode();
		}
		num ^= eENEEPKCJPH_.GetHashCode();
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
		mPEMBDAGJJO_.WriteTo(ref output, _repeated_mPEMBDAGJJO_codec);
		if (DKPCDLDDONG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DKPCDLDDONG);
		}
		iGNLJNLMPHH_.WriteTo(ref output, _repeated_iGNLJNLMPHH_codec);
		if (IPOEIGADLJN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(IPOEIGADLJN);
		}
		gridFightTraitInfo_.WriteTo(ref output, _repeated_gridFightTraitInfo_codec);
		if (dGFGNMJALGJ_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DGFGNMJALGJ);
		}
		eENEEPKCJPH_.WriteTo(ref output, _repeated_eENEEPKCJPH_codec);
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
		num += mPEMBDAGJJO_.CalculateSize(_repeated_mPEMBDAGJJO_codec);
		if (DKPCDLDDONG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DKPCDLDDONG);
		}
		num += iGNLJNLMPHH_.CalculateSize(_repeated_iGNLJNLMPHH_codec);
		if (IPOEIGADLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPOEIGADLJN);
		}
		num += gridFightTraitInfo_.CalculateSize(_repeated_gridFightTraitInfo_codec);
		if (dGFGNMJALGJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DGFGNMJALGJ);
		}
		num += eENEEPKCJPH_.CalculateSize(_repeated_eENEEPKCJPH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HipplenCycleResultScNotify other)
	{
		if (other == null)
		{
			return;
		}
		mPEMBDAGJJO_.Add(other.mPEMBDAGJJO_);
		if (other.DKPCDLDDONG != 0)
		{
			DKPCDLDDONG = other.DKPCDLDDONG;
		}
		iGNLJNLMPHH_.Add(other.iGNLJNLMPHH_);
		if (other.IPOEIGADLJN != 0)
		{
			IPOEIGADLJN = other.IPOEIGADLJN;
		}
		gridFightTraitInfo_.Add(other.gridFightTraitInfo_);
		if (other.dGFGNMJALGJ_ != null)
		{
			if (dGFGNMJALGJ_ == null)
			{
				DGFGNMJALGJ = new DGKNDMAHMAP();
			}
			DGFGNMJALGJ.MergeFrom(other.DGFGNMJALGJ);
		}
		eENEEPKCJPH_.Add(other.eENEEPKCJPH_);
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
			case 10u:
				mPEMBDAGJJO_.AddEntriesFrom(ref input, _repeated_mPEMBDAGJJO_codec);
				break;
			case 16u:
				DKPCDLDDONG = input.ReadUInt32();
				break;
			case 58u:
				iGNLJNLMPHH_.AddEntriesFrom(ref input, _repeated_iGNLJNLMPHH_codec);
				break;
			case 64u:
				IPOEIGADLJN = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				gridFightTraitInfo_.AddEntriesFrom(ref input, _repeated_gridFightTraitInfo_codec);
				break;
			case 90u:
				if (dGFGNMJALGJ_ == null)
				{
					DGFGNMJALGJ = new DGKNDMAHMAP();
				}
				input.ReadMessage(DGFGNMJALGJ);
				break;
			case 106u:
				eENEEPKCJPH_.AddEntriesFrom(ref input, _repeated_eENEEPKCJPH_codec);
				break;
			}
		}
	}
}
