using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAOHPOPIAFH : IMessage<JAOHPOPIAFH>, IMessage, IEquatable<JAOHPOPIAFH>, IDeepCloneable<JAOHPOPIAFH>, IBufferMessage
{
	private static readonly MessageParser<JAOHPOPIAFH> _parser = new MessageParser<JAOHPOPIAFH>(() => new JAOHPOPIAFH());

	private UnknownFieldSet _unknownFields;

	public const int NCFHGIBCEBGFieldNumber = 1;

	private uint nCFHGIBCEBG_;

	public const int HCJPDNDOHAMFieldNumber = 2;

	private uint hCJPDNDOHAM_;

	public const int DiceSlotIdFieldNumber = 3;

	private uint diceSlotId_;

	public const int IBHKOGPEICNFieldNumber = 4;

	private long iBHKOGPEICN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAOHPOPIAFH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAOHPOPIAFHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCFHGIBCEBG
	{
		get
		{
			return nCFHGIBCEBG_;
		}
		set
		{
			nCFHGIBCEBG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCJPDNDOHAM
	{
		get
		{
			return hCJPDNDOHAM_;
		}
		set
		{
			hCJPDNDOHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DiceSlotId
	{
		get
		{
			return diceSlotId_;
		}
		set
		{
			diceSlotId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long IBHKOGPEICN
	{
		get
		{
			return iBHKOGPEICN_;
		}
		set
		{
			iBHKOGPEICN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAOHPOPIAFH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAOHPOPIAFH(JAOHPOPIAFH other)
		: this()
	{
		nCFHGIBCEBG_ = other.nCFHGIBCEBG_;
		hCJPDNDOHAM_ = other.hCJPDNDOHAM_;
		diceSlotId_ = other.diceSlotId_;
		iBHKOGPEICN_ = other.iBHKOGPEICN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAOHPOPIAFH Clone()
	{
		return new JAOHPOPIAFH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAOHPOPIAFH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAOHPOPIAFH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NCFHGIBCEBG != other.NCFHGIBCEBG)
		{
			return false;
		}
		if (HCJPDNDOHAM != other.HCJPDNDOHAM)
		{
			return false;
		}
		if (DiceSlotId != other.DiceSlotId)
		{
			return false;
		}
		if (IBHKOGPEICN != other.IBHKOGPEICN)
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
		if (NCFHGIBCEBG != 0)
		{
			num ^= NCFHGIBCEBG.GetHashCode();
		}
		if (HCJPDNDOHAM != 0)
		{
			num ^= HCJPDNDOHAM.GetHashCode();
		}
		if (DiceSlotId != 0)
		{
			num ^= DiceSlotId.GetHashCode();
		}
		if (IBHKOGPEICN != 0L)
		{
			num ^= IBHKOGPEICN.GetHashCode();
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
		if (NCFHGIBCEBG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NCFHGIBCEBG);
		}
		if (HCJPDNDOHAM != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(HCJPDNDOHAM);
		}
		if (DiceSlotId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DiceSlotId);
		}
		if (IBHKOGPEICN != 0L)
		{
			output.WriteRawTag(32);
			output.WriteInt64(IBHKOGPEICN);
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
		if (NCFHGIBCEBG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCFHGIBCEBG);
		}
		if (HCJPDNDOHAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCJPDNDOHAM);
		}
		if (DiceSlotId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DiceSlotId);
		}
		if (IBHKOGPEICN != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(IBHKOGPEICN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAOHPOPIAFH other)
	{
		if (other != null)
		{
			if (other.NCFHGIBCEBG != 0)
			{
				NCFHGIBCEBG = other.NCFHGIBCEBG;
			}
			if (other.HCJPDNDOHAM != 0)
			{
				HCJPDNDOHAM = other.HCJPDNDOHAM;
			}
			if (other.DiceSlotId != 0)
			{
				DiceSlotId = other.DiceSlotId;
			}
			if (other.IBHKOGPEICN != 0L)
			{
				IBHKOGPEICN = other.IBHKOGPEICN;
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
				NCFHGIBCEBG = input.ReadUInt32();
				break;
			case 16u:
				HCJPDNDOHAM = input.ReadUInt32();
				break;
			case 24u:
				DiceSlotId = input.ReadUInt32();
				break;
			case 32u:
				IBHKOGPEICN = input.ReadInt64();
				break;
			}
		}
	}
}
