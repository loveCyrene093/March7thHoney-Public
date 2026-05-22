using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BattleGridFightTraitEffectInfo : IMessage<BattleGridFightTraitEffectInfo>, IMessage, IEquatable<BattleGridFightTraitEffectInfo>, IDeepCloneable<BattleGridFightTraitEffectInfo>, IBufferMessage
{
	public enum HDACCIEIJFOOneofCase
	{
		None = 0,
		TraitCoreRole = 101,
		AvatarCoreInfo = 102,
		TraitEffectLevelInfo = 103,
		HAINJKLLLKF = 104
	}

	private static readonly MessageParser<BattleGridFightTraitEffectInfo> _parser = new MessageParser<BattleGridFightTraitEffectInfo>(() => new BattleGridFightTraitEffectInfo());

	private UnknownFieldSet _unknownFields;

	public const int EffectIdFieldNumber = 1;

	private uint effectId_;

	public const int TraitCoreRoleFieldNumber = 101;

	public const int AvatarCoreInfoFieldNumber = 102;

	public const int TraitEffectLevelInfoFieldNumber = 103;

	public const int HAINJKLLLKFFieldNumber = 104;

	private object hDACCIEIJFO_;

	private HDACCIEIJFOOneofCase hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BattleGridFightTraitEffectInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BattleGridFightTraitEffectInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EffectId
	{
		get
		{
			return effectId_;
		}
		set
		{
			effectId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightTraitCoreRoleInfo TraitCoreRole
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.TraitCoreRole)
			{
				return null;
			}
			return (BattleGridFightTraitCoreRoleInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.TraitCoreRole : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFigntAvatarCoreRoleInfo AvatarCoreInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.AvatarCoreInfo)
			{
				return null;
			}
			return (BattleGridFigntAvatarCoreRoleInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.AvatarCoreInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectLevelInfo TraitEffectLevelInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.TraitEffectLevelInfo)
			{
				return null;
			}
			return (GridFightTraitEffectLevelInfo)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.TraitEffectLevelInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFJGPODAKAM HAINJKLLLKF
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.HAINJKLLLKF)
			{
				return null;
			}
			return (DFJGPODAKAM)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.HAINJKLLLKF : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDACCIEIJFOOneofCase HDACCIEIJFOCase => hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightTraitEffectInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightTraitEffectInfo(BattleGridFightTraitEffectInfo other)
		: this()
	{
		effectId_ = other.effectId_;
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.TraitCoreRole:
			TraitCoreRole = other.TraitCoreRole.Clone();
			break;
		case HDACCIEIJFOOneofCase.AvatarCoreInfo:
			AvatarCoreInfo = other.AvatarCoreInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.TraitEffectLevelInfo:
			TraitEffectLevelInfo = other.TraitEffectLevelInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			HAINJKLLLKF = other.HAINJKLLLKF.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BattleGridFightTraitEffectInfo Clone()
	{
		return new BattleGridFightTraitEffectInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHDACCIEIJFO()
	{
		hDACCIEIJFOCase_ = HDACCIEIJFOOneofCase.None;
		hDACCIEIJFO_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BattleGridFightTraitEffectInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BattleGridFightTraitEffectInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EffectId != other.EffectId)
		{
			return false;
		}
		if (!object.Equals(TraitCoreRole, other.TraitCoreRole))
		{
			return false;
		}
		if (!object.Equals(AvatarCoreInfo, other.AvatarCoreInfo))
		{
			return false;
		}
		if (!object.Equals(TraitEffectLevelInfo, other.TraitEffectLevelInfo))
		{
			return false;
		}
		if (!object.Equals(HAINJKLLLKF, other.HAINJKLLLKF))
		{
			return false;
		}
		if (HDACCIEIJFOCase != other.HDACCIEIJFOCase)
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
		if (EffectId != 0)
		{
			num ^= EffectId.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitCoreRole)
		{
			num ^= TraitCoreRole.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			num ^= AvatarCoreInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitEffectLevelInfo)
		{
			num ^= TraitEffectLevelInfo.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num ^= HAINJKLLLKF.GetHashCode();
		}
		num ^= (int)hDACCIEIJFOCase_;
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
		if (EffectId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EffectId);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitCoreRole)
		{
			output.WriteRawTag(170, 6);
			output.WriteMessage(TraitCoreRole);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			output.WriteRawTag(178, 6);
			output.WriteMessage(AvatarCoreInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitEffectLevelInfo)
		{
			output.WriteRawTag(186, 6);
			output.WriteMessage(TraitEffectLevelInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			output.WriteRawTag(194, 6);
			output.WriteMessage(HAINJKLLLKF);
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
		if (EffectId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EffectId);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitCoreRole)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitCoreRole);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AvatarCoreInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitEffectLevelInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(TraitEffectLevelInfo);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HAINJKLLLKF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BattleGridFightTraitEffectInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.EffectId != 0)
		{
			EffectId = other.EffectId;
		}
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.TraitCoreRole:
			if (TraitCoreRole == null)
			{
				TraitCoreRole = new BattleGridFightTraitCoreRoleInfo();
			}
			TraitCoreRole.MergeFrom(other.TraitCoreRole);
			break;
		case HDACCIEIJFOOneofCase.AvatarCoreInfo:
			if (AvatarCoreInfo == null)
			{
				AvatarCoreInfo = new BattleGridFigntAvatarCoreRoleInfo();
			}
			AvatarCoreInfo.MergeFrom(other.AvatarCoreInfo);
			break;
		case HDACCIEIJFOOneofCase.TraitEffectLevelInfo:
			if (TraitEffectLevelInfo == null)
			{
				TraitEffectLevelInfo = new GridFightTraitEffectLevelInfo();
			}
			TraitEffectLevelInfo.MergeFrom(other.TraitEffectLevelInfo);
			break;
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			if (HAINJKLLLKF == null)
			{
				HAINJKLLLKF = new DFJGPODAKAM();
			}
			HAINJKLLLKF.MergeFrom(other.HAINJKLLLKF);
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
				EffectId = input.ReadUInt32();
				break;
			case 810u:
			{
				BattleGridFightTraitCoreRoleInfo battleGridFightTraitCoreRoleInfo = new BattleGridFightTraitCoreRoleInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitCoreRole)
				{
					battleGridFightTraitCoreRoleInfo.MergeFrom(TraitCoreRole);
				}
				input.ReadMessage(battleGridFightTraitCoreRoleInfo);
				TraitCoreRole = battleGridFightTraitCoreRoleInfo;
				break;
			}
			case 818u:
			{
				BattleGridFigntAvatarCoreRoleInfo battleGridFigntAvatarCoreRoleInfo = new BattleGridFigntAvatarCoreRoleInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
				{
					battleGridFigntAvatarCoreRoleInfo.MergeFrom(AvatarCoreInfo);
				}
				input.ReadMessage(battleGridFigntAvatarCoreRoleInfo);
				AvatarCoreInfo = battleGridFigntAvatarCoreRoleInfo;
				break;
			}
			case 826u:
			{
				GridFightTraitEffectLevelInfo gridFightTraitEffectLevelInfo = new GridFightTraitEffectLevelInfo();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitEffectLevelInfo)
				{
					gridFightTraitEffectLevelInfo.MergeFrom(TraitEffectLevelInfo);
				}
				input.ReadMessage(gridFightTraitEffectLevelInfo);
				TraitEffectLevelInfo = gridFightTraitEffectLevelInfo;
				break;
			}
			case 834u:
			{
				DFJGPODAKAM dFJGPODAKAM = new DFJGPODAKAM();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
				{
					dFJGPODAKAM.MergeFrom(HAINJKLLLKF);
				}
				input.ReadMessage(dFJGPODAKAM);
				HAINJKLLLKF = dFJGPODAKAM;
				break;
			}
			}
		}
	}
}
