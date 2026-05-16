using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightPendingAugmentInfo : IMessage<GridFightPendingAugmentInfo>, IMessage, IEquatable<GridFightPendingAugmentInfo>, IDeepCloneable<GridFightPendingAugmentInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightPendingAugmentInfo> _parser = new MessageParser<GridFightPendingAugmentInfo>(() => new GridFightPendingAugmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int OLDLDGCEIMFFieldNumber = 2;

	private uint oLDLDGCEIMF_;

	public const int AugmentIdFieldNumber = 5;

	private uint augmentId_;

	public const int ALJBADEOPAHFieldNumber = 12;

	private uint aLJBADEOPAH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightPendingAugmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightPendingAugmentInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OLDLDGCEIMF
	{
		get
		{
			return oLDLDGCEIMF_;
		}
		set
		{
			oLDLDGCEIMF_ = value;
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
	public uint ALJBADEOPAH
	{
		get
		{
			return aLJBADEOPAH_;
		}
		set
		{
			aLJBADEOPAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAugmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAugmentInfo(GridFightPendingAugmentInfo other)
		: this()
	{
		oLDLDGCEIMF_ = other.oLDLDGCEIMF_;
		augmentId_ = other.augmentId_;
		aLJBADEOPAH_ = other.aLJBADEOPAH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightPendingAugmentInfo Clone()
	{
		return new GridFightPendingAugmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightPendingAugmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightPendingAugmentInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OLDLDGCEIMF != other.OLDLDGCEIMF)
		{
			return false;
		}
		if (AugmentId != other.AugmentId)
		{
			return false;
		}
		if (ALJBADEOPAH != other.ALJBADEOPAH)
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
		if (OLDLDGCEIMF != 0)
		{
			num ^= OLDLDGCEIMF.GetHashCode();
		}
		if (AugmentId != 0)
		{
			num ^= AugmentId.GetHashCode();
		}
		if (ALJBADEOPAH != 0)
		{
			num ^= ALJBADEOPAH.GetHashCode();
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
		if (OLDLDGCEIMF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(OLDLDGCEIMF);
		}
		if (AugmentId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AugmentId);
		}
		if (ALJBADEOPAH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ALJBADEOPAH);
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
		if (OLDLDGCEIMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OLDLDGCEIMF);
		}
		if (AugmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AugmentId);
		}
		if (ALJBADEOPAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ALJBADEOPAH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightPendingAugmentInfo other)
	{
		if (other != null)
		{
			if (other.OLDLDGCEIMF != 0)
			{
				OLDLDGCEIMF = other.OLDLDGCEIMF;
			}
			if (other.AugmentId != 0)
			{
				AugmentId = other.AugmentId;
			}
			if (other.ALJBADEOPAH != 0)
			{
				ALJBADEOPAH = other.ALJBADEOPAH;
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
			case 16u:
				OLDLDGCEIMF = input.ReadUInt32();
				break;
			case 40u:
				AugmentId = input.ReadUInt32();
				break;
			case 96u:
				ALJBADEOPAH = input.ReadUInt32();
				break;
			}
		}
	}
}
