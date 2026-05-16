using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAJOBJJPINN : IMessage<JAJOBJJPINN>, IMessage, IEquatable<JAJOBJJPINN>, IDeepCloneable<JAJOBJJPINN>, IBufferMessage
{
	private static readonly MessageParser<JAJOBJJPINN> _parser = new MessageParser<JAJOBJJPINN>(() => new JAJOBJJPINN());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 1;

	private uint roleId_;

	public const int RoleStarFieldNumber = 2;

	private uint roleStar_;

	public const int PosFieldNumber = 3;

	private uint pos_;

	public const int HHIJFHKJEPLFieldNumber = 7;

	private static readonly FieldCodec<APCNLFANPEP> _repeated_hHIJFHKJEPL_codec = FieldCodec.ForMessage(58u, APCNLFANPEP.Parser);

	private readonly RepeatedField<APCNLFANPEP> hHIJFHKJEPL_ = new RepeatedField<APCNLFANPEP>();

	public const int AvatarIdFieldNumber = 8;

	private uint avatarId_;

	public const int ConvertPropertyToFixpointFieldNumber = 10;

	private static readonly MapField<uint, uint>.Codec _map_convertPropertyToFixpoint_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 82u);

	private readonly MapField<uint, uint> convertPropertyToFixpoint_ = new MapField<uint, uint>();

	public const int UniqueIdFieldNumber = 11;

	private uint uniqueId_;

	public const int GJEHIGGNIAPFieldNumber = 12;

	private IFDFHPAMHCL gJEHIGGNIAP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAJOBJJPINN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAJOBJJPINNReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<APCNLFANPEP> HHIJFHKJEPL => hHIJFHKJEPL_;

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
	public MapField<uint, uint> ConvertPropertyToFixpoint => convertPropertyToFixpoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDFHPAMHCL GJEHIGGNIAP
	{
		get
		{
			return gJEHIGGNIAP_;
		}
		set
		{
			gJEHIGGNIAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAJOBJJPINN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAJOBJJPINN(JAJOBJJPINN other)
		: this()
	{
		roleId_ = other.roleId_;
		roleStar_ = other.roleStar_;
		pos_ = other.pos_;
		hHIJFHKJEPL_ = other.hHIJFHKJEPL_.Clone();
		avatarId_ = other.avatarId_;
		convertPropertyToFixpoint_ = other.convertPropertyToFixpoint_.Clone();
		uniqueId_ = other.uniqueId_;
		gJEHIGGNIAP_ = ((other.gJEHIGGNIAP_ != null) ? other.gJEHIGGNIAP_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAJOBJJPINN Clone()
	{
		return new JAJOBJJPINN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAJOBJJPINN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAJOBJJPINN other)
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
		if (!hHIJFHKJEPL_.Equals(other.hHIJFHKJEPL_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!ConvertPropertyToFixpoint.Equals(other.ConvertPropertyToFixpoint))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!object.Equals(GJEHIGGNIAP, other.GJEHIGGNIAP))
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
		num ^= hHIJFHKJEPL_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		num ^= ConvertPropertyToFixpoint.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (gJEHIGGNIAP_ != null)
		{
			num ^= GJEHIGGNIAP.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(RoleId);
		}
		if (RoleStar != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RoleStar);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Pos);
		}
		hHIJFHKJEPL_.WriteTo(ref output, _repeated_hHIJFHKJEPL_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(AvatarId);
		}
		convertPropertyToFixpoint_.WriteTo(ref output, _map_convertPropertyToFixpoint_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(UniqueId);
		}
		if (gJEHIGGNIAP_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(GJEHIGGNIAP);
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
		num += hHIJFHKJEPL_.CalculateSize(_repeated_hHIJFHKJEPL_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		num += convertPropertyToFixpoint_.CalculateSize(_map_convertPropertyToFixpoint_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (gJEHIGGNIAP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GJEHIGGNIAP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAJOBJJPINN other)
	{
		if (other == null)
		{
			return;
		}
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
		hHIJFHKJEPL_.Add(other.hHIJFHKJEPL_);
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		convertPropertyToFixpoint_.MergeFrom(other.convertPropertyToFixpoint_);
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.gJEHIGGNIAP_ != null)
		{
			if (gJEHIGGNIAP_ == null)
			{
				GJEHIGGNIAP = new IFDFHPAMHCL();
			}
			GJEHIGGNIAP.MergeFrom(other.GJEHIGGNIAP);
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
				RoleId = input.ReadUInt32();
				break;
			case 16u:
				RoleStar = input.ReadUInt32();
				break;
			case 24u:
				Pos = input.ReadUInt32();
				break;
			case 58u:
				hHIJFHKJEPL_.AddEntriesFrom(ref input, _repeated_hHIJFHKJEPL_codec);
				break;
			case 64u:
				AvatarId = input.ReadUInt32();
				break;
			case 82u:
				convertPropertyToFixpoint_.AddEntriesFrom(ref input, _map_convertPropertyToFixpoint_codec);
				break;
			case 88u:
				UniqueId = input.ReadUInt32();
				break;
			case 98u:
				if (gJEHIGGNIAP_ == null)
				{
					GJEHIGGNIAP = new IFDFHPAMHCL();
				}
				input.ReadMessage(GJEHIGGNIAP);
				break;
			}
		}
	}
}
