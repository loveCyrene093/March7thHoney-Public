using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameAugmentInfo : IMessage<GridGameAugmentInfo>, IMessage, IEquatable<GridGameAugmentInfo>, IDeepCloneable<GridGameAugmentInfo>, IBufferMessage
{
	private static readonly MessageParser<GridGameAugmentInfo> _parser = new MessageParser<GridGameAugmentInfo>(() => new GridGameAugmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int NDCFBKJDPAHFieldNumber = 3;

	private bool nDCFBKJDPAH_;

	public const int MHMLMKDFJLNFieldNumber = 9;

	private bool mHMLMKDFJLN_;

	public const int AugmentIdFieldNumber = 10;

	private uint augmentId_;

	public const int PHPOLHLJGFMFieldNumber = 14;

	private static readonly FieldCodec<GridFightGameItemInfo> _repeated_pHPOLHLJGFM_codec = FieldCodec.ForMessage(114u, GridFightGameItemInfo.Parser);

	private readonly RepeatedField<GridFightGameItemInfo> pHPOLHLJGFM_ = new RepeatedField<GridFightGameItemInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameAugmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameAugmentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NDCFBKJDPAH
	{
		get
		{
			return nDCFBKJDPAH_;
		}
		set
		{
			nDCFBKJDPAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MHMLMKDFJLN
	{
		get
		{
			return mHMLMKDFJLN_;
		}
		set
		{
			mHMLMKDFJLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AugmentId
	{
		get
		{
			return augmentId_;
		}
		set
		{
			augmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightGameItemInfo> PHPOLHLJGFM => pHPOLHLJGFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameAugmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameAugmentInfo(GridGameAugmentInfo other)
		: this()
	{
		nDCFBKJDPAH_ = other.nDCFBKJDPAH_;
		mHMLMKDFJLN_ = other.mHMLMKDFJLN_;
		augmentId_ = other.augmentId_;
		pHPOLHLJGFM_ = other.pHPOLHLJGFM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameAugmentInfo Clone()
	{
		return new GridGameAugmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameAugmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameAugmentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NDCFBKJDPAH != other.NDCFBKJDPAH)
		{
			return false;
		}
		if (MHMLMKDFJLN != other.MHMLMKDFJLN)
		{
			return false;
		}
		if (AugmentId != other.AugmentId)
		{
			return false;
		}
		if (!pHPOLHLJGFM_.Equals(other.pHPOLHLJGFM_))
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
		if (NDCFBKJDPAH)
		{
			num ^= NDCFBKJDPAH.GetHashCode();
		}
		if (MHMLMKDFJLN)
		{
			num ^= MHMLMKDFJLN.GetHashCode();
		}
		if (AugmentId != 0)
		{
			num ^= AugmentId.GetHashCode();
		}
		num ^= pHPOLHLJGFM_.GetHashCode();
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
		if (NDCFBKJDPAH)
		{
			output.WriteRawTag(24);
			output.WriteBool(NDCFBKJDPAH);
		}
		if (MHMLMKDFJLN)
		{
			output.WriteRawTag(72);
			output.WriteBool(MHMLMKDFJLN);
		}
		if (AugmentId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AugmentId);
		}
		pHPOLHLJGFM_.WriteTo(ref output, _repeated_pHPOLHLJGFM_codec);
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
		if (NDCFBKJDPAH)
		{
			num += 2;
		}
		if (MHMLMKDFJLN)
		{
			num += 2;
		}
		if (AugmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AugmentId);
		}
		num += pHPOLHLJGFM_.CalculateSize(_repeated_pHPOLHLJGFM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameAugmentInfo other)
	{
		if (other != null)
		{
			if (other.NDCFBKJDPAH)
			{
				NDCFBKJDPAH = other.NDCFBKJDPAH;
			}
			if (other.MHMLMKDFJLN)
			{
				MHMLMKDFJLN = other.MHMLMKDFJLN;
			}
			if (other.AugmentId != 0)
			{
				AugmentId = other.AugmentId;
			}
			pHPOLHLJGFM_.Add(other.pHPOLHLJGFM_);
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
			case 24u:
				NDCFBKJDPAH = input.ReadBool();
				break;
			case 72u:
				MHMLMKDFJLN = input.ReadBool();
				break;
			case 80u:
				AugmentId = input.ReadUInt32();
				break;
			case 114u:
				pHPOLHLJGFM_.AddEntriesFrom(ref input, _repeated_pHPOLHLJGFM_codec);
				break;
			}
		}
	}
}
