using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesAvatarLevelUpScRsp : IMessage<PlanetFesAvatarLevelUpScRsp>, IMessage, IEquatable<PlanetFesAvatarLevelUpScRsp>, IDeepCloneable<PlanetFesAvatarLevelUpScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesAvatarLevelUpScRsp> _parser = new MessageParser<PlanetFesAvatarLevelUpScRsp>(() => new PlanetFesAvatarLevelUpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int IHLLMLLNIFNFieldNumber = 1;

	private uint iHLLMLLNIFN_;

	public const int RewardFieldNumber = 3;

	private HLLCDBLCIPK reward_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int ODADJILOEKOFieldNumber = 9;

	private uint oDADJILOEKO_;

	public const int AvatarIdFieldNumber = 15;

	private uint avatarId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesAvatarLevelUpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesAvatarLevelUpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHLLMLLNIFN
	{
		get
		{
			return iHLLMLLNIFN_;
		}
		set
		{
			iHLLMLLNIFN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
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
	public uint ODADJILOEKO
	{
		get
		{
			return oDADJILOEKO_;
		}
		set
		{
			oDADJILOEKO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesAvatarLevelUpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesAvatarLevelUpScRsp(PlanetFesAvatarLevelUpScRsp other)
		: this()
	{
		iHLLMLLNIFN_ = other.iHLLMLLNIFN_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		oDADJILOEKO_ = other.oDADJILOEKO_;
		avatarId_ = other.avatarId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesAvatarLevelUpScRsp Clone()
	{
		return new PlanetFesAvatarLevelUpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesAvatarLevelUpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesAvatarLevelUpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHLLMLLNIFN != other.IHLLMLLNIFN)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ODADJILOEKO != other.ODADJILOEKO)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
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
		if (IHLLMLLNIFN != 0)
		{
			num ^= IHLLMLLNIFN.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ODADJILOEKO != 0)
		{
			num ^= ODADJILOEKO.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
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
		if (IHLLMLLNIFN != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IHLLMLLNIFN);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (ODADJILOEKO != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ODADJILOEKO);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(AvatarId);
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
		if (IHLLMLLNIFN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHLLMLLNIFN);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ODADJILOEKO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODADJILOEKO);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesAvatarLevelUpScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IHLLMLLNIFN != 0)
		{
			IHLLMLLNIFN = other.IHLLMLLNIFN;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new HLLCDBLCIPK();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.ODADJILOEKO != 0)
		{
			ODADJILOEKO = other.ODADJILOEKO;
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
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
				IHLLMLLNIFN = input.ReadUInt32();
				break;
			case 26u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				ODADJILOEKO = input.ReadUInt32();
				break;
			case 120u:
				AvatarId = input.ReadUInt32();
				break;
			}
		}
	}
}
