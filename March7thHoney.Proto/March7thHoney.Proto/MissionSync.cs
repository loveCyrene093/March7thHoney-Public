using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MissionSync : IMessage<MissionSync>, IMessage, IEquatable<MissionSync>, IDeepCloneable<MissionSync>, IBufferMessage
{
	private static readonly MessageParser<MissionSync> _parser = new MessageParser<MissionSync>(() => new MissionSync());

	private UnknownFieldSet _unknownFields;

	public const int LMLDBOMCGADFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_lMLDBOMCGAD_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> lMLDBOMCGAD_ = new RepeatedField<uint>();

	public const int FFKOBMBJAPGFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_fFKOBMBJAPG_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> fFKOBMBJAPG_ = new RepeatedField<uint>();

	public const int MissionListFieldNumber = 5;

	private static readonly FieldCodec<Mission> _repeated_missionList_codec = FieldCodec.ForMessage(42u, Mission.Parser);

	private readonly RepeatedField<Mission> missionList_ = new RepeatedField<Mission>();

	public const int IMCIOLDLOLLFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_iMCIOLDLOLL_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> iMCIOLDLOLL_ = new RepeatedField<uint>();

	public const int OBHGEKKGAOLFieldNumber = 11;

	private static readonly FieldCodec<IFBLMCNFIEO> _repeated_oBHGEKKGAOL_codec = FieldCodec.ForMessage(90u, IFBLMCNFIEO.Parser);

	private readonly RepeatedField<IFBLMCNFIEO> oBHGEKKGAOL_ = new RepeatedField<IFBLMCNFIEO>();

	public const int FinishedMainMissionIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

	public const int EIAFCKFGBOAFieldNumber = 15;

	private static readonly FieldCodec<OKEPFGMNJAO> _repeated_eIAFCKFGBOA_codec = FieldCodec.ForMessage(122u, OKEPFGMNJAO.Parser);

	private readonly RepeatedField<OKEPFGMNJAO> eIAFCKFGBOA_ = new RepeatedField<OKEPFGMNJAO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MissionSync> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MissionSyncReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LMLDBOMCGAD => lMLDBOMCGAD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FFKOBMBJAPG => fFKOBMBJAPG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Mission> MissionList => missionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IMCIOLDLOLL => iMCIOLDLOLL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IFBLMCNFIEO> OBHGEKKGAOL => oBHGEKKGAOL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FinishedMainMissionIdList => finishedMainMissionIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OKEPFGMNJAO> EIAFCKFGBOA => eIAFCKFGBOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSync()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSync(MissionSync other)
		: this()
	{
		lMLDBOMCGAD_ = other.lMLDBOMCGAD_.Clone();
		fFKOBMBJAPG_ = other.fFKOBMBJAPG_.Clone();
		missionList_ = other.missionList_.Clone();
		iMCIOLDLOLL_ = other.iMCIOLDLOLL_.Clone();
		oBHGEKKGAOL_ = other.oBHGEKKGAOL_.Clone();
		finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
		eIAFCKFGBOA_ = other.eIAFCKFGBOA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MissionSync Clone()
	{
		return new MissionSync(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MissionSync);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MissionSync other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lMLDBOMCGAD_.Equals(other.lMLDBOMCGAD_))
		{
			return false;
		}
		if (!fFKOBMBJAPG_.Equals(other.fFKOBMBJAPG_))
		{
			return false;
		}
		if (!missionList_.Equals(other.missionList_))
		{
			return false;
		}
		if (!iMCIOLDLOLL_.Equals(other.iMCIOLDLOLL_))
		{
			return false;
		}
		if (!oBHGEKKGAOL_.Equals(other.oBHGEKKGAOL_))
		{
			return false;
		}
		if (!finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_))
		{
			return false;
		}
		if (!eIAFCKFGBOA_.Equals(other.eIAFCKFGBOA_))
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
		num ^= lMLDBOMCGAD_.GetHashCode();
		num ^= fFKOBMBJAPG_.GetHashCode();
		num ^= missionList_.GetHashCode();
		num ^= iMCIOLDLOLL_.GetHashCode();
		num ^= oBHGEKKGAOL_.GetHashCode();
		num ^= finishedMainMissionIdList_.GetHashCode();
		num ^= eIAFCKFGBOA_.GetHashCode();
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
		lMLDBOMCGAD_.WriteTo(ref output, _repeated_lMLDBOMCGAD_codec);
		fFKOBMBJAPG_.WriteTo(ref output, _repeated_fFKOBMBJAPG_codec);
		missionList_.WriteTo(ref output, _repeated_missionList_codec);
		iMCIOLDLOLL_.WriteTo(ref output, _repeated_iMCIOLDLOLL_codec);
		oBHGEKKGAOL_.WriteTo(ref output, _repeated_oBHGEKKGAOL_codec);
		finishedMainMissionIdList_.WriteTo(ref output, _repeated_finishedMainMissionIdList_codec);
		eIAFCKFGBOA_.WriteTo(ref output, _repeated_eIAFCKFGBOA_codec);
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
		num += lMLDBOMCGAD_.CalculateSize(_repeated_lMLDBOMCGAD_codec);
		num += fFKOBMBJAPG_.CalculateSize(_repeated_fFKOBMBJAPG_codec);
		num += missionList_.CalculateSize(_repeated_missionList_codec);
		num += iMCIOLDLOLL_.CalculateSize(_repeated_iMCIOLDLOLL_codec);
		num += oBHGEKKGAOL_.CalculateSize(_repeated_oBHGEKKGAOL_codec);
		num += finishedMainMissionIdList_.CalculateSize(_repeated_finishedMainMissionIdList_codec);
		num += eIAFCKFGBOA_.CalculateSize(_repeated_eIAFCKFGBOA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MissionSync other)
	{
		if (other != null)
		{
			lMLDBOMCGAD_.Add(other.lMLDBOMCGAD_);
			fFKOBMBJAPG_.Add(other.fFKOBMBJAPG_);
			missionList_.Add(other.missionList_);
			iMCIOLDLOLL_.Add(other.iMCIOLDLOLL_);
			oBHGEKKGAOL_.Add(other.oBHGEKKGAOL_);
			finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
			eIAFCKFGBOA_.Add(other.eIAFCKFGBOA_);
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
			case 18u:
				lMLDBOMCGAD_.AddEntriesFrom(ref input, _repeated_lMLDBOMCGAD_codec);
				break;
			case 32u:
			case 34u:
				fFKOBMBJAPG_.AddEntriesFrom(ref input, _repeated_fFKOBMBJAPG_codec);
				break;
			case 42u:
				missionList_.AddEntriesFrom(ref input, _repeated_missionList_codec);
				break;
			case 56u:
			case 58u:
				iMCIOLDLOLL_.AddEntriesFrom(ref input, _repeated_iMCIOLDLOLL_codec);
				break;
			case 90u:
				oBHGEKKGAOL_.AddEntriesFrom(ref input, _repeated_oBHGEKKGAOL_codec);
				break;
			case 96u:
			case 98u:
				finishedMainMissionIdList_.AddEntriesFrom(ref input, _repeated_finishedMainMissionIdList_codec);
				break;
			case 122u:
				eIAFCKFGBOA_.AddEntriesFrom(ref input, _repeated_eIAFCKFGBOA_codec);
				break;
			}
		}
	}
}
