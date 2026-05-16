using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EBBEGDKGOHL : IMessage<EBBEGDKGOHL>, IMessage, IEquatable<EBBEGDKGOHL>, IDeepCloneable<EBBEGDKGOHL>, IBufferMessage
{
	private static readonly MessageParser<EBBEGDKGOHL> _parser = new MessageParser<EBBEGDKGOHL>(() => new EBBEGDKGOHL());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int OGHFMOALPEOFieldNumber = 7;

	private uint oGHFMOALPEO_;

	public const int PanelIdFieldNumber = 9;

	private uint panelId_;

	public const int GroupIdFieldNumber = 10;

	private uint groupId_;

	public const int FPOOGHEJDDNFieldNumber = 12;

	private HHMDONEOEAK fPOOGHEJDDN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EBBEGDKGOHL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EBBEGDKGOHLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public HHMDONEOEAK FPOOGHEJDDN
	{
		get
		{
			return fPOOGHEJDDN_;
		}
		set
		{
			fPOOGHEJDDN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBBEGDKGOHL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBBEGDKGOHL(EBBEGDKGOHL other)
		: this()
	{
		retcode_ = other.retcode_;
		oGHFMOALPEO_ = other.oGHFMOALPEO_;
		panelId_ = other.panelId_;
		groupId_ = other.groupId_;
		fPOOGHEJDDN_ = ((other.fPOOGHEJDDN_ != null) ? other.fPOOGHEJDDN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBBEGDKGOHL Clone()
	{
		return new EBBEGDKGOHL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EBBEGDKGOHL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EBBEGDKGOHL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
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
		if (!object.Equals(FPOOGHEJDDN, other.FPOOGHEJDDN))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
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
		if (fPOOGHEJDDN_ != null)
		{
			num ^= FPOOGHEJDDN.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (OGHFMOALPEO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OGHFMOALPEO);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PanelId);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GroupId);
		}
		if (fPOOGHEJDDN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FPOOGHEJDDN);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
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
		if (fPOOGHEJDDN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FPOOGHEJDDN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EBBEGDKGOHL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
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
		if (other.fPOOGHEJDDN_ != null)
		{
			if (fPOOGHEJDDN_ == null)
			{
				FPOOGHEJDDN = new HHMDONEOEAK();
			}
			FPOOGHEJDDN.MergeFrom(other.FPOOGHEJDDN);
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
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 56u:
				OGHFMOALPEO = input.ReadUInt32();
				break;
			case 72u:
				PanelId = input.ReadUInt32();
				break;
			case 80u:
				GroupId = input.ReadUInt32();
				break;
			case 98u:
				if (fPOOGHEJDDN_ == null)
				{
					FPOOGHEJDDN = new HHMDONEOEAK();
				}
				input.ReadMessage(FPOOGHEJDDN);
				break;
			}
		}
	}
}
