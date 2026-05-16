using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JFPBEDFKINJ : IMessage<JFPBEDFKINJ>, IMessage, IEquatable<JFPBEDFKINJ>, IDeepCloneable<JFPBEDFKINJ>, IBufferMessage
{
	private static readonly MessageParser<JFPBEDFKINJ> _parser = new MessageParser<JFPBEDFKINJ>(() => new JFPBEDFKINJ());

	private UnknownFieldSet _unknownFields;

	public const int MBLPHKFGOJBFieldNumber = 2;

	private KGCLNMHAAMM mBLPHKFGOJB_;

	public const int ItemIdFieldNumber = 7;

	private uint itemId_;

	public const int FBCJCKEAHCMFieldNumber = 15;

	private uint fBCJCKEAHCM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JFPBEDFKINJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JFPBEDFKINJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KGCLNMHAAMM MBLPHKFGOJB
	{
		get
		{
			return mBLPHKFGOJB_;
		}
		set
		{
			mBLPHKFGOJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemId
	{
		get
		{
			return itemId_;
		}
		set
		{
			itemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FBCJCKEAHCM
	{
		get
		{
			return fBCJCKEAHCM_;
		}
		set
		{
			fBCJCKEAHCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPBEDFKINJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPBEDFKINJ(JFPBEDFKINJ other)
		: this()
	{
		mBLPHKFGOJB_ = ((other.mBLPHKFGOJB_ != null) ? other.mBLPHKFGOJB_.Clone() : null);
		itemId_ = other.itemId_;
		fBCJCKEAHCM_ = other.fBCJCKEAHCM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JFPBEDFKINJ Clone()
	{
		return new JFPBEDFKINJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JFPBEDFKINJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JFPBEDFKINJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MBLPHKFGOJB, other.MBLPHKFGOJB))
		{
			return false;
		}
		if (ItemId != other.ItemId)
		{
			return false;
		}
		if (FBCJCKEAHCM != other.FBCJCKEAHCM)
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
		if (mBLPHKFGOJB_ != null)
		{
			num ^= MBLPHKFGOJB.GetHashCode();
		}
		if (ItemId != 0)
		{
			num ^= ItemId.GetHashCode();
		}
		if (FBCJCKEAHCM != 0)
		{
			num ^= FBCJCKEAHCM.GetHashCode();
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
		if (mBLPHKFGOJB_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MBLPHKFGOJB);
		}
		if (ItemId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ItemId);
		}
		if (FBCJCKEAHCM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(FBCJCKEAHCM);
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
		if (mBLPHKFGOJB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MBLPHKFGOJB);
		}
		if (ItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemId);
		}
		if (FBCJCKEAHCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FBCJCKEAHCM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JFPBEDFKINJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mBLPHKFGOJB_ != null)
		{
			if (mBLPHKFGOJB_ == null)
			{
				MBLPHKFGOJB = new KGCLNMHAAMM();
			}
			MBLPHKFGOJB.MergeFrom(other.MBLPHKFGOJB);
		}
		if (other.ItemId != 0)
		{
			ItemId = other.ItemId;
		}
		if (other.FBCJCKEAHCM != 0)
		{
			FBCJCKEAHCM = other.FBCJCKEAHCM;
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
			case 18u:
				if (mBLPHKFGOJB_ == null)
				{
					MBLPHKFGOJB = new KGCLNMHAAMM();
				}
				input.ReadMessage(MBLPHKFGOJB);
				break;
			case 56u:
				ItemId = input.ReadUInt32();
				break;
			case 120u:
				FBCJCKEAHCM = input.ReadUInt32();
				break;
			}
		}
	}
}
