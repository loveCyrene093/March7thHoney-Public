using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAvatarDataScRsp : IMessage<GetAvatarDataScRsp>, IMessage, IEquatable<GetAvatarDataScRsp>, IDeepCloneable<GetAvatarDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAvatarDataScRsp> _parser = new MessageParser<GetAvatarDataScRsp>(() => new GetAvatarDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PlayerOutfitDataFieldNumber = 1;

	private PlayerOutfitInfo playerOutfitData_;

	public const int MMEKFJDMILJFieldNumber = 3;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_mMEKFJDMILJ_codec = FieldCodec.ForMessage(26u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> mMEKFJDMILJ_ = new RepeatedField<GKDEKJKOIJN>();

	public const int CurAvatarPathFieldNumber = 4;

	private static readonly FieldCodec<GrowthTartgetFuncType> _repeated_curAvatarPath_codec = FieldCodec.ForEnum(34u, (GrowthTartgetFuncType x) => (int)x, (int x) => (GrowthTartgetFuncType)x);

	private readonly RepeatedField<GrowthTartgetFuncType> curAvatarPath_ = new RepeatedField<GrowthTartgetFuncType>();

	public const int SkinListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_skinList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> skinList_ = new RepeatedField<uint>();

	public const int IsGetAllFieldNumber = 7;

	private bool isGetAll_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int BasicTypeIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_basicTypeIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> basicTypeIdList_ = new RepeatedField<uint>();

	public const int AvatarPathDataInfoListFieldNumber = 12;

	private static readonly FieldCodec<AvatarPathData> _repeated_avatarPathDataInfoList_codec = FieldCodec.ForMessage(98u, AvatarPathData.Parser);

	private readonly RepeatedField<AvatarPathData> avatarPathDataInfoList_ = new RepeatedField<AvatarPathData>();

	public const int AvatarListFieldNumber = 14;

	private static readonly FieldCodec<Avatar> _repeated_avatarList_codec = FieldCodec.ForMessage(114u, Avatar.Parser);

	private readonly RepeatedField<Avatar> avatarList_ = new RepeatedField<Avatar>();

	public const int MMOPCKLPHIOFieldNumber = 15;

	private uint mMOPCKLPHIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAvatarDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAvatarDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerOutfitInfo PlayerOutfitData
	{
		get
		{
			return playerOutfitData_;
		}
		set
		{
			playerOutfitData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> MMEKFJDMILJ => mMEKFJDMILJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GrowthTartgetFuncType> CurAvatarPath => curAvatarPath_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SkinList => skinList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsGetAll
	{
		get
		{
			return isGetAll_;
		}
		set
		{
			isGetAll_ = value;
		}
	}

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
	public RepeatedField<uint> BasicTypeIdList => basicTypeIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AvatarPathData> AvatarPathDataInfoList => avatarPathDataInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Avatar> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMOPCKLPHIO
	{
		get
		{
			return mMOPCKLPHIO_;
		}
		set
		{
			mMOPCKLPHIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataScRsp(GetAvatarDataScRsp other)
		: this()
	{
		playerOutfitData_ = ((other.playerOutfitData_ != null) ? other.playerOutfitData_.Clone() : null);
		mMEKFJDMILJ_ = other.mMEKFJDMILJ_.Clone();
		curAvatarPath_ = other.curAvatarPath_.Clone();
		skinList_ = other.skinList_.Clone();
		isGetAll_ = other.isGetAll_;
		retcode_ = other.retcode_;
		basicTypeIdList_ = other.basicTypeIdList_.Clone();
		avatarPathDataInfoList_ = other.avatarPathDataInfoList_.Clone();
		avatarList_ = other.avatarList_.Clone();
		mMOPCKLPHIO_ = other.mMOPCKLPHIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAvatarDataScRsp Clone()
	{
		return new GetAvatarDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAvatarDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAvatarDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PlayerOutfitData, other.PlayerOutfitData))
		{
			return false;
		}
		if (!mMEKFJDMILJ_.Equals(other.mMEKFJDMILJ_))
		{
			return false;
		}
		if (!curAvatarPath_.Equals(other.curAvatarPath_))
		{
			return false;
		}
		if (!skinList_.Equals(other.skinList_))
		{
			return false;
		}
		if (IsGetAll != other.IsGetAll)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!basicTypeIdList_.Equals(other.basicTypeIdList_))
		{
			return false;
		}
		if (!avatarPathDataInfoList_.Equals(other.avatarPathDataInfoList_))
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (MMOPCKLPHIO != other.MMOPCKLPHIO)
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
		if (playerOutfitData_ != null)
		{
			num ^= PlayerOutfitData.GetHashCode();
		}
		num ^= mMEKFJDMILJ_.GetHashCode();
		num ^= curAvatarPath_.GetHashCode();
		num ^= skinList_.GetHashCode();
		if (IsGetAll)
		{
			num ^= IsGetAll.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= basicTypeIdList_.GetHashCode();
		num ^= avatarPathDataInfoList_.GetHashCode();
		num ^= avatarList_.GetHashCode();
		if (MMOPCKLPHIO != 0)
		{
			num ^= MMOPCKLPHIO.GetHashCode();
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
		if (playerOutfitData_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PlayerOutfitData);
		}
		mMEKFJDMILJ_.WriteTo(ref output, _repeated_mMEKFJDMILJ_codec);
		curAvatarPath_.WriteTo(ref output, _repeated_curAvatarPath_codec);
		skinList_.WriteTo(ref output, _repeated_skinList_codec);
		if (IsGetAll)
		{
			output.WriteRawTag(56);
			output.WriteBool(IsGetAll);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		basicTypeIdList_.WriteTo(ref output, _repeated_basicTypeIdList_codec);
		avatarPathDataInfoList_.WriteTo(ref output, _repeated_avatarPathDataInfoList_codec);
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (MMOPCKLPHIO != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MMOPCKLPHIO);
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
		if (playerOutfitData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerOutfitData);
		}
		num += mMEKFJDMILJ_.CalculateSize(_repeated_mMEKFJDMILJ_codec);
		num += curAvatarPath_.CalculateSize(_repeated_curAvatarPath_codec);
		num += skinList_.CalculateSize(_repeated_skinList_codec);
		if (IsGetAll)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += basicTypeIdList_.CalculateSize(_repeated_basicTypeIdList_codec);
		num += avatarPathDataInfoList_.CalculateSize(_repeated_avatarPathDataInfoList_codec);
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (MMOPCKLPHIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMOPCKLPHIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAvatarDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.playerOutfitData_ != null)
		{
			if (playerOutfitData_ == null)
			{
				PlayerOutfitData = new PlayerOutfitInfo();
			}
			PlayerOutfitData.MergeFrom(other.PlayerOutfitData);
		}
		mMEKFJDMILJ_.Add(other.mMEKFJDMILJ_);
		curAvatarPath_.Add(other.curAvatarPath_);
		skinList_.Add(other.skinList_);
		if (other.IsGetAll)
		{
			IsGetAll = other.IsGetAll;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		basicTypeIdList_.Add(other.basicTypeIdList_);
		avatarPathDataInfoList_.Add(other.avatarPathDataInfoList_);
		avatarList_.Add(other.avatarList_);
		if (other.MMOPCKLPHIO != 0)
		{
			MMOPCKLPHIO = other.MMOPCKLPHIO;
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
				if (playerOutfitData_ == null)
				{
					PlayerOutfitData = new PlayerOutfitInfo();
				}
				input.ReadMessage(PlayerOutfitData);
				break;
			case 26u:
				mMEKFJDMILJ_.AddEntriesFrom(ref input, _repeated_mMEKFJDMILJ_codec);
				break;
			case 32u:
			case 34u:
				curAvatarPath_.AddEntriesFrom(ref input, _repeated_curAvatarPath_codec);
				break;
			case 48u:
			case 50u:
				skinList_.AddEntriesFrom(ref input, _repeated_skinList_codec);
				break;
			case 56u:
				IsGetAll = input.ReadBool();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				basicTypeIdList_.AddEntriesFrom(ref input, _repeated_basicTypeIdList_codec);
				break;
			case 98u:
				avatarPathDataInfoList_.AddEntriesFrom(ref input, _repeated_avatarPathDataInfoList_codec);
				break;
			case 114u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 120u:
				MMOPCKLPHIO = input.ReadUInt32();
				break;
			}
		}
	}
}
