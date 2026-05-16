using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GADBCEGPNGH : IMessage<GADBCEGPNGH>, IMessage, IEquatable<GADBCEGPNGH>, IDeepCloneable<GADBCEGPNGH>, IBufferMessage
{
	private static readonly MessageParser<GADBCEGPNGH> _parser = new MessageParser<GADBCEGPNGH>(() => new GADBCEGPNGH());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 5;

	private uint groupId_;

	public const int PanelIdFieldNumber = 7;

	private uint panelId_;

	public const int GNHBGJAKACLFieldNumber = 10;

	private GNMDPMBGLBN gNHBGJAKACL_;

	public const int OGHFMOALPEOFieldNumber = 12;

	private uint oGHFMOALPEO_;

	public const int SwitchListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_switchList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> switchList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GADBCEGPNGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GADBCEGPNGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GNMDPMBGLBN GNHBGJAKACL
	{
		get
		{
			return gNHBGJAKACL_;
		}
		set
		{
			gNHBGJAKACL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OGHFMOALPEO
	{
		get
		{
			return oGHFMOALPEO_;
		}
		set
		{
			oGHFMOALPEO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> SwitchList => switchList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GADBCEGPNGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GADBCEGPNGH(GADBCEGPNGH other)
		: this()
	{
		groupId_ = other.groupId_;
		panelId_ = other.panelId_;
		gNHBGJAKACL_ = other.gNHBGJAKACL_;
		oGHFMOALPEO_ = other.oGHFMOALPEO_;
		switchList_ = other.switchList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GADBCEGPNGH Clone()
	{
		return new GADBCEGPNGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GADBCEGPNGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GADBCEGPNGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (GNHBGJAKACL != other.GNHBGJAKACL)
		{
			return false;
		}
		if (OGHFMOALPEO != other.OGHFMOALPEO)
		{
			return false;
		}
		if (!switchList_.Equals(other.switchList_))
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (GNHBGJAKACL != GNMDPMBGLBN.Ahdalmhedmp)
		{
			num ^= GNHBGJAKACL.GetHashCode();
		}
		if (OGHFMOALPEO != 0)
		{
			num ^= OGHFMOALPEO.GetHashCode();
		}
		num ^= switchList_.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GroupId);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PanelId);
		}
		if (GNHBGJAKACL != GNMDPMBGLBN.Ahdalmhedmp)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)GNHBGJAKACL);
		}
		if (OGHFMOALPEO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OGHFMOALPEO);
		}
		switchList_.WriteTo(ref output, _repeated_switchList_codec);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (GNHBGJAKACL != GNMDPMBGLBN.Ahdalmhedmp)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GNHBGJAKACL);
		}
		if (OGHFMOALPEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGHFMOALPEO);
		}
		num += switchList_.CalculateSize(_repeated_switchList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GADBCEGPNGH other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.GNHBGJAKACL != GNMDPMBGLBN.Ahdalmhedmp)
			{
				GNHBGJAKACL = other.GNHBGJAKACL;
			}
			if (other.OGHFMOALPEO != 0)
			{
				OGHFMOALPEO = other.OGHFMOALPEO;
			}
			switchList_.Add(other.switchList_);
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
			case 40u:
				GroupId = input.ReadUInt32();
				break;
			case 56u:
				PanelId = input.ReadUInt32();
				break;
			case 80u:
				GNHBGJAKACL = (GNMDPMBGLBN)input.ReadEnum();
				break;
			case 96u:
				OGHFMOALPEO = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				switchList_.AddEntriesFrom(ref input, _repeated_switchList_codec);
				break;
			}
		}
	}
}
