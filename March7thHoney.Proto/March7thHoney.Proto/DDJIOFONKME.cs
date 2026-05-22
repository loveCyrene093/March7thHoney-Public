using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DDJIOFONKME : IMessage<DDJIOFONKME>, IMessage, IEquatable<DDJIOFONKME>, IDeepCloneable<DDJIOFONKME>, IBufferMessage
{
	private static readonly MessageParser<DDJIOFONKME> _parser = new MessageParser<DDJIOFONKME>(() => new DDJIOFONKME());

	private UnknownFieldSet _unknownFields;

	public const int KILABGPMPBBFieldNumber = 9;

	private static readonly FieldCodec<GridFightSectionRecordInfo> _repeated_kILABGPMPBB_codec = FieldCodec.ForMessage(74u, GridFightSectionRecordInfo.Parser);

	private readonly RepeatedField<GridFightSectionRecordInfo> kILABGPMPBB_ = new RepeatedField<GridFightSectionRecordInfo>();

	public const int GridFightDamageSttInfoFieldNumber = 13;

	private GridFightDamageSttInfo gridFightDamageSttInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DDJIOFONKME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DDJIOFONKMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightSectionRecordInfo> KILABGPMPBB => kILABGPMPBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightDamageSttInfo GridFightDamageSttInfo
	{
		get
		{
			return gridFightDamageSttInfo_;
		}
		set
		{
			gridFightDamageSttInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJIOFONKME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJIOFONKME(DDJIOFONKME other)
		: this()
	{
		kILABGPMPBB_ = other.kILABGPMPBB_.Clone();
		gridFightDamageSttInfo_ = ((other.gridFightDamageSttInfo_ != null) ? other.gridFightDamageSttInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJIOFONKME Clone()
	{
		return new DDJIOFONKME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DDJIOFONKME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DDJIOFONKME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kILABGPMPBB_.Equals(other.kILABGPMPBB_))
		{
			return false;
		}
		if (!object.Equals(GridFightDamageSttInfo, other.GridFightDamageSttInfo))
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
		num ^= kILABGPMPBB_.GetHashCode();
		if (gridFightDamageSttInfo_ != null)
		{
			num ^= GridFightDamageSttInfo.GetHashCode();
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
		kILABGPMPBB_.WriteTo(ref output, _repeated_kILABGPMPBB_codec);
		if (gridFightDamageSttInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(GridFightDamageSttInfo);
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
		num += kILABGPMPBB_.CalculateSize(_repeated_kILABGPMPBB_codec);
		if (gridFightDamageSttInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GridFightDamageSttInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DDJIOFONKME other)
	{
		if (other == null)
		{
			return;
		}
		kILABGPMPBB_.Add(other.kILABGPMPBB_);
		if (other.gridFightDamageSttInfo_ != null)
		{
			if (gridFightDamageSttInfo_ == null)
			{
				GridFightDamageSttInfo = new GridFightDamageSttInfo();
			}
			GridFightDamageSttInfo.MergeFrom(other.GridFightDamageSttInfo);
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
			case 74u:
				kILABGPMPBB_.AddEntriesFrom(ref input, _repeated_kILABGPMPBB_codec);
				break;
			case 106u:
				if (gridFightDamageSttInfo_ == null)
				{
					GridFightDamageSttInfo = new GridFightDamageSttInfo();
				}
				input.ReadMessage(GridFightDamageSttInfo);
				break;
			}
		}
	}
}
