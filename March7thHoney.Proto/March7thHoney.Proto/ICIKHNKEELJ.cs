using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ICIKHNKEELJ : IMessage<ICIKHNKEELJ>, IMessage, IEquatable<ICIKHNKEELJ>, IDeepCloneable<ICIKHNKEELJ>, IBufferMessage
{
	private static readonly MessageParser<ICIKHNKEELJ> _parser = new MessageParser<ICIKHNKEELJ>(() => new ICIKHNKEELJ());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 3;

	private uint roleId_;

	public const int RoleStarFieldNumber = 7;

	private uint roleStar_;

	public const int PosFieldNumber = 9;

	private uint pos_;

	public const int GridFightItemListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_gridFightItemList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> gridFightItemList_ = new RepeatedField<uint>();

	public const int MHFDDMKMFAHFieldNumber = 14;

	private bool mHFDDMKMFAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ICIKHNKEELJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ICIKHNKEELJReflection.Descriptor.MessageTypes[0];

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
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightItemList => gridFightItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MHFDDMKMFAH
	{
		get
		{
			return mHFDDMKMFAH_;
		}
		set
		{
			mHFDDMKMFAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICIKHNKEELJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICIKHNKEELJ(ICIKHNKEELJ other)
		: this()
	{
		roleId_ = other.roleId_;
		roleStar_ = other.roleStar_;
		pos_ = other.pos_;
		gridFightItemList_ = other.gridFightItemList_.Clone();
		mHFDDMKMFAH_ = other.mHFDDMKMFAH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICIKHNKEELJ Clone()
	{
		return new ICIKHNKEELJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ICIKHNKEELJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ICIKHNKEELJ other)
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
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (!gridFightItemList_.Equals(other.gridFightItemList_))
		{
			return false;
		}
		if (MHFDDMKMFAH != other.MHFDDMKMFAH)
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
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		num ^= gridFightItemList_.GetHashCode();
		if (MHFDDMKMFAH)
		{
			num ^= MHFDDMKMFAH.GetHashCode();
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
		if (RoleStar != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RoleStar);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Pos);
		}
		gridFightItemList_.WriteTo(ref output, _repeated_gridFightItemList_codec);
		if (MHFDDMKMFAH)
		{
			output.WriteRawTag(112);
			output.WriteBool(MHFDDMKMFAH);
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
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		num += gridFightItemList_.CalculateSize(_repeated_gridFightItemList_codec);
		if (MHFDDMKMFAH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ICIKHNKEELJ other)
	{
		if (other != null)
		{
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			gridFightItemList_.Add(other.gridFightItemList_);
			if (other.MHFDDMKMFAH)
			{
				MHFDDMKMFAH = other.MHFDDMKMFAH;
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
			case 56u:
				RoleStar = input.ReadUInt32();
				break;
			case 72u:
				Pos = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				gridFightItemList_.AddEntriesFrom(ref input, _repeated_gridFightItemList_codec);
				break;
			case 112u:
				MHFDDMKMFAH = input.ReadBool();
				break;
			}
		}
	}
}
