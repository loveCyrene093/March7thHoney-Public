using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerBoardModuleSync : IMessage<PlayerBoardModuleSync>, IMessage, IEquatable<PlayerBoardModuleSync>, IDeepCloneable<PlayerBoardModuleSync>, IBufferMessage
{
	private static readonly MessageParser<PlayerBoardModuleSync> _parser = new MessageParser<PlayerBoardModuleSync>(() => new PlayerBoardModuleSync());

	private UnknownFieldSet _unknownFields;

	public const int SignatureFieldNumber = 1;

	private string signature_ = "";

	public const int UnlockedHeadIconListFieldNumber = 3;

	private static readonly FieldCodec<HeadIconData> _repeated_unlockedHeadIconList_codec = FieldCodec.ForMessage(26u, HeadIconData.Parser);

	private readonly RepeatedField<HeadIconData> unlockedHeadIconList_ = new RepeatedField<HeadIconData>();

	public const int HeadFrameInfoFieldNumber = 7;

	private HeadFrameInfo headFrameInfo_;

	public const int DGHJLFEKMPOFieldNumber = 11;

	private bool dGHJLFEKMPO_;

	public const int BNGJGEPGDNKFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_bNGJGEPGDNK_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> bNGJGEPGDNK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerBoardModuleSync> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerBoardModuleSyncReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<HeadIconData> UnlockedHeadIconList => unlockedHeadIconList_;

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
	public bool DGHJLFEKMPO
	{
		get
		{
			return dGHJLFEKMPO_;
		}
		set
		{
			dGHJLFEKMPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BNGJGEPGDNK => bNGJGEPGDNK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBoardModuleSync()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBoardModuleSync(PlayerBoardModuleSync other)
		: this()
	{
		signature_ = other.signature_;
		unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
		headFrameInfo_ = ((other.headFrameInfo_ != null) ? other.headFrameInfo_.Clone() : null);
		dGHJLFEKMPO_ = other.dGHJLFEKMPO_;
		bNGJGEPGDNK_ = other.bNGJGEPGDNK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBoardModuleSync Clone()
	{
		return new PlayerBoardModuleSync(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerBoardModuleSync);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerBoardModuleSync other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Signature != other.Signature)
		{
			return false;
		}
		if (!unlockedHeadIconList_.Equals(other.unlockedHeadIconList_))
		{
			return false;
		}
		if (!object.Equals(HeadFrameInfo, other.HeadFrameInfo))
		{
			return false;
		}
		if (DGHJLFEKMPO != other.DGHJLFEKMPO)
		{
			return false;
		}
		if (!bNGJGEPGDNK_.Equals(other.bNGJGEPGDNK_))
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
		if (Signature.Length != 0)
		{
			num ^= Signature.GetHashCode();
		}
		num ^= unlockedHeadIconList_.GetHashCode();
		if (headFrameInfo_ != null)
		{
			num ^= HeadFrameInfo.GetHashCode();
		}
		if (DGHJLFEKMPO)
		{
			num ^= DGHJLFEKMPO.GetHashCode();
		}
		num ^= bNGJGEPGDNK_.GetHashCode();
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
		if (Signature.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(Signature);
		}
		unlockedHeadIconList_.WriteTo(ref output, _repeated_unlockedHeadIconList_codec);
		if (headFrameInfo_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HeadFrameInfo);
		}
		if (DGHJLFEKMPO)
		{
			output.WriteRawTag(88);
			output.WriteBool(DGHJLFEKMPO);
		}
		bNGJGEPGDNK_.WriteTo(ref output, _repeated_bNGJGEPGDNK_codec);
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
		if (Signature.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Signature);
		}
		num += unlockedHeadIconList_.CalculateSize(_repeated_unlockedHeadIconList_codec);
		if (headFrameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HeadFrameInfo);
		}
		if (DGHJLFEKMPO)
		{
			num += 2;
		}
		num += bNGJGEPGDNK_.CalculateSize(_repeated_bNGJGEPGDNK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerBoardModuleSync other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Signature.Length != 0)
		{
			Signature = other.Signature;
		}
		unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
		if (other.headFrameInfo_ != null)
		{
			if (headFrameInfo_ == null)
			{
				HeadFrameInfo = new HeadFrameInfo();
			}
			HeadFrameInfo.MergeFrom(other.HeadFrameInfo);
		}
		if (other.DGHJLFEKMPO)
		{
			DGHJLFEKMPO = other.DGHJLFEKMPO;
		}
		bNGJGEPGDNK_.Add(other.bNGJGEPGDNK_);
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
				Signature = input.ReadString();
				break;
			case 26u:
				unlockedHeadIconList_.AddEntriesFrom(ref input, _repeated_unlockedHeadIconList_codec);
				break;
			case 58u:
				if (headFrameInfo_ == null)
				{
					HeadFrameInfo = new HeadFrameInfo();
				}
				input.ReadMessage(HeadFrameInfo);
				break;
			case 88u:
				DGHJLFEKMPO = input.ReadBool();
				break;
			case 120u:
			case 122u:
				bNGJGEPGDNK_.AddEntriesFrom(ref input, _repeated_bNGJGEPGDNK_codec);
				break;
			}
		}
	}
}
