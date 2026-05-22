using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFNLBNEMHDA : IMessage<OFNLBNEMHDA>, IMessage, IEquatable<OFNLBNEMHDA>, IDeepCloneable<OFNLBNEMHDA>, IBufferMessage
{
	private static readonly MessageParser<OFNLBNEMHDA> _parser = new MessageParser<OFNLBNEMHDA>(() => new OFNLBNEMHDA());

	private UnknownFieldSet _unknownFields;

	public const int OGHFMOALPEOFieldNumber = 1;

	private uint oGHFMOALPEO_;

	public const int PanelIdFieldNumber = 12;

	private uint panelId_;

	public const int GroupIdFieldNumber = 13;

	private uint groupId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFNLBNEMHDA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFNLBNEMHDAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public OFNLBNEMHDA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFNLBNEMHDA(OFNLBNEMHDA other)
		: this()
	{
		oGHFMOALPEO_ = other.oGHFMOALPEO_;
		panelId_ = other.panelId_;
		groupId_ = other.groupId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFNLBNEMHDA Clone()
	{
		return new OFNLBNEMHDA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFNLBNEMHDA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFNLBNEMHDA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OGHFMOALPEO != other.OGHFMOALPEO)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (GroupId != other.GroupId)
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
		if (OGHFMOALPEO != 0)
		{
			num ^= OGHFMOALPEO.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
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
		if (OGHFMOALPEO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OGHFMOALPEO);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PanelId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GroupId);
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
		if (OGHFMOALPEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGHFMOALPEO);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFNLBNEMHDA other)
	{
		if (other != null)
		{
			if (other.OGHFMOALPEO != 0)
			{
				OGHFMOALPEO = other.OGHFMOALPEO;
			}
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
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
			case 8u:
				OGHFMOALPEO = input.ReadUInt32();
				break;
			case 96u:
				PanelId = input.ReadUInt32();
				break;
			case 104u:
				GroupId = input.ReadUInt32();
				break;
			}
		}
	}
}
