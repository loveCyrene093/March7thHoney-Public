using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetBigDataAllRecommendScRsp : IMessage<GetBigDataAllRecommendScRsp>, IMessage, IEquatable<GetBigDataAllRecommendScRsp>, IDeepCloneable<GetBigDataAllRecommendScRsp>, IBufferMessage
{
	public enum RecommendTypeOneofCase
	{
		None = 0,
		RelicAvatar = 4,
		GIJOGKBMDIP = 13,
		AvatarRelic = 15
	}

	private static readonly MessageParser<GetBigDataAllRecommendScRsp> _parser = new MessageParser<GetBigDataAllRecommendScRsp>(() => new GetBigDataAllRecommendScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BigDataRecommendTypeFieldNumber = 2;

	private BigDataRecommendType bigDataRecommendType_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int RelicAvatarFieldNumber = 4;

	public const int GIJOGKBMDIPFieldNumber = 13;

	public const int AvatarRelicFieldNumber = 15;

	private object recommendType_;

	private RecommendTypeOneofCase recommendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetBigDataAllRecommendScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetBigDataAllRecommendScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendType BigDataRecommendType
	{
		get
		{
			return bigDataRecommendType_;
		}
		set
		{
			bigDataRecommendType_ = value;
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
	public BigDataRecommendRelicAvatar RelicAvatar
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.RelicAvatar)
			{
				return null;
			}
			return (BigDataRecommendRelicAvatar)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.RelicAvatar : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBJDMKPDCNK GIJOGKBMDIP
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.GIJOGKBMDIP)
			{
				return null;
			}
			return (EBJDMKPDCNK)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.GIJOGKBMDIP : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BigDataRecommendAvatarRelic AvatarRelic
	{
		get
		{
			if (recommendTypeCase_ != RecommendTypeOneofCase.AvatarRelic)
			{
				return null;
			}
			return (BigDataRecommendAvatarRelic)recommendType_;
		}
		set
		{
			recommendType_ = value;
			recommendTypeCase_ = ((value != null) ? RecommendTypeOneofCase.AvatarRelic : RecommendTypeOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RecommendTypeOneofCase RecommendTypeCase => recommendTypeCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendScRsp(GetBigDataAllRecommendScRsp other)
		: this()
	{
		bigDataRecommendType_ = other.bigDataRecommendType_;
		retcode_ = other.retcode_;
		switch (other.RecommendTypeCase)
		{
		case RecommendTypeOneofCase.RelicAvatar:
			RelicAvatar = other.RelicAvatar.Clone();
			break;
		case RecommendTypeOneofCase.GIJOGKBMDIP:
			GIJOGKBMDIP = other.GIJOGKBMDIP.Clone();
			break;
		case RecommendTypeOneofCase.AvatarRelic:
			AvatarRelic = other.AvatarRelic.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetBigDataAllRecommendScRsp Clone()
	{
		return new GetBigDataAllRecommendScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearRecommendType()
	{
		recommendTypeCase_ = RecommendTypeOneofCase.None;
		recommendType_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetBigDataAllRecommendScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetBigDataAllRecommendScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BigDataRecommendType != other.BigDataRecommendType)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(RelicAvatar, other.RelicAvatar))
		{
			return false;
		}
		if (!object.Equals(GIJOGKBMDIP, other.GIJOGKBMDIP))
		{
			return false;
		}
		if (!object.Equals(AvatarRelic, other.AvatarRelic))
		{
			return false;
		}
		if (RecommendTypeCase != other.RecommendTypeCase)
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num ^= BigDataRecommendType.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicAvatar)
		{
			num ^= RelicAvatar.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			num ^= GIJOGKBMDIP.GetHashCode();
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.AvatarRelic)
		{
			num ^= AvatarRelic.GetHashCode();
		}
		num ^= (int)recommendTypeCase_;
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)BigDataRecommendType);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicAvatar)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RelicAvatar);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GIJOGKBMDIP);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.AvatarRelic)
		{
			output.WriteRawTag(122);
			output.WriteMessage(AvatarRelic);
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
		if (BigDataRecommendType != BigDataRecommendType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BigDataRecommendType);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.RelicAvatar)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicAvatar);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GIJOGKBMDIP);
		}
		if (recommendTypeCase_ == RecommendTypeOneofCase.AvatarRelic)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AvatarRelic);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetBigDataAllRecommendScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BigDataRecommendType != BigDataRecommendType.None)
		{
			BigDataRecommendType = other.BigDataRecommendType;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		switch (other.RecommendTypeCase)
		{
		case RecommendTypeOneofCase.RelicAvatar:
			if (RelicAvatar == null)
			{
				RelicAvatar = new BigDataRecommendRelicAvatar();
			}
			RelicAvatar.MergeFrom(other.RelicAvatar);
			break;
		case RecommendTypeOneofCase.GIJOGKBMDIP:
			if (GIJOGKBMDIP == null)
			{
				GIJOGKBMDIP = new EBJDMKPDCNK();
			}
			GIJOGKBMDIP.MergeFrom(other.GIJOGKBMDIP);
			break;
		case RecommendTypeOneofCase.AvatarRelic:
			if (AvatarRelic == null)
			{
				AvatarRelic = new BigDataRecommendAvatarRelic();
			}
			AvatarRelic.MergeFrom(other.AvatarRelic);
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
			case 16u:
				BigDataRecommendType = (BigDataRecommendType)input.ReadEnum();
				break;
			case 34u:
			{
				BigDataRecommendRelicAvatar bigDataRecommendRelicAvatar = new BigDataRecommendRelicAvatar();
				if (recommendTypeCase_ == RecommendTypeOneofCase.RelicAvatar)
				{
					bigDataRecommendRelicAvatar.MergeFrom(RelicAvatar);
				}
				input.ReadMessage(bigDataRecommendRelicAvatar);
				RelicAvatar = bigDataRecommendRelicAvatar;
				break;
			}
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
			{
				EBJDMKPDCNK eBJDMKPDCNK = new EBJDMKPDCNK();
				if (recommendTypeCase_ == RecommendTypeOneofCase.GIJOGKBMDIP)
				{
					eBJDMKPDCNK.MergeFrom(GIJOGKBMDIP);
				}
				input.ReadMessage(eBJDMKPDCNK);
				GIJOGKBMDIP = eBJDMKPDCNK;
				break;
			}
			case 122u:
			{
				BigDataRecommendAvatarRelic bigDataRecommendAvatarRelic = new BigDataRecommendAvatarRelic();
				if (recommendTypeCase_ == RecommendTypeOneofCase.AvatarRelic)
				{
					bigDataRecommendAvatarRelic.MergeFrom(AvatarRelic);
				}
				input.ReadMessage(bigDataRecommendAvatarRelic);
				AvatarRelic = bigDataRecommendAvatarRelic;
				break;
			}
			}
		}
	}
}
