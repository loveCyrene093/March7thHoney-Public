using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PJLBDMPEKFP : IMessage<PJLBDMPEKFP>, IMessage, IEquatable<PJLBDMPEKFP>, IDeepCloneable<PJLBDMPEKFP>, IBufferMessage
{
	private static readonly MessageParser<PJLBDMPEKFP> _parser = new MessageParser<PJLBDMPEKFP>(() => new PJLBDMPEKFP());

	private UnknownFieldSet _unknownFields;

	public const int MonsterIdFieldNumber = 3;

	private uint monsterId_;

	public const int RoleStarFieldNumber = 6;

	private uint roleStar_;

	public const int PMOGHFIGKPOFieldNumber = 10;

	private uint pMOGHFIGKPO_;

	public const int BFMEHGGEKOMFieldNumber = 14;

	private uint bFMEHGGEKOM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PJLBDMPEKFP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PJLBDMPEKFPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMOGHFIGKPO
	{
		get
		{
			return pMOGHFIGKPO_;
		}
		set
		{
			pMOGHFIGKPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BFMEHGGEKOM
	{
		get
		{
			return bFMEHGGEKOM_;
		}
		set
		{
			bFMEHGGEKOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PJLBDMPEKFP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PJLBDMPEKFP(PJLBDMPEKFP other)
		: this()
	{
		monsterId_ = other.monsterId_;
		roleStar_ = other.roleStar_;
		pMOGHFIGKPO_ = other.pMOGHFIGKPO_;
		bFMEHGGEKOM_ = other.bFMEHGGEKOM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PJLBDMPEKFP Clone()
	{
		return new PJLBDMPEKFP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PJLBDMPEKFP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PJLBDMPEKFP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MonsterId != other.MonsterId)
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (PMOGHFIGKPO != other.PMOGHFIGKPO)
		{
			return false;
		}
		if (BFMEHGGEKOM != other.BFMEHGGEKOM)
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
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
		}
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (PMOGHFIGKPO != 0)
		{
			num ^= PMOGHFIGKPO.GetHashCode();
		}
		if (BFMEHGGEKOM != 0)
		{
			num ^= BFMEHGGEKOM.GetHashCode();
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
		if (MonsterId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MonsterId);
		}
		if (RoleStar != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(RoleStar);
		}
		if (PMOGHFIGKPO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PMOGHFIGKPO);
		}
		if (BFMEHGGEKOM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(BFMEHGGEKOM);
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
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (PMOGHFIGKPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMOGHFIGKPO);
		}
		if (BFMEHGGEKOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BFMEHGGEKOM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PJLBDMPEKFP other)
	{
		if (other != null)
		{
			if (other.MonsterId != 0)
			{
				MonsterId = other.MonsterId;
			}
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.PMOGHFIGKPO != 0)
			{
				PMOGHFIGKPO = other.PMOGHFIGKPO;
			}
			if (other.BFMEHGGEKOM != 0)
			{
				BFMEHGGEKOM = other.BFMEHGGEKOM;
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
			case 24u:
				MonsterId = input.ReadUInt32();
				break;
			case 48u:
				RoleStar = input.ReadUInt32();
				break;
			case 80u:
				PMOGHFIGKPO = input.ReadUInt32();
				break;
			case 112u:
				BFMEHGGEKOM = input.ReadUInt32();
				break;
			}
		}
	}
}
