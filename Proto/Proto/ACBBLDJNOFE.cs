using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ACBBLDJNOFE : IMessage<ACBBLDJNOFE>, IMessage, IEquatable<ACBBLDJNOFE>, IDeepCloneable<ACBBLDJNOFE>, IBufferMessage
{
	private static readonly MessageParser<ACBBLDJNOFE> _parser = new MessageParser<ACBBLDJNOFE>(() => new ACBBLDJNOFE());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 3;

	private uint roleId_;

	public const int NCINGDCOOGKFieldNumber = 4;

	private bool nCINGDCOOGK_;

	public const int MAECCDAPKMDFieldNumber = 12;

	private uint mAECCDAPKMD_;

	public const int TraitIdFieldNumber = 14;

	private uint traitId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ACBBLDJNOFE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ACBBLDJNOFEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NCINGDCOOGK
	{
		get
		{
			return nCINGDCOOGK_;
		}
		set
		{
			nCINGDCOOGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MAECCDAPKMD
	{
		get
		{
			return mAECCDAPKMD_;
		}
		set
		{
			mAECCDAPKMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACBBLDJNOFE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACBBLDJNOFE(ACBBLDJNOFE other)
		: this()
	{
		roleId_ = other.roleId_;
		nCINGDCOOGK_ = other.nCINGDCOOGK_;
		mAECCDAPKMD_ = other.mAECCDAPKMD_;
		traitId_ = other.traitId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ACBBLDJNOFE Clone()
	{
		return new ACBBLDJNOFE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ACBBLDJNOFE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ACBBLDJNOFE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (NCINGDCOOGK != other.NCINGDCOOGK)
		{
			return false;
		}
		if (MAECCDAPKMD != other.MAECCDAPKMD)
		{
			return false;
		}
		if (TraitId != other.TraitId)
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
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (NCINGDCOOGK)
		{
			num ^= NCINGDCOOGK.GetHashCode();
		}
		if (MAECCDAPKMD != 0)
		{
			num ^= MAECCDAPKMD.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
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
		if (RoleId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(RoleId);
		}
		if (NCINGDCOOGK)
		{
			output.WriteRawTag(32);
			output.WriteBool(NCINGDCOOGK);
		}
		if (MAECCDAPKMD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MAECCDAPKMD);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(TraitId);
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
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (NCINGDCOOGK)
		{
			num += 2;
		}
		if (MAECCDAPKMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MAECCDAPKMD);
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ACBBLDJNOFE other)
	{
		if (other != null)
		{
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.NCINGDCOOGK)
			{
				NCINGDCOOGK = other.NCINGDCOOGK;
			}
			if (other.MAECCDAPKMD != 0)
			{
				MAECCDAPKMD = other.MAECCDAPKMD;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
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
				RoleId = input.ReadUInt32();
				break;
			case 32u:
				NCINGDCOOGK = input.ReadBool();
				break;
			case 96u:
				MAECCDAPKMD = input.ReadUInt32();
				break;
			case 112u:
				TraitId = input.ReadUInt32();
				break;
			}
		}
	}
}
