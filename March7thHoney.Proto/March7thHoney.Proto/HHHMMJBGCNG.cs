using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHHMMJBGCNG : IMessage<HHHMMJBGCNG>, IMessage, IEquatable<HHHMMJBGCNG>, IDeepCloneable<HHHMMJBGCNG>, IBufferMessage
{
	private static readonly MessageParser<HHHMMJBGCNG> _parser = new MessageParser<HHHMMJBGCNG>(() => new HHHMMJBGCNG());

	private UnknownFieldSet _unknownFields;

	public const int TotalDamageFieldNumber = 5;

	private double totalDamage_;

	public const int RoleIdFieldNumber = 7;

	private uint roleId_;

	public const int GridFightEquipmentListFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_gridFightEquipmentList_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> gridFightEquipmentList_ = new RepeatedField<uint>();

	public const int RoleStarFieldNumber = 12;

	private uint roleStar_;

	public const int LDMNBDIDFCCFieldNumber = 13;

	private bool lDMNBDIDFCC_;

	public const int HNLEDBPGDBCFieldNumber = 15;

	private bool hNLEDBPGDBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHHMMJBGCNG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHHMMJBGCNGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double TotalDamage
	{
		get
		{
			return totalDamage_;
		}
		set
		{
			totalDamage_ = value;
		}
	}

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
	public RepeatedField<uint> GridFightEquipmentList => gridFightEquipmentList_;

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
	public bool LDMNBDIDFCC
	{
		get
		{
			return lDMNBDIDFCC_;
		}
		set
		{
			lDMNBDIDFCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HNLEDBPGDBC
	{
		get
		{
			return hNLEDBPGDBC_;
		}
		set
		{
			hNLEDBPGDBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHHMMJBGCNG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHHMMJBGCNG(HHHMMJBGCNG other)
		: this()
	{
		totalDamage_ = other.totalDamage_;
		roleId_ = other.roleId_;
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		roleStar_ = other.roleStar_;
		lDMNBDIDFCC_ = other.lDMNBDIDFCC_;
		hNLEDBPGDBC_ = other.hNLEDBPGDBC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHHMMJBGCNG Clone()
	{
		return new HHHMMJBGCNG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHHMMJBGCNG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHHMMJBGCNG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalDamage, other.TotalDamage))
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (LDMNBDIDFCC != other.LDMNBDIDFCC)
		{
			return false;
		}
		if (HNLEDBPGDBC != other.HNLEDBPGDBC)
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
		if (TotalDamage != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalDamage);
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= gridFightEquipmentList_.GetHashCode();
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (LDMNBDIDFCC)
		{
			num ^= LDMNBDIDFCC.GetHashCode();
		}
		if (HNLEDBPGDBC)
		{
			num ^= HNLEDBPGDBC.GetHashCode();
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
		if (TotalDamage != 0.0)
		{
			output.WriteRawTag(41);
			output.WriteDouble(TotalDamage);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RoleId);
		}
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
		if (RoleStar != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(RoleStar);
		}
		if (LDMNBDIDFCC)
		{
			output.WriteRawTag(104);
			output.WriteBool(LDMNBDIDFCC);
		}
		if (HNLEDBPGDBC)
		{
			output.WriteRawTag(120);
			output.WriteBool(HNLEDBPGDBC);
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
		if (TotalDamage != 0.0)
		{
			num += 9;
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (LDMNBDIDFCC)
		{
			num += 2;
		}
		if (HNLEDBPGDBC)
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
	public void MergeFrom(HHHMMJBGCNG other)
	{
		if (other != null)
		{
			if (other.TotalDamage != 0.0)
			{
				TotalDamage = other.TotalDamage;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.LDMNBDIDFCC)
			{
				LDMNBDIDFCC = other.LDMNBDIDFCC;
			}
			if (other.HNLEDBPGDBC)
			{
				HNLEDBPGDBC = other.HNLEDBPGDBC;
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
			case 41u:
				TotalDamage = input.ReadDouble();
				break;
			case 56u:
				RoleId = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			case 96u:
				RoleStar = input.ReadUInt32();
				break;
			case 104u:
				LDMNBDIDFCC = input.ReadBool();
				break;
			case 120u:
				HNLEDBPGDBC = input.ReadBool();
				break;
			}
		}
	}
}
