using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOHAPMJILBG : IMessage<AOHAPMJILBG>, IMessage, IEquatable<AOHAPMJILBG>, IDeepCloneable<AOHAPMJILBG>, IBufferMessage
{
	private static readonly MessageParser<AOHAPMJILBG> _parser = new MessageParser<AOHAPMJILBG>(() => new AOHAPMJILBG());

	private UnknownFieldSet _unknownFields;

	public const int DressRoleUniqueIdFieldNumber = 9;

	private uint dressRoleUniqueId_;

	public const int RoleIdFieldNumber = 12;

	private uint roleId_;

	public const int EEBKDEMEPJKFieldNumber = 14;

	private static readonly MapField<uint, uint>.Codec _map_eEBKDEMEPJK_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 114u);

	private readonly MapField<uint, uint> eEBKDEMEPJK_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOHAPMJILBG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOHAPMJILBGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DressRoleUniqueId
	{
		get
		{
			return dressRoleUniqueId_;
		}
		set
		{
			dressRoleUniqueId_ = value;
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
	public MapField<uint, uint> EEBKDEMEPJK => eEBKDEMEPJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHAPMJILBG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHAPMJILBG(AOHAPMJILBG other)
		: this()
	{
		dressRoleUniqueId_ = other.dressRoleUniqueId_;
		roleId_ = other.roleId_;
		eEBKDEMEPJK_ = other.eEBKDEMEPJK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOHAPMJILBG Clone()
	{
		return new AOHAPMJILBG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOHAPMJILBG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOHAPMJILBG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DressRoleUniqueId != other.DressRoleUniqueId)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (!EEBKDEMEPJK.Equals(other.EEBKDEMEPJK))
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
		if (DressRoleUniqueId != 0)
		{
			num ^= DressRoleUniqueId.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		num ^= EEBKDEMEPJK.GetHashCode();
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
		if (DressRoleUniqueId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(DressRoleUniqueId);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(RoleId);
		}
		eEBKDEMEPJK_.WriteTo(ref output, _map_eEBKDEMEPJK_codec);
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
		if (DressRoleUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DressRoleUniqueId);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		num += eEBKDEMEPJK_.CalculateSize(_map_eEBKDEMEPJK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOHAPMJILBG other)
	{
		if (other != null)
		{
			if (other.DressRoleUniqueId != 0)
			{
				DressRoleUniqueId = other.DressRoleUniqueId;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			eEBKDEMEPJK_.MergeFrom(other.eEBKDEMEPJK_);
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
			case 72u:
				DressRoleUniqueId = input.ReadUInt32();
				break;
			case 96u:
				RoleId = input.ReadUInt32();
				break;
			case 114u:
				eEBKDEMEPJK_.AddEntriesFrom(ref input, _map_eEBKDEMEPJK_codec);
				break;
			}
		}
	}
}
