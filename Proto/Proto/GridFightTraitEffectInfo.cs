using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTraitEffectInfo : IMessage<GridFightTraitEffectInfo>, IMessage, IEquatable<GridFightTraitEffectInfo>, IDeepCloneable<GridFightTraitEffectInfo>, IBufferMessage
{
	public enum HDACCIEIJFOOneofCase
	{
		None = 0,
		HAINJKLLLKF = 110,
		EHCJJMABEOM = 157,
		AvatarCoreInfo = 768,
		TraitCoreRole = 1094
	}

	private static readonly MessageParser<GridFightTraitEffectInfo> _parser = new MessageParser<GridFightTraitEffectInfo>(() => new GridFightTraitEffectInfo());

	private UnknownFieldSet _unknownFields;

	public const int EffectIdFieldNumber = 11;

	private uint effectId_;

	public const int HAINJKLLLKFFieldNumber = 110;

	public const int EHCJJMABEOMFieldNumber = 157;

	public const int AvatarCoreInfoFieldNumber = 768;

	public const int TraitCoreRoleFieldNumber = 1094;

	private object hDACCIEIJFO_;

	private HDACCIEIJFOOneofCase hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTraitEffectInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightTraitEffectInfoReflection.Descriptor.MessageTypes[0];

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
	public HKOMEFBODGP HAINJKLLLKF
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.HAINJKLLLKF)
			{
				return null;
			}
			return (HKOMEFBODGP)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.HAINJKLLLKF : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHCJJMABEOM
	{
		get
		{
			if (!HasEHCJJMABEOM)
			{
				return 0u;
			}
			return (uint)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = HDACCIEIJFOOneofCase.EHCJJMABEOM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEHCJJMABEOM => hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.EHCJJMABEOM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLIEFGKALNB AvatarCoreInfo
	{
		get
		{
			if (hDACCIEIJFOCase_ != HDACCIEIJFOOneofCase.AvatarCoreInfo)
			{
				return null;
			}
			return (DLIEFGKALNB)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = ((value != null) ? HDACCIEIJFOOneofCase.AvatarCoreInfo : HDACCIEIJFOOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitCoreRole
	{
		get
		{
			if (!HasTraitCoreRole)
			{
				return 0u;
			}
			return (uint)hDACCIEIJFO_;
		}
		set
		{
			hDACCIEIJFO_ = value;
			hDACCIEIJFOCase_ = HDACCIEIJFOOneofCase.TraitCoreRole;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTraitCoreRole => hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.TraitCoreRole;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDACCIEIJFOOneofCase HDACCIEIJFOCase => hDACCIEIJFOCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectInfo(GridFightTraitEffectInfo other)
		: this()
	{
		effectId_ = other.effectId_;
		switch (other.HDACCIEIJFOCase)
		{
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			HAINJKLLLKF = other.HAINJKLLLKF.Clone();
			break;
		case HDACCIEIJFOOneofCase.EHCJJMABEOM:
			EHCJJMABEOM = other.EHCJJMABEOM;
			break;
		case HDACCIEIJFOOneofCase.AvatarCoreInfo:
			AvatarCoreInfo = other.AvatarCoreInfo.Clone();
			break;
		case HDACCIEIJFOOneofCase.TraitCoreRole:
			TraitCoreRole = other.TraitCoreRole;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTraitEffectInfo Clone()
	{
		return new GridFightTraitEffectInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearEHCJJMABEOM()
	{
		if (HasEHCJJMABEOM)
		{
			ClearHDACCIEIJFO();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearTraitCoreRole()
	{
		if (HasTraitCoreRole)
		{
			ClearHDACCIEIJFO();
		}
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
		return Equals(other as GridFightTraitEffectInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTraitEffectInfo other)
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
		if (!object.Equals(HAINJKLLLKF, other.HAINJKLLLKF))
		{
			return false;
		}
		if (EHCJJMABEOM != other.EHCJJMABEOM)
		{
			return false;
		}
		if (!object.Equals(AvatarCoreInfo, other.AvatarCoreInfo))
		{
			return false;
		}
		if (TraitCoreRole != other.TraitCoreRole)
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num ^= HAINJKLLLKF.GetHashCode();
		}
		if (HasEHCJJMABEOM)
		{
			num ^= EHCJJMABEOM.GetHashCode();
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			num ^= AvatarCoreInfo.GetHashCode();
		}
		if (HasTraitCoreRole)
		{
			num ^= TraitCoreRole.GetHashCode();
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
			output.WriteRawTag(88);
			output.WriteUInt32(EffectId);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			output.WriteRawTag(242, 6);
			output.WriteMessage(HAINJKLLLKF);
		}
		if (HasEHCJJMABEOM)
		{
			output.WriteRawTag(232, 9);
			output.WriteUInt32(EHCJJMABEOM);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			output.WriteRawTag(130, 48);
			output.WriteMessage(AvatarCoreInfo);
		}
		if (HasTraitCoreRole)
		{
			output.WriteRawTag(176, 68);
			output.WriteUInt32(TraitCoreRole);
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
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(HAINJKLLLKF);
		}
		if (HasEHCJJMABEOM)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(EHCJJMABEOM);
		}
		if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(AvatarCoreInfo);
		}
		if (HasTraitCoreRole)
		{
			num += 2 + CodedOutputStream.ComputeUInt32Size(TraitCoreRole);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTraitEffectInfo other)
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
		case HDACCIEIJFOOneofCase.HAINJKLLLKF:
			if (HAINJKLLLKF == null)
			{
				HAINJKLLLKF = new HKOMEFBODGP();
			}
			HAINJKLLLKF.MergeFrom(other.HAINJKLLLKF);
			break;
		case HDACCIEIJFOOneofCase.EHCJJMABEOM:
			EHCJJMABEOM = other.EHCJJMABEOM;
			break;
		case HDACCIEIJFOOneofCase.AvatarCoreInfo:
			if (AvatarCoreInfo == null)
			{
				AvatarCoreInfo = new DLIEFGKALNB();
			}
			AvatarCoreInfo.MergeFrom(other.AvatarCoreInfo);
			break;
		case HDACCIEIJFOOneofCase.TraitCoreRole:
			TraitCoreRole = other.TraitCoreRole;
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
			case 88u:
				EffectId = input.ReadUInt32();
				break;
			case 882u:
			{
				HKOMEFBODGP hKOMEFBODGP = new HKOMEFBODGP();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.HAINJKLLLKF)
				{
					hKOMEFBODGP.MergeFrom(HAINJKLLLKF);
				}
				input.ReadMessage(hKOMEFBODGP);
				HAINJKLLLKF = hKOMEFBODGP;
				break;
			}
			case 1256u:
				EHCJJMABEOM = input.ReadUInt32();
				break;
			case 6146u:
			{
				DLIEFGKALNB dLIEFGKALNB = new DLIEFGKALNB();
				if (hDACCIEIJFOCase_ == HDACCIEIJFOOneofCase.AvatarCoreInfo)
				{
					dLIEFGKALNB.MergeFrom(AvatarCoreInfo);
				}
				input.ReadMessage(dLIEFGKALNB);
				AvatarCoreInfo = dLIEFGKALNB;
				break;
			}
			case 8752u:
				TraitCoreRole = input.ReadUInt32();
				break;
			}
		}
	}
}
