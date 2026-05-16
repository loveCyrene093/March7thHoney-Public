using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightPortalBuffActionInfo : IMessage<GridFightPortalBuffActionInfo>, IMessage, IEquatable<GridFightPortalBuffActionInfo>, IDeepCloneable<GridFightPortalBuffActionInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightPortalBuffActionInfo> _parser = new MessageParser<GridFightPortalBuffActionInfo>(() => new GridFightPortalBuffActionInfo());

	private UnknownFieldSet _unknownFields;

	public const int EOOPOFCCHAAFieldNumber = 1;

	private uint eOOPOFCCHAA_;

	public const int MGCELCAJLLGFieldNumber = 2;

	private uint mGCELCAJLLG_;

	public const int GridFightPortalBuffListFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_gridFightPortalBuffList_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> gridFightPortalBuffList_ = new RepeatedField<uint>();

	public const int FCHPJKAIBHBFieldNumber = 13;

	private uint fCHPJKAIBHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightPortalBuffActionInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightPortalBuffActionInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EOOPOFCCHAA
	{
		get
		{
			return eOOPOFCCHAA_;
		}
		set
		{
			eOOPOFCCHAA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGCELCAJLLG
	{
		get
		{
			return mGCELCAJLLG_;
		}
		set
		{
			mGCELCAJLLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightPortalBuffList => gridFightPortalBuffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FCHPJKAIBHB
	{
		get
		{
			return fCHPJKAIBHB_;
		}
		set
		{
			fCHPJKAIBHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionInfo(GridFightPortalBuffActionInfo other)
		: this()
	{
		eOOPOFCCHAA_ = other.eOOPOFCCHAA_;
		mGCELCAJLLG_ = other.mGCELCAJLLG_;
		gridFightPortalBuffList_ = other.gridFightPortalBuffList_.Clone();
		fCHPJKAIBHB_ = other.fCHPJKAIBHB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPortalBuffActionInfo Clone()
	{
		return new GridFightPortalBuffActionInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightPortalBuffActionInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightPortalBuffActionInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EOOPOFCCHAA != other.EOOPOFCCHAA)
		{
			return false;
		}
		if (MGCELCAJLLG != other.MGCELCAJLLG)
		{
			return false;
		}
		if (!gridFightPortalBuffList_.Equals(other.gridFightPortalBuffList_))
		{
			return false;
		}
		if (FCHPJKAIBHB != other.FCHPJKAIBHB)
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
		if (EOOPOFCCHAA != 0)
		{
			num ^= EOOPOFCCHAA.GetHashCode();
		}
		if (MGCELCAJLLG != 0)
		{
			num ^= MGCELCAJLLG.GetHashCode();
		}
		num ^= gridFightPortalBuffList_.GetHashCode();
		if (FCHPJKAIBHB != 0)
		{
			num ^= FCHPJKAIBHB.GetHashCode();
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
		if (EOOPOFCCHAA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EOOPOFCCHAA);
		}
		if (MGCELCAJLLG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGCELCAJLLG);
		}
		gridFightPortalBuffList_.WriteTo(ref output, _repeated_gridFightPortalBuffList_codec);
		if (FCHPJKAIBHB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FCHPJKAIBHB);
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
		if (EOOPOFCCHAA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOOPOFCCHAA);
		}
		if (MGCELCAJLLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGCELCAJLLG);
		}
		num += gridFightPortalBuffList_.CalculateSize(_repeated_gridFightPortalBuffList_codec);
		if (FCHPJKAIBHB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FCHPJKAIBHB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightPortalBuffActionInfo other)
	{
		if (other != null)
		{
			if (other.EOOPOFCCHAA != 0)
			{
				EOOPOFCCHAA = other.EOOPOFCCHAA;
			}
			if (other.MGCELCAJLLG != 0)
			{
				MGCELCAJLLG = other.MGCELCAJLLG;
			}
			gridFightPortalBuffList_.Add(other.gridFightPortalBuffList_);
			if (other.FCHPJKAIBHB != 0)
			{
				FCHPJKAIBHB = other.FCHPJKAIBHB;
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
				EOOPOFCCHAA = input.ReadUInt32();
				break;
			case 16u:
				MGCELCAJLLG = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				gridFightPortalBuffList_.AddEntriesFrom(ref input, _repeated_gridFightPortalBuffList_codec);
				break;
			case 104u:
				FCHPJKAIBHB = input.ReadUInt32();
				break;
			}
		}
	}
}
