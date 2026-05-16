using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMissionDataScRsp : IMessage<GetMissionDataScRsp>, IMessage, IEquatable<GetMissionDataScRsp>, IDeepCloneable<GetMissionDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMissionDataScRsp> _parser = new MessageParser<GetMissionDataScRsp>(() => new GetMissionDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int POAAJEBFENOFieldNumber = 2;

	private uint pOAAJEBFENO_;

	public const int TrackMissionIdFieldNumber = 4;

	private uint trackMissionId_;

	public const int MissionListFieldNumber = 5;

	private static readonly FieldCodec<Mission> _repeated_missionList_codec = FieldCodec.ForMessage(42u, Mission.Parser);

	private readonly RepeatedField<Mission> missionList_ = new RepeatedField<Mission>();

	public const int MainMissionListFieldNumber = 11;

	private static readonly FieldCodec<MainMission> _repeated_mainMissionList_codec = FieldCodec.ForMessage(90u, MainMission.Parser);

	private readonly RepeatedField<MainMission> mainMissionList_ = new RepeatedField<MainMission>();

	public const int EIAGKFKONPEFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_eIAGKFKONPE_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> eIAGKFKONPE_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 15;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMissionDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMissionDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint POAAJEBFENO
	{
		get
		{
			return pOAAJEBFENO_;
		}
		set
		{
			pOAAJEBFENO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TrackMissionId
	{
		get
		{
			return trackMissionId_;
		}
		set
		{
			trackMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Mission> MissionList => missionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MainMission> MainMissionList => mainMissionList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EIAGKFKONPE => eIAGKFKONPE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionDataScRsp(GetMissionDataScRsp other)
		: this()
	{
		pOAAJEBFENO_ = other.pOAAJEBFENO_;
		trackMissionId_ = other.trackMissionId_;
		missionList_ = other.missionList_.Clone();
		mainMissionList_ = other.mainMissionList_.Clone();
		eIAGKFKONPE_ = other.eIAGKFKONPE_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMissionDataScRsp Clone()
	{
		return new GetMissionDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMissionDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMissionDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (POAAJEBFENO != other.POAAJEBFENO)
		{
			return false;
		}
		if (TrackMissionId != other.TrackMissionId)
		{
			return false;
		}
		if (!missionList_.Equals(other.missionList_))
		{
			return false;
		}
		if (!mainMissionList_.Equals(other.mainMissionList_))
		{
			return false;
		}
		if (!eIAGKFKONPE_.Equals(other.eIAGKFKONPE_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (POAAJEBFENO != 0)
		{
			num ^= POAAJEBFENO.GetHashCode();
		}
		if (TrackMissionId != 0)
		{
			num ^= TrackMissionId.GetHashCode();
		}
		num ^= missionList_.GetHashCode();
		num ^= mainMissionList_.GetHashCode();
		num ^= eIAGKFKONPE_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (POAAJEBFENO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(POAAJEBFENO);
		}
		if (TrackMissionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(TrackMissionId);
		}
		missionList_.WriteTo(ref output, _repeated_missionList_codec);
		mainMissionList_.WriteTo(ref output, _repeated_mainMissionList_codec);
		eIAGKFKONPE_.WriteTo(ref output, _repeated_eIAGKFKONPE_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(Retcode);
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
		if (POAAJEBFENO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(POAAJEBFENO);
		}
		if (TrackMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TrackMissionId);
		}
		num += missionList_.CalculateSize(_repeated_missionList_codec);
		num += mainMissionList_.CalculateSize(_repeated_mainMissionList_codec);
		num += eIAGKFKONPE_.CalculateSize(_repeated_eIAGKFKONPE_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMissionDataScRsp other)
	{
		if (other != null)
		{
			if (other.POAAJEBFENO != 0)
			{
				POAAJEBFENO = other.POAAJEBFENO;
			}
			if (other.TrackMissionId != 0)
			{
				TrackMissionId = other.TrackMissionId;
			}
			missionList_.Add(other.missionList_);
			mainMissionList_.Add(other.mainMissionList_);
			eIAGKFKONPE_.Add(other.eIAGKFKONPE_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
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
				POAAJEBFENO = input.ReadUInt32();
				break;
			case 32u:
				TrackMissionId = input.ReadUInt32();
				break;
			case 42u:
				missionList_.AddEntriesFrom(ref input, _repeated_missionList_codec);
				break;
			case 90u:
				mainMissionList_.AddEntriesFrom(ref input, _repeated_mainMissionList_codec);
				break;
			case 96u:
			case 98u:
				eIAGKFKONPE_.AddEntriesFrom(ref input, _repeated_eIAGKFKONPE_codec);
				break;
			case 120u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
