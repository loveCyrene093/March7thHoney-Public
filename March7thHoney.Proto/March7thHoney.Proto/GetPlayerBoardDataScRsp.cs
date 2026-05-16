using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetPlayerBoardDataScRsp : IMessage<GetPlayerBoardDataScRsp>, IMessage, IEquatable<GetPlayerBoardDataScRsp>, IDeepCloneable<GetPlayerBoardDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetPlayerBoardDataScRsp> _parser = new MessageParser<GetPlayerBoardDataScRsp>(() => new GetPlayerBoardDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurrentHeadIconIdFieldNumber = 2;

	private uint currentHeadIconId_;

	public const int CurrentPersonalCardIdFieldNumber = 3;

	private uint currentPersonalCardId_;

	public const int HeadFrameInfoFieldNumber = 4;

	private HeadFrameInfo headFrameInfo_;

	public const int SignatureFieldNumber = 6;

	private string signature_ = "";

	public const int UnlockedPersonalCardListFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_unlockedPersonalCardList_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> unlockedPersonalCardList_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int UnlockedHeadIconListFieldNumber = 9;

	private static readonly FieldCodec<HeadIconData> _repeated_unlockedHeadIconList_codec = FieldCodec.ForMessage(74u, HeadIconData.Parser);

	private readonly RepeatedField<HeadIconData> unlockedHeadIconList_ = new RepeatedField<HeadIconData>();

	public const int AssistAvatarIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_assistAvatarIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> assistAvatarIdList_ = new RepeatedField<uint>();

	public const int DisplayAvatarVecFieldNumber = 15;

	private DisplayAvatarVec displayAvatarVec_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetPlayerBoardDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetPlayerBoardDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurrentHeadIconId
	{
		get
		{
			return currentHeadIconId_;
		}
		set
		{
			currentHeadIconId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurrentPersonalCardId
	{
		get
		{
			return currentPersonalCardId_;
		}
		set
		{
			currentPersonalCardId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeadFrameInfo HeadFrameInfo
	{
		get
		{
			return headFrameInfo_;
		}
		set
		{
			headFrameInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Signature
	{
		get
		{
			return signature_;
		}
		set
		{
			signature_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnlockedPersonalCardList => unlockedPersonalCardList_;

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
	public RepeatedField<HeadIconData> UnlockedHeadIconList => unlockedHeadIconList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AssistAvatarIdList => assistAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DisplayAvatarVec DisplayAvatarVec
	{
		get
		{
			return displayAvatarVec_;
		}
		set
		{
			displayAvatarVec_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerBoardDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerBoardDataScRsp(GetPlayerBoardDataScRsp other)
		: this()
	{
		currentHeadIconId_ = other.currentHeadIconId_;
		currentPersonalCardId_ = other.currentPersonalCardId_;
		headFrameInfo_ = ((other.headFrameInfo_ != null) ? other.headFrameInfo_.Clone() : null);
		signature_ = other.signature_;
		unlockedPersonalCardList_ = other.unlockedPersonalCardList_.Clone();
		retcode_ = other.retcode_;
		unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
		assistAvatarIdList_ = other.assistAvatarIdList_.Clone();
		displayAvatarVec_ = ((other.displayAvatarVec_ != null) ? other.displayAvatarVec_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetPlayerBoardDataScRsp Clone()
	{
		return new GetPlayerBoardDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetPlayerBoardDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetPlayerBoardDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurrentHeadIconId != other.CurrentHeadIconId)
		{
			return false;
		}
		if (CurrentPersonalCardId != other.CurrentPersonalCardId)
		{
			return false;
		}
		if (!object.Equals(HeadFrameInfo, other.HeadFrameInfo))
		{
			return false;
		}
		if (Signature != other.Signature)
		{
			return false;
		}
		if (!unlockedPersonalCardList_.Equals(other.unlockedPersonalCardList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!unlockedHeadIconList_.Equals(other.unlockedHeadIconList_))
		{
			return false;
		}
		if (!assistAvatarIdList_.Equals(other.assistAvatarIdList_))
		{
			return false;
		}
		if (!object.Equals(DisplayAvatarVec, other.DisplayAvatarVec))
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
		if (CurrentHeadIconId != 0)
		{
			num ^= CurrentHeadIconId.GetHashCode();
		}
		if (CurrentPersonalCardId != 0)
		{
			num ^= CurrentPersonalCardId.GetHashCode();
		}
		if (headFrameInfo_ != null)
		{
			num ^= HeadFrameInfo.GetHashCode();
		}
		if (Signature.Length != 0)
		{
			num ^= Signature.GetHashCode();
		}
		num ^= unlockedPersonalCardList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= unlockedHeadIconList_.GetHashCode();
		num ^= assistAvatarIdList_.GetHashCode();
		if (displayAvatarVec_ != null)
		{
			num ^= DisplayAvatarVec.GetHashCode();
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
		if (CurrentHeadIconId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CurrentHeadIconId);
		}
		if (CurrentPersonalCardId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(CurrentPersonalCardId);
		}
		if (headFrameInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(HeadFrameInfo);
		}
		if (Signature.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(Signature);
		}
		unlockedPersonalCardList_.WriteTo(ref output, _repeated_unlockedPersonalCardList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		unlockedHeadIconList_.WriteTo(ref output, _repeated_unlockedHeadIconList_codec);
		assistAvatarIdList_.WriteTo(ref output, _repeated_assistAvatarIdList_codec);
		if (displayAvatarVec_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(DisplayAvatarVec);
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
		if (CurrentHeadIconId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurrentHeadIconId);
		}
		if (CurrentPersonalCardId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurrentPersonalCardId);
		}
		if (headFrameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HeadFrameInfo);
		}
		if (Signature.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Signature);
		}
		num += unlockedPersonalCardList_.CalculateSize(_repeated_unlockedPersonalCardList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += unlockedHeadIconList_.CalculateSize(_repeated_unlockedHeadIconList_codec);
		num += assistAvatarIdList_.CalculateSize(_repeated_assistAvatarIdList_codec);
		if (displayAvatarVec_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DisplayAvatarVec);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetPlayerBoardDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.CurrentHeadIconId != 0)
		{
			CurrentHeadIconId = other.CurrentHeadIconId;
		}
		if (other.CurrentPersonalCardId != 0)
		{
			CurrentPersonalCardId = other.CurrentPersonalCardId;
		}
		if (other.headFrameInfo_ != null)
		{
			if (headFrameInfo_ == null)
			{
				HeadFrameInfo = new HeadFrameInfo();
			}
			HeadFrameInfo.MergeFrom(other.HeadFrameInfo);
		}
		if (other.Signature.Length != 0)
		{
			Signature = other.Signature;
		}
		unlockedPersonalCardList_.Add(other.unlockedPersonalCardList_);
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
		assistAvatarIdList_.Add(other.assistAvatarIdList_);
		if (other.displayAvatarVec_ != null)
		{
			if (displayAvatarVec_ == null)
			{
				DisplayAvatarVec = new DisplayAvatarVec();
			}
			DisplayAvatarVec.MergeFrom(other.DisplayAvatarVec);
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
				CurrentHeadIconId = input.ReadUInt32();
				break;
			case 24u:
				CurrentPersonalCardId = input.ReadUInt32();
				break;
			case 34u:
				if (headFrameInfo_ == null)
				{
					HeadFrameInfo = new HeadFrameInfo();
				}
				input.ReadMessage(HeadFrameInfo);
				break;
			case 50u:
				Signature = input.ReadString();
				break;
			case 56u:
			case 58u:
				unlockedPersonalCardList_.AddEntriesFrom(ref input, _repeated_unlockedPersonalCardList_codec);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				unlockedHeadIconList_.AddEntriesFrom(ref input, _repeated_unlockedHeadIconList_codec);
				break;
			case 112u:
			case 114u:
				assistAvatarIdList_.AddEntriesFrom(ref input, _repeated_assistAvatarIdList_codec);
				break;
			case 122u:
				if (displayAvatarVec_ == null)
				{
					DisplayAvatarVec = new DisplayAvatarVec();
				}
				input.ReadMessage(DisplayAvatarVec);
				break;
			}
		}
	}
}
