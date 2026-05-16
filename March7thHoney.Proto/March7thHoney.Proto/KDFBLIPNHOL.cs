using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KDFBLIPNHOL : IMessage<KDFBLIPNHOL>, IMessage, IEquatable<KDFBLIPNHOL>, IDeepCloneable<KDFBLIPNHOL>, IBufferMessage
{
	private static readonly MessageParser<KDFBLIPNHOL> _parser = new MessageParser<KDFBLIPNHOL>(() => new KDFBLIPNHOL());

	private UnknownFieldSet _unknownFields;

	public const int PanelIdFieldNumber = 7;

	private uint panelId_;

	public const int OGHFMOALPEOFieldNumber = 12;

	private uint oGHFMOALPEO_;

	public const int GroupIdFieldNumber = 13;

	private uint groupId_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KDFBLIPNHOL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KDFBLIPNHOLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public KDFBLIPNHOL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDFBLIPNHOL(KDFBLIPNHOL other)
		: this()
	{
		panelId_ = other.panelId_;
		oGHFMOALPEO_ = other.oGHFMOALPEO_;
		groupId_ = other.groupId_;
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KDFBLIPNHOL Clone()
	{
		return new KDFBLIPNHOL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KDFBLIPNHOL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KDFBLIPNHOL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (OGHFMOALPEO != other.OGHFMOALPEO)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (OGHFMOALPEO != 0)
		{
			num ^= OGHFMOALPEO.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (PanelId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(PanelId);
		}
		if (OGHFMOALPEO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OGHFMOALPEO);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(GroupId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
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
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (OGHFMOALPEO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OGHFMOALPEO);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KDFBLIPNHOL other)
	{
		if (other != null)
		{
			if (other.PanelId != 0)
			{
				PanelId = other.PanelId;
			}
			if (other.OGHFMOALPEO != 0)
			{
				OGHFMOALPEO = other.OGHFMOALPEO;
			}
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 56u:
				PanelId = input.ReadUInt32();
				break;
			case 96u:
				OGHFMOALPEO = input.ReadUInt32();
				break;
			case 104u:
				GroupId = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
