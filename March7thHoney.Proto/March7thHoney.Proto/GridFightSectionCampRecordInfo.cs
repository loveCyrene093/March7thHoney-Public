using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightSectionCampRecordInfo : IMessage<GridFightSectionCampRecordInfo>, IMessage, IEquatable<GridFightSectionCampRecordInfo>, IDeepCloneable<GridFightSectionCampRecordInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightSectionCampRecordInfo> _parser = new MessageParser<GridFightSectionCampRecordInfo>(() => new GridFightSectionCampRecordInfo());

	private UnknownFieldSet _unknownFields;

	public const int PMOGHFIGKPOFieldNumber = 5;

	private uint pMOGHFIGKPO_;

	public const int GDHHGKIAMNEFieldNumber = 14;

	private uint gDHHGKIAMNE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightSectionCampRecordInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightSectionCampRecordInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint GDHHGKIAMNE
	{
		get
		{
			return gDHHGKIAMNE_;
		}
		set
		{
			gDHHGKIAMNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionCampRecordInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionCampRecordInfo(GridFightSectionCampRecordInfo other)
		: this()
	{
		pMOGHFIGKPO_ = other.pMOGHFIGKPO_;
		gDHHGKIAMNE_ = other.gDHHGKIAMNE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightSectionCampRecordInfo Clone()
	{
		return new GridFightSectionCampRecordInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightSectionCampRecordInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightSectionCampRecordInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PMOGHFIGKPO != other.PMOGHFIGKPO)
		{
			return false;
		}
		if (GDHHGKIAMNE != other.GDHHGKIAMNE)
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
		if (PMOGHFIGKPO != 0)
		{
			num ^= PMOGHFIGKPO.GetHashCode();
		}
		if (GDHHGKIAMNE != 0)
		{
			num ^= GDHHGKIAMNE.GetHashCode();
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
		if (PMOGHFIGKPO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(PMOGHFIGKPO);
		}
		if (GDHHGKIAMNE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(GDHHGKIAMNE);
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
		if (PMOGHFIGKPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMOGHFIGKPO);
		}
		if (GDHHGKIAMNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GDHHGKIAMNE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightSectionCampRecordInfo other)
	{
		if (other != null)
		{
			if (other.PMOGHFIGKPO != 0)
			{
				PMOGHFIGKPO = other.PMOGHFIGKPO;
			}
			if (other.GDHHGKIAMNE != 0)
			{
				GDHHGKIAMNE = other.GDHHGKIAMNE;
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
			case 40u:
				PMOGHFIGKPO = input.ReadUInt32();
				break;
			case 112u:
				GDHHGKIAMNE = input.ReadUInt32();
				break;
			}
		}
	}
}
